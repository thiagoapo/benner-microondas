using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Business.Utils
{
    public static class ValidaUtil
    {
        public static bool ValidaInt(decimal valor)
        {
            var resultado = valor % 1;
            return resultado.Equals(0);
        }
    }
}
