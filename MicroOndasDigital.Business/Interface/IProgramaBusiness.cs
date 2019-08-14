using MicroOndasDigital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Business.Interface
{
    public interface IProgramaBusiness
    {
        void Valida(MicroondasModel microondas);
        void ValidaCustomizado(ProgramaModel programa);
        void ValidaCompativel(MicroondasModel microondas, ProgramaModel programa);
        List<ProgramaModel> BuscaCompativel(MicroondasModel microondas);
        List<ProgramaModel> BuscaTodos();
        void AdicionaCustomizado(ProgramaModel programa);
        void DeletaCustomizado(ProgramaModel programa);
    }
}
