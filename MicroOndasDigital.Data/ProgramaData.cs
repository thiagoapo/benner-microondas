
using MicroOndasDigital.Data.Interface;
using MicroOndasDigital.Data.Utils;
using MicroOndasDigital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Data
{
    public class ProgramaData: IProgramaData
    {
        #region Public Methods

        public List<ProgramaModel> BuscaTodos()
        {
            List<ProgramaModel> result = new List<ProgramaModel>();
            result.AddRange(DataUtil.ProgramaLista);
            return result;
        }

        public void AdicionaCustomizado(ProgramaModel programa)
        {
            programa.Custom = true;
            DataUtil.ProgramaLista.Add(programa);
        }

        public void DeletaCustomizado(Guid id)
        {
            var programa = DataUtil.ProgramaLista.FirstOrDefault(p=>p.Id == id);
            DataUtil.ProgramaLista.Remove(programa);
        }

        #endregion
    }
}