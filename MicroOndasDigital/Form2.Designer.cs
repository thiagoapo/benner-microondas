namespace MicroOndasDigital
{
    partial class FormEstender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numTempoSeg = new System.Windows.Forms.NumericUpDown();
            this.numTempoMin = new System.Windows.Forms.NumericUpDown();
            this.numPotencia = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoSeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(16, 79);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(276, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.Location = new System.Drawing.Point(16, 235);
            this.txtPontuacao.MaxLength = 1;
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.Size = new System.Drawing.Size(32, 20);
            this.txtPontuacao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pontuação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "min : seg";
            // 
            // numTempoSeg
            // 
            this.numTempoSeg.Location = new System.Drawing.Point(83, 118);
            this.numTempoSeg.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTempoSeg.Name = "numTempoSeg";
            this.numTempoSeg.Size = new System.Drawing.Size(45, 20);
            this.numTempoSeg.TabIndex = 15;
            // 
            // numTempoMin
            // 
            this.numTempoMin.Location = new System.Drawing.Point(16, 118);
            this.numTempoMin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTempoMin.Name = "numTempoMin";
            this.numTempoMin.Size = new System.Drawing.Size(45, 20);
            this.numTempoMin.TabIndex = 14;
            // 
            // numPotencia
            // 
            this.numPotencia.Location = new System.Drawing.Point(15, 157);
            this.numPotencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPotencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPotencia.Name = "numPotencia";
            this.numPotencia.Size = new System.Drawing.Size(113, 20);
            this.numPotencia.TabIndex = 13;
            this.numPotencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Potência";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tempo de Cozimento";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(217, 272);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Estender";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(137, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(16, 196);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(276, 20);
            this.txtTags.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tags de compatibilidade (separar por vírgulas)";
            // 
            // FormEstender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 305);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTempoSeg);
            this.Controls.Add(this.numTempoMin);
            this.Controls.Add(this.numPotencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPontuacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FormEstender";
            this.Text = "Estender Programa";
            ((System.ComponentModel.ISupportInitialize)(this.numTempoSeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPontuacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTempoSeg;
        private System.Windows.Forms.NumericUpDown numTempoMin;
        private System.Windows.Forms.NumericUpDown numPotencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label8;
    }
}