namespace MicroOndasDigital
{
    partial class FormMicroOndasDigital
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBandeja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPotencia = new System.Windows.Forms.NumericUpDown();
            this.numTempoMin = new System.Windows.Forms.NumericUpDown();
            this.numTempoSeg = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnInicioRapido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCustomDel = new System.Windows.Forms.Button();
            this.btnCustomAdd = new System.Windows.Forms.Button();
            this.dgProgramas = new System.Windows.Forms.DataGridView();
            this.programaBusinessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIniciarPrograma = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnFiltrarCompativeis = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPausar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoSeg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBusinessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bandeja";
            // 
            // txtBandeja
            // 
            this.txtBandeja.Location = new System.Drawing.Point(16, 30);
            this.txtBandeja.Name = "txtBandeja";
            this.txtBandeja.Size = new System.Drawing.Size(234, 20);
            this.txtBandeja.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo de Cozimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Potência";
            // 
            // numPotencia
            // 
            this.numPotencia.Location = new System.Drawing.Point(15, 136);
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
            this.numPotencia.Size = new System.Drawing.Size(120, 20);
            this.numPotencia.TabIndex = 6;
            this.numPotencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numTempoMin
            // 
            this.numTempoMin.Location = new System.Drawing.Point(16, 87);
            this.numTempoMin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTempoMin.Name = "numTempoMin";
            this.numTempoMin.Size = new System.Drawing.Size(45, 20);
            this.numTempoMin.TabIndex = 7;
            // 
            // numTempoSeg
            // 
            this.numTempoSeg.Location = new System.Drawing.Point(83, 87);
            this.numTempoSeg.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numTempoSeg.Name = "numTempoSeg";
            this.numTempoSeg.Size = new System.Drawing.Size(45, 20);
            this.numTempoSeg.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "min : seg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(16, 177);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(178, 148);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(120, 23);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnInicioRapido
            // 
            this.btnInicioRapido.Location = new System.Drawing.Point(178, 177);
            this.btnInicioRapido.Name = "btnInicioRapido";
            this.btnInicioRapido.Size = new System.Drawing.Size(120, 23);
            this.btnInicioRapido.TabIndex = 15;
            this.btnInicioRapido.Text = "Início Rápido (30s)";
            this.btnInicioRapido.UseVisualStyleBackColor = true;
            this.btnInicioRapido.Click += new System.EventHandler(this.BtnInicioRapido_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Location = new System.Drawing.Point(304, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(6, 19);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(459, 163);
            this.txtResult.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnCustomDel);
            this.groupBox2.Controls.Add(this.btnCustomAdd);
            this.groupBox2.Controls.Add(this.dgProgramas);
            this.groupBox2.Controls.Add(this.btnIniciarPrograma);
            this.groupBox2.Controls.Add(this.btnVerTodos);
            this.groupBox2.Controls.Add(this.btnFiltrarCompativeis);
            this.groupBox2.Location = new System.Drawing.Point(16, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 219);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Programas customizados";
            // 
            // btnCustomDel
            // 
            this.btnCustomDel.Location = new System.Drawing.Point(268, 29);
            this.btnCustomDel.Name = "btnCustomDel";
            this.btnCustomDel.Size = new System.Drawing.Size(57, 23);
            this.btnCustomDel.TabIndex = 22;
            this.btnCustomDel.Text = "Excluir";
            this.btnCustomDel.UseVisualStyleBackColor = true;
            this.btnCustomDel.Click += new System.EventHandler(this.BtnCustomDel_Click);
            // 
            // btnCustomAdd
            // 
            this.btnCustomAdd.Location = new System.Drawing.Point(204, 29);
            this.btnCustomAdd.Name = "btnCustomAdd";
            this.btnCustomAdd.Size = new System.Drawing.Size(63, 23);
            this.btnCustomAdd.TabIndex = 21;
            this.btnCustomAdd.Text = "Estender";
            this.btnCustomAdd.UseVisualStyleBackColor = true;
            this.btnCustomAdd.Click += new System.EventHandler(this.BtnCustomAdd_Click);
            // 
            // dgProgramas
            // 
            this.dgProgramas.AutoGenerateColumns = false;
            this.dgProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProgramas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Descricao,
            this.Tempo,
            this.Potencia,
            this.Customizado});
            this.dgProgramas.DataSource = this.programaBusinessBindingSource;
            this.dgProgramas.Location = new System.Drawing.Point(6, 59);
            this.dgProgramas.Name = "dgProgramas";
            this.dgProgramas.ReadOnly = true;
            this.dgProgramas.Size = new System.Drawing.Size(747, 154);
            this.dgProgramas.TabIndex = 20;
            // 
            // btnIniciarPrograma
            // 
            this.btnIniciarPrograma.Location = new System.Drawing.Point(644, 29);
            this.btnIniciarPrograma.Name = "btnIniciarPrograma";
            this.btnIniciarPrograma.Size = new System.Drawing.Size(109, 23);
            this.btnIniciarPrograma.TabIndex = 18;
            this.btnIniciarPrograma.Text = "Iniciar Programa";
            this.btnIniciarPrograma.UseVisualStyleBackColor = true;
            this.btnIniciarPrograma.Click += new System.EventHandler(this.BtnIniciarPrograma_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(121, 29);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(68, 23);
            this.btnVerTodos.TabIndex = 19;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // btnFiltrarCompativeis
            // 
            this.btnFiltrarCompativeis.Location = new System.Drawing.Point(6, 29);
            this.btnFiltrarCompativeis.Name = "btnFiltrarCompativeis";
            this.btnFiltrarCompativeis.Size = new System.Drawing.Size(113, 23);
            this.btnFiltrarCompativeis.TabIndex = 18;
            this.btnFiltrarCompativeis.Text = "Filtrar compatíveis";
            this.btnFiltrarCompativeis.UseVisualStyleBackColor = true;
            this.btnFiltrarCompativeis.Click += new System.EventHandler(this.BtnFiltrarCompativeis_Click);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Tempo
            // 
            this.Tempo.DataPropertyName = "Tempo";
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.ReadOnly = true;
            // 
            // Potencia
            // 
            this.Potencia.DataPropertyName = "Potencia";
            this.Potencia.HeaderText = "Potencia";
            this.Potencia.Name = "Potencia";
            this.Potencia.ReadOnly = true;
            // 
            // Customizado
            // 
            this.Customizado.DataPropertyName = "CustomLabel";
            this.Customizado.HeaderText = "Customizado";
            this.Customizado.Name = "Customizado";
            this.Customizado.ReadOnly = true;
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(97, 177);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 18;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // FormMicroOndasDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInicioRapido);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTempoSeg);
            this.Controls.Add(this.numTempoMin);
            this.Controls.Add(this.numPotencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBandeja);
            this.Controls.Add(this.label1);
            this.Name = "FormMicroOndasDigital";
            this.Text = "MicroOndasDigital";
            ((System.ComponentModel.ISupportInitialize)(this.numPotencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoSeg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programaBusinessBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBandeja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPotencia;
        private System.Windows.Forms.NumericUpDown numTempoMin;
        private System.Windows.Forms.NumericUpDown numTempoSeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnInicioRapido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIniciarPrograma;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnFiltrarCompativeis;
        private System.Windows.Forms.DataGridView dgProgramas;
        private System.Windows.Forms.BindingSource programaBusinessBindingSource;
        private System.Windows.Forms.Button btnCustomDel;
        private System.Windows.Forms.Button btnCustomAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customizado;
        private System.Windows.Forms.Button btnPausar;
    }
}

