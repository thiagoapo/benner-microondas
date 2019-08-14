using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Entities
{
    public class BaseModel
    {
        public decimal TempoMin { get; set; }
        public decimal TempoSeg { get; set; }
        public decimal Potencia { get; set; }

        public string Pontuacao { get; set; }

        #region Read-Only Properties

        public int TempoMinInteger { get { return Decimal.ToInt32(this.TempoMin); } }
        public int TempoSegInteger { get { return Decimal.ToInt32(this.TempoSeg); } }
        public int PotenciaInteger { get { return Decimal.ToInt32(this.Potencia); } }

        public TimeSpan Tempo { get { return new TimeSpan(0, this.TempoMinInteger, this.TempoSegInteger); } }

        #endregion

    }
}
