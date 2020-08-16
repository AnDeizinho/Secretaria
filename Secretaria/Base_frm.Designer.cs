namespace Secretaria
{
    partial class Base_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBimestre = new System.Windows.Forms.ComboBox();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CodAluno,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.m1,
            this.m2,
            this.m3,
            this.m4,
            this.m5,
            this.m6,
            this.m7,
            this.m8,
            this.m9,
            this.Column18,
            this.Column19,
            this.Column20});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle5;
            this.dt.EnableHeadersVisualStyles = false;
            this.dt.GridColor = System.Drawing.Color.DarkBlue;
            this.dt.Location = new System.Drawing.Point(2, 94);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dt.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.Size = new System.Drawing.Size(974, 414);
            this.dt.TabIndex = 0;
            this.dt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellDoubleClick);
            this.dt.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dt_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "bimestre";
            this.Column1.HeaderText = "Bimestre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CodAluno
            // 
            this.CodAluno.DataPropertyName = "id_Aluno";
            this.CodAluno.HeaderText = "CA";
            this.CodAluno.Name = "CodAluno";
            this.CodAluno.ReadOnly = true;
            this.CodAluno.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nome";
            this.Column4.HeaderText = "Aluno";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id_bimestre";
            this.Column3.HeaderText = "cod";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ano";
            this.Column5.HeaderText = "Série";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "turno";
            this.Column6.HeaderText = "Turno";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "professor";
            this.Column7.HeaderText = "Professor(ª)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ano1";
            this.Column8.HeaderText = "Ano";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // m1
            // 
            this.m1.DataPropertyName = "port";
            this.m1.HeaderText = "Português";
            this.m1.Name = "m1";
            this.m1.ReadOnly = true;
            this.m1.Width = 70;
            // 
            // m2
            // 
            this.m2.DataPropertyName = "mat";
            this.m2.HeaderText = "Matemática";
            this.m2.Name = "m2";
            this.m2.ReadOnly = true;
            this.m2.Width = 70;
            // 
            // m3
            // 
            this.m3.DataPropertyName = "hist";
            this.m3.HeaderText = "História";
            this.m3.Name = "m3";
            this.m3.ReadOnly = true;
            this.m3.Width = 70;
            // 
            // m4
            // 
            this.m4.DataPropertyName = "geog";
            this.m4.HeaderText = "Geografia";
            this.m4.Name = "m4";
            this.m4.ReadOnly = true;
            this.m4.Width = 70;
            // 
            // m5
            // 
            this.m5.DataPropertyName = "ciencia";
            this.m5.HeaderText = "Ciências";
            this.m5.Name = "m5";
            this.m5.ReadOnly = true;
            this.m5.Width = 70;
            // 
            // m6
            // 
            this.m6.DataPropertyName = "arte";
            this.m6.HeaderText = "Artes";
            this.m6.Name = "m6";
            this.m6.ReadOnly = true;
            this.m6.Width = 70;
            // 
            // m7
            // 
            this.m7.DataPropertyName = "religiao";
            this.m7.HeaderText = "Religião";
            this.m7.Name = "m7";
            this.m7.ReadOnly = true;
            this.m7.Width = 70;
            // 
            // m8
            // 
            this.m8.DataPropertyName = "ingles";
            this.m8.HeaderText = "Inglês";
            this.m8.Name = "m8";
            this.m8.ReadOnly = true;
            this.m8.Width = 70;
            // 
            // m9
            // 
            this.m9.DataPropertyName = "fisica";
            this.m9.HeaderText = "Física";
            this.m9.Name = "m9";
            this.m9.ReadOnly = true;
            this.m9.Width = 70;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "ap";
            this.Column18.HeaderText = "Aprovado";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 70;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "r";
            this.Column19.HeaderText = "Reprovado";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 70;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "faltas";
            this.Column20.HeaderText = "Faltas";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 70;
            // 
            // cbBimestre
            // 
            this.cbBimestre.BackColor = System.Drawing.Color.DarkBlue;
            this.cbBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBimestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBimestre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbBimestre.FormattingEnabled = true;
            this.cbBimestre.Items.AddRange(new object[] {
            "<Bimestre>",
            "1° Bimestre",
            "2° Bimestre",
            "3° Bimestre",
            "4° Bimestre"});
            this.cbBimestre.Location = new System.Drawing.Point(12, 12);
            this.cbBimestre.Name = "cbBimestre";
            this.cbBimestre.Size = new System.Drawing.Size(191, 28);
            this.cbBimestre.TabIndex = 1;
            // 
            // cbTurma
            // 
            this.cbTurma.BackColor = System.Drawing.Color.DarkBlue;
            this.cbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Items.AddRange(new object[] {
            "<Turma>"});
            this.cbTurma.Location = new System.Drawing.Point(221, 12);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(191, 28);
            this.cbTurma.TabIndex = 2;
            // 
            // cbTurno
            // 
            this.cbTurno.BackColor = System.Drawing.Color.DarkBlue;
            this.cbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurno.Enabled = false;
            this.cbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "<Turno>",
            "Matutino",
            "Vespertino"});
            this.cbTurno.Location = new System.Drawing.Point(428, 12);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(191, 28);
            this.cbTurno.TabIndex = 3;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnFiltrar.Location = new System.Drawing.Point(625, 12);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(96, 28);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl.Location = new System.Drawing.Point(727, 16);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(117, 20);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Quantidade : ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(843, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAluno
            // 
            this.txtAluno.BackColor = System.Drawing.Color.Navy;
            this.txtAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAluno.Location = new System.Drawing.Point(12, 53);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(465, 26);
            this.txtAluno.TabIndex = 7;
            this.txtAluno.TextChanged += new System.EventHandler(this.txtAluno_TextChanged);
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.Navy;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAno.Location = new System.Drawing.Point(483, 53);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 26);
            this.txtAno.TabIndex = 8;
            this.txtAno.Text = "2020";
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblIndex.Location = new System.Drawing.Point(589, 56);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(185, 20);
            this.lblIndex.TabIndex = 9;
            this.lblIndex.Text = "Linha de impressão = ";
            // 
            // Base_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(977, 511);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.cbTurma);
            this.Controls.Add(this.cbBimestre);
            this.Controls.Add(this.dt);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Base_frm";
            this.Text = "Base_frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Base_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.ComboBox cbBimestre;
        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6;
        private System.Windows.Forms.DataGridViewTextBoxColumn m7;
        private System.Windows.Forms.DataGridViewTextBoxColumn m8;
        private System.Windows.Forms.DataGridViewTextBoxColumn m9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblIndex;


    }
}