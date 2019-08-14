using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOndasDigital.Entities
{
    public class ProgramaModel : BaseModel, ICloneable
    {
        #region Constructor

        public ProgramaModel()
        {
            this.Id = Guid.NewGuid();
            this.Custom = false;
        }

        #endregion

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string[] TagList { get; set; }
        public bool Custom { get; set; }

        #region Read-Only Properties

        public string CustomLabel { get { return Custom ? "Sim" : string.Empty; } }
        public string TempoString { get { return $"{this.TempoMin.ToString().PadLeft(2, '0')}:{this.TempoSeg.ToString().PadLeft(2, '0')}"; } }

        #endregion

      
        public object Clone()
        {
            var clone = this.MemberwiseClone();
            this.Id = Guid.NewGuid();
            return clone;
        }
    }
}
