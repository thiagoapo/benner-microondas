using MicroOndasDigital.Business;
using MicroOndasDigital.Business.Interface;
using MicroOndasDigital.Business.Utils;
using MicroOndasDigital.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroOndasDigital
{
    public partial class FormMicroOndasDigital : Form
    {
        #region Private Attributtes

        private readonly IMicroondasBusiness _business;
        private readonly ProgramaBusiness _programaBusiness;

        #endregion

        #region Constructor

        public FormMicroOndasDigital()
        {
            InitializeComponent();
            this._business = new MicroondasBusiness(this.txtResult);
            this._programaBusiness = new ProgramaBusiness();
            this._business.ConcluidoEvent += _business_ConcluidoEvent;
            this._business.ErroEvent += _business_ErroEvent;
            this.BtnVerTodos_Click(null, null);
        }

        #endregion

        #region Private Methods

        private void _business_ErroEvent(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void _business_ConcluidoEvent(object sender, EventArgs e)
        {
            var result = this._business.BuscaResultado();
            this._business.SetaResultado(result + sender.ToString());
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this._business.Cancela();
        }

        private void BtnInicioRapido_Click(object sender, EventArgs e)
        {
            numTempoMin.Value = 0;
            numTempoSeg.Value = 30;
            numPotencia.Value = 8;
            Iniciar();
        }

        private void BtnFiltrarCompativeis_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = this._programaBusiness.BuscaCompativel(new MicroondasModel()
                {
                    Bandeja = txtBandeja.Text
                });

                dgProgramas.DataSource = lista;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            var lista = this._programaBusiness.BuscaTodos();
            dgProgramas.DataSource = lista;
        }

        private void BtnIniciarPrograma_Click(object sender, EventArgs e)
        {
            if (dgProgramas.SelectedRows.Count == 0)
            {
                MessageBox.Show(ResourceStringUtil.SelecionePrograma);
                return;
            }

            var item = (ProgramaModel)dgProgramas.SelectedRows[0].DataBoundItem;

            numTempoMin.Value = item.TempoMin;
            numTempoSeg.Value = item.TempoSeg;
            numPotencia.Value = item.Potencia;
            Iniciar(item.Pontuacao, item);
        }

        private void BtnCustomAdd_Click(object sender, EventArgs e)
        {
            if (dgProgramas.SelectedRows.Count == 0)
            {
                MessageBox.Show(ResourceStringUtil.SelecionePrograma);
                return;
            }

            var item = (ProgramaModel)dgProgramas.SelectedRows[0].DataBoundItem;

            var form = Application.OpenForms["FormEstender"];
            if (form != null)
                form.BringToFront();
            else
            {
                FormEstender formEstender = new FormEstender(item);
                formEstender.EstenderEvent += FormEstender_EstenderEvent;
                formEstender.Show();
            }
        }

        private void FormEstender_EstenderEvent(object sender, EventArgs e)
        {
            try
            {
                var programa = (ProgramaModel)sender;
                this._programaBusiness.AdicionaCustomizado(programa);
                this.BtnVerTodos_Click(null, null);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void BtnCustomDel_Click(object sender, EventArgs e)
        {
            if (dgProgramas.SelectedRows.Count == 0)
            {
                MessageBox.Show(ResourceStringUtil.SelecioneProgramaCustomizado);
                return;
            }

            var item = (ProgramaModel)dgProgramas.SelectedRows[0].DataBoundItem;

            if (!item.Custom)
            {
                MessageBox.Show(ResourceStringUtil.SelecioneProgramaCustomizado);
                return;
            }

            this._programaBusiness.DeletaCustomizado(item);
            this.BtnVerTodos_Click(null, null);
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            this._business.Pausa();
        }

        #endregion

        #region Generic Methods
        private void Iniciar(string pontuacao = ".", ProgramaModel programa = null)
        {
            try
            {
                var microondas = new MicroondasModel()
                {
                    Bandeja = txtBandeja.Text,
                    TempoMin = Decimal.ToInt32(numTempoMin.Value),
                    TempoSeg = Decimal.ToInt32(numTempoSeg.Value),
                    Potencia = Decimal.ToInt32(numPotencia.Value),
                    Pontuacao = pontuacao
                };
                numTempoMin.Value = microondas.TempoMinInteger;
                numTempoSeg.Value = microondas.TempoSegInteger;
                numPotencia.Value = microondas.PotenciaInteger;

                //se for programação, verificar a compatibildade do alimento da bandeja
                if (programa != null)
                    this._programaBusiness.ValidaCompativel(microondas, programa);

                this._business.Inicia(microondas);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion
    }
}
