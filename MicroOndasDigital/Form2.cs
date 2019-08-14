using MicroOndasDigital.Business;
using MicroOndasDigital.Business.Interface;
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
    public partial class FormEstender : Form
    {
        #region Private Attributes

        private readonly IProgramaBusiness _business;
        private ProgramaModel _programa;

        #endregion

        #region Public Attributes

        public event EventHandler EstenderEvent;

        #endregion

        #region Constructor

        public FormEstender(ProgramaModel programa)
        {
            InitializeComponent();
            this._business = new ProgramaBusiness();
            this._programa = (ProgramaModel)programa.Clone();
            txtNome.Text = programa.Nome;
            txtDescricao.Text = programa.Descricao;
            numTempoMin.Value = programa.TempoMin;
            numTempoSeg.Value = programa.TempoSeg;
            numPotencia.Value = programa.Potencia;
            txtPontuacao.Text = programa.Pontuacao;
            txtTags.Text = string.Join(", ", programa.TagList);
        }

        #endregion

        #region Private Methods 
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                this._programa.Nome = txtNome.Text;
                this._programa.Descricao = txtDescricao.Text;
                this._programa.TempoMin = Decimal.ToInt32(numTempoMin.Value);
                this._programa.TempoSeg = Decimal.ToInt32(numTempoSeg.Value);
                this._programa.Potencia = Decimal.ToInt32(numPotencia.Value);
                this._programa.Pontuacao = txtPontuacao.Text;
                var tags = txtTags.Text.Split(',');
                tags.ToList().ForEach(tag =>
                {
                    tag = tag.ToLower().Trim();
                });
                tags = tags.Where(p => !string.IsNullOrEmpty(p)).ToArray();
                this._programa.TagList = tags;
                this._business.ValidaCustomizado(this._programa);
                this.EstenderEvent(this._programa, EventArgs.Empty);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        #endregion
    }
}
