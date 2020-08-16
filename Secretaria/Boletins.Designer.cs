namespace Secretaria
{
    partial class Boletins
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_BimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDAtaFinalDataSet = new Secretaria.BDAtaFinalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnParar = new System.Windows.Forms.Button();
            this.tbl_BimestreTableAdapter = new Secretaria.BDAtaFinalDataSetTableAdapters.tbl_BimestreTableAdapter();
            this.pan = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtaFinalDataSet)).BeginInit();
            this.pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_BimestreBindingSource
            // 
            this.tbl_BimestreBindingSource.DataMember = "tbl_Bimestre";
            this.tbl_BimestreBindingSource.DataSource = this.BDAtaFinalDataSet;
            // 
            // BDAtaFinalDataSet
            // 
            this.BDAtaFinalDataSet.DataSetName = "BDAtaFinalDataSet";
            this.BDAtaFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.Navy;
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_BimestreBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Secretaria.RelatorioBoletins.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(883, 667);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnParar
            // 
            this.btnParar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.Color.Maroon;
            this.btnParar.Location = new System.Drawing.Point(604, 3);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(118, 28);
            this.btnParar.TabIndex = 1;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_BimestreTableAdapter
            // 
            this.tbl_BimestreTableAdapter.ClearBeforeFill = true;
            // 
            // pan
            // 
            this.pan.BackColor = System.Drawing.Color.Navy;
            this.pan.Controls.Add(this.button2);
            this.pan.Controls.Add(this.button1);
            this.pan.Controls.Add(this.btnFechar);
            this.pan.Controls.Add(this.btnParar);
            this.pan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan.Location = new System.Drawing.Point(0, 0);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(884, 35);
            this.pan.TabIndex = 2;
//            this.pan.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(728, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "__";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(781, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "M";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFechar.Location = new System.Drawing.Point(834, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 28);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Boletins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 701);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Boletins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boletins";
            this.Load += new System.EventHandler(this.Boletins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_BimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtaFinalDataSet)).EndInit();
            this.pan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.BindingSource tbl_BimestreBindingSource;
        private BDAtaFinalDataSet BDAtaFinalDataSet;
        private BDAtaFinalDataSetTableAdapters.tbl_BimestreTableAdapter tbl_BimestreTableAdapter;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFechar;
        
       
    }
}