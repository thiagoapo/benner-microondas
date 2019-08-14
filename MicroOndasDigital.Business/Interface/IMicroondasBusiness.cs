using MicroOndasDigital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Business.Interface
{
    public interface IMicroondasBusiness
    {
        bool Valida(MicroondasModel microondas, bool simples = false);
        void Inicia(MicroondasModel microondas);
        void Cancela();
        void Pausa();
        string BuscaResultado();
        void SetaResultado(string result);
        void SetaMicroondas(MicroondasModel microondas);

        #region Events

        event EventHandler ConcluidoEvent;
        event EventHandler ErroEvent;
   
        #endregion
    }
}
