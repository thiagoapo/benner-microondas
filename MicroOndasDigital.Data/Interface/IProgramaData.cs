using MicroOndasDigital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Data.Interface
{
    public interface IProgramaData
    {
        List<ProgramaModel> BuscaTodos();
        void AdicionaCustomizado(ProgramaModel programa);
        void DeletaCustomizado(Guid id);
    }
}
