using MicroOndasDigital.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Entities
{
    public class MicroondasModel : BaseModel
    {
        #region Constructor

        public MicroondasModel()
        {
            this.Pontuacao = ".";
            this.Status = MicroondasStatusEnum.Cancelado;
        }

        #endregion

        public MicroondasStatusEnum Status { get; set; }

        public string Bandeja { get; set; }

        #region Read-Only Properties

        public bool Arquivo { get { return this.Bandeja.Contains(":\\"); } }

        #endregion
    }
}
