
using MicroOndasDigital.Business.Interface;
using MicroOndasDigital.Business.Utils;
using MicroOndasDigital.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MicroOndasDigital.Business
{
    public class MicroondasBusiness : IMicroondasBusiness
    {
        #region Private Attributtes

        private System.Windows.Forms.Timer _tempoMicroondas;
        private int _tempoCount;
        private MicroondasModel _microondas;
        private TextBox _dadosResultado;

        #endregion

        #region Public Attributtes

        public event EventHandler ConcluidoEvent;
        public event EventHandler ErroEvent;

        #endregion

        #region Constructor

        public MicroondasBusiness(TextBox resultado)
        {
            this._dadosResultado = resultado;
            Inicializa();
        }

        public MicroondasBusiness()
        {
            Inicializa();
        }

        private void Inicializa()
        {
            this._tempoCount = 0;
            this._tempoMicroondas = new System.Windows.Forms.Timer();
            this._tempoMicroondas.Interval = 1000;
            this._tempoMicroondas.Enabled = true;
            this._tempoMicroondas.Stop();
            this._tempoMicroondas.Tick += _tempoMicroondas_Tick;
        }

        private void _tempoMicroondas_Tick(object sender, EventArgs e)
        {
            var result = this.BuscaResultado();
            result += "".PadRight(this._microondas.PotenciaInteger, char.Parse(this._microondas.Pontuacao));
            this.SetaResultado(result);
            this._tempoCount++;
            if (this._microondas.Tempo.TotalSeconds == _tempoCount)
            {
                this._tempoMicroondas.Stop();
                _tempoCount = 0;
                ConcluidoEvent("aquecida", EventArgs.Empty);
            }
        }

        #endregion

        #region Public Methods

        public bool Valida(MicroondasModel microondas, bool simples = false)
        {
            if (string.IsNullOrEmpty(microondas.Bandeja))
            {
                ErroEvent(ResourceStringUtil.BandejaNula, EventArgs.Empty);
                return false;
            }

            //verifica se é arquivo de texto e se arquivo existe
            if (microondas.Arquivo)
            {
                if (!File.Exists(microondas.Bandeja))
                {
                    ErroEvent(ResourceStringUtil.ArquivoNaoEncontrado, EventArgs.Empty);
                    return false;
                }

                var alimentoBandeja = this.BuscaResultadoLinha1();
                if (string.IsNullOrEmpty(alimentoBandeja.Trim()))
                {
                    ErroEvent(ResourceStringUtil.ArquivoBandejaNula, EventArgs.Empty);
                    return false;
                }
            }

            //Início rápido ou compatibilidade de programa só precisa da validação acima
            if (simples)
                return true;

            if (microondas.TempoMin == 0 && microondas.TempoSeg == 0)
            {
                ErroEvent(ResourceStringUtil.TempoCozimentoNulo, EventArgs.Empty);
                return false;
            }

            if (!ValidaUtil.ValidaInt(microondas.TempoMin) || !ValidaUtil.ValidaInt(microondas.TempoSeg))
            {
                ErroEvent(ResourceStringUtil.TempoCozimentoFracionado, EventArgs.Empty);
                return false;
            }

            if (microondas.Tempo.TotalSeconds > 120 || microondas.Tempo.TotalSeconds < 1)
            {
                ErroEvent(ResourceStringUtil.TempoCozimentoForaIntervalo, EventArgs.Empty);
                return false;
            }

            if (microondas.Potencia > 10 || microondas.Potencia < 1)
            {
                ErroEvent(ResourceStringUtil.PotenciaForaIntervalo, EventArgs.Empty);
                return false;
            }

            if (!ValidaUtil.ValidaInt(microondas.Potencia))
            {
                ErroEvent(ResourceStringUtil.PotenciaFracionada, EventArgs.Empty);
                return false;
            }

            return true;
        }

        public void Inicia(MicroondasModel microondas)
        {
            this._tempoCount = 0;
            this.SetaMicroondas(microondas);

            //validar entradas
            if (!this.Valida(microondas))
                return;

            //se não for aquivo seta a bandeja no resultado
            if (!this._microondas.Arquivo)
                this.SetaResultado(microondas.Bandeja);
            else
                this.SetaResultado(this.BuscaResultadoLinha1());

            this._microondas.Status = Entities.Enums.MicroondasStatusEnum.Executando;
            this._tempoMicroondas.Start();
        }

        public void Cancela()
        {
            this._microondas.Status = Entities.Enums.MicroondasStatusEnum.Cancelado;
            this._tempoMicroondas.Stop();
            this.SetaResultado("cancelado");
        }

        public void Pausa()
        {
            if (this._microondas.Status == Entities.Enums.MicroondasStatusEnum.Executando)
            {
                this._microondas.Status = Entities.Enums.MicroondasStatusEnum.Pausado;
                this._tempoMicroondas.Stop();
                var result = this.BuscaResultado();
                this.SetaResultado(result + "pausado");
            }
            else if (this._microondas.Status == Entities.Enums.MicroondasStatusEnum.Pausado)
            {
                this._microondas.Status = Entities.Enums.MicroondasStatusEnum.Executando;
                var result = this.BuscaResultado();
                //retirando "pausado" do resultado para continuar de onde parou
                result = result.Substring(0, result.Count() - 7);
                this.SetaResultado(result);
                this._tempoMicroondas.Start();
            }
        }

        public string BuscaResultado()
        {
            if (this._microondas.Arquivo)
            {
                return this.BuscaResultadoLinha2();
            }
            else
            {
                if (this._dadosResultado != null)
                    return this._dadosResultado.Text;

                return null;
            }
        }

        public string BuscaResultadoLinha1()
        {
            if (this._microondas.Arquivo)
            {
                var lines = File.ReadAllLines(this._microondas.Bandeja);
                return lines[0];
            }
            return string.Empty;
        }

        public string BuscaResultadoLinha2()
        {
            if (this._microondas.Arquivo)
            {
                var lines = File.ReadAllLines(this._microondas.Bandeja);
                return lines[1];
            }
            return string.Empty;
        }

        public void SetaResultado(string result)
        {

            if (this._microondas.Arquivo)
            {
                string[] lines = new string[] { this.BuscaResultadoLinha1(), result };
                File.WriteAllLines(this._microondas.Bandeja, lines);
                if (this._dadosResultado != null && !string.IsNullOrEmpty(result))
                    this._dadosResultado.Text = "Ver arquivo!";
            }
            else
            {
                if (this._dadosResultado != null)
                    this._dadosResultado.Text = result;
            }
        }

        public void SetaMicroondas(MicroondasModel microondas)
        {
            this._microondas = microondas;

            //se for arquivo arrumar o conteudo dele antes de validar
            if (this._microondas.Arquivo)
            {
                this.SetaResultado(string.Empty);
            }
        }

        #endregion
    }
}
