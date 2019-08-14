using MicroOndasDigital.Business.Interface;
using MicroOndasDigital.Business.Utils;
using MicroOndasDigital.Data;
using MicroOndasDigital.Data.Interface;
using MicroOndasDigital.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Business
{
    public class ProgramaBusiness : IProgramaBusiness
    {
        #region Private Attributtes

        private readonly MicroondasBusiness _microondasBusiness;
        private readonly IProgramaData _data;

        #endregion

        #region Constructor

        public ProgramaBusiness()
        {
            _microondasBusiness = new MicroondasBusiness();
            _data = new ProgramaData();
        }

        #endregion

        #region Public Methods

        public void Valida(MicroondasModel microondas)
        {
            if (string.IsNullOrEmpty(microondas.Bandeja))
            {
                throw new Exception(ResourceStringUtil.BandejaNula);
            }

            //verifica se é arquivo de texto e se arquivo existe
            if (microondas.Arquivo)
            {
                if (!File.Exists(microondas.Bandeja))
                {
                    throw new Exception(ResourceStringUtil.ArquivoNaoEncontrado);
                }

                var alimentoBandeja = _microondasBusiness.BuscaResultadoLinha1();
                if (string.IsNullOrEmpty(alimentoBandeja.Trim()))
                {
                    throw new Exception(ResourceStringUtil.ArquivoBandejaNula);
                }
            }

        }

        public void ValidaCustomizado(ProgramaModel programa)
        {
            if (string.IsNullOrEmpty(programa.Nome))
            {
                throw new Exception(ResourceStringUtil.ProgramaNomeNulo);
            }

            if (programa.TempoMin == 0 && programa.TempoSeg == 0)
            {
                throw new Exception(ResourceStringUtil.TempoCozimentoNulo);
            }

            if (!ValidaUtil.ValidaInt(programa.TempoMin) || !ValidaUtil.ValidaInt(programa.TempoSeg))
            {
                throw new Exception(ResourceStringUtil.TempoCozimentoFracionado);
            }

            if (programa.Tempo.TotalSeconds > 120 || programa.Tempo.TotalSeconds < 1)
            {
                throw new Exception(ResourceStringUtil.TempoCozimentoForaIntervalo);
            }

            if (programa.Potencia > 10 || programa.Potencia < 1)
            {
                throw new Exception(ResourceStringUtil.PotenciaForaIntervalo);
            }

            if (!ValidaUtil.ValidaInt(programa.Potencia))
            {
                throw new Exception(ResourceStringUtil.PotenciaFracionada);
            }

            if (programa.TagList == null || programa.TagList.Length == 0)
            {
                throw new Exception(ResourceStringUtil.ProgramaTagListaNula);
            }

            if (string.IsNullOrEmpty(programa.Pontuacao))
            {
                throw new Exception(ResourceStringUtil.ProgramaPontuacaoNula);
            }
        }

        public List<ProgramaModel> BuscaCompativel(MicroondasModel microondas)
        {
            this._microondasBusiness.SetaMicroondas(microondas);
            this.Valida(microondas);

            List<ProgramaModel> returnList = new List<ProgramaModel>();

            var querySearch = microondas.Arquivo ? _microondasBusiness.BuscaResultadoLinha1() : microondas.Bandeja;

            var searchList = querySearch.ToLower().Split(' ');
            searchList.ToList().ForEach(search =>
            {
                returnList.AddRange(_data.BuscaTodos().Where(p => p.TagList.Any(t => t == search)));
            });

            return returnList;
        }

        public void ValidaCompativel(MicroondasModel microondas, ProgramaModel programa)
        {
            this._microondasBusiness.SetaMicroondas(microondas);
            this.Valida(microondas);
            bool compativel = false;

            var querySearch = microondas.Arquivo ? _microondasBusiness.BuscaResultadoLinha1() : microondas.Bandeja;

            var searchList = querySearch.ToLower().Split(' ');
            searchList.ToList().ForEach(search =>
            {
                if (programa.TagList.Any(t => t == search))
                    compativel = true;
            });

            if (!compativel)
            {
                throw new Exception(ResourceStringUtil.ProgramaAlimentoNaoCompativel);
            }
        }

        public List<ProgramaModel> BuscaTodos()
        {
            return _data.BuscaTodos();
        }

        public void AdicionaCustomizado(ProgramaModel programa)
        {
            _data.AdicionaCustomizado(programa);
        }

        public void DeletaCustomizado(ProgramaModel programa)
        {
            _data.DeletaCustomizado(programa.Id);
        }

        #endregion
    }
}
