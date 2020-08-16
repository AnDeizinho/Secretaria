using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Secretaria
{
    public partial class Boletins : Form
    {
        int id_aluno = 0;
        DataTable tbl = new DataTable();
        BaseSelectBimestre bimestre = new BaseSelectBimestre();
        bool cont = true;
       
        public Boletins(int idaluno, int _ano)
        {

            id_aluno = idaluno;
            bimestre.SelectPeloId(tbl, id_aluno, _ano);
            InitializeComponent();
            

        }
        private string calcula_Atualiza( double b1, double b2, double b3, double b4 , string materia, int id)
        {
            double totalNotas = (b1 + b2 + b3 + b4) / 4;
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection(bimestre.conexao());
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE [BDAtaFinal].[dbo].[tbl_Notas]" +
                                    " SET " +

                                    "[" + materia + "] = @nota " +

                                    
                                    "WHERE id_aluno = @id";
                cmd.Parameters.AddWithValue("@nota", totalNotas);
                
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("deu ruim\n" + erro.ToString());
            }
            //NO 4 BIMESTRE USE ESTA LINHA 
            //return totalNotas.ToString("N");
            return "0";
        }
        private string calcula_Falta(int f1, int f2, int f3, int f4,  int id)
        {
            int totalFaltas = f1 + f2 + f3 + f4;
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection(bimestre.conexao());
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE [BDAtaFinal].[dbo].[tbl_Notas]" +
                                    " SET " +

                                    "faltas = @falta " +


                                    "WHERE id_aluno = @id";
                cmd.Parameters.AddWithValue("@falta", totalFaltas);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("deu ruim\n" + erro.ToString());
            }

            return "" + totalFaltas;
        }
        public bool continuar()
        {
            return cont;
        }
        private string  verificaSeEzero(string valorstr)
        {
            double valor = Convert.ToDouble(valorstr);
            if (valor == 0)
            {
                return "";
            }
            else
            {
                return  valorstr;
            }
            
        }
        private void Boletins_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("aluno", tbl.Rows[0][3].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("serie", tbl.Rows[0][4].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("turno", tbl.Rows[0][5].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("profe", tbl.Rows[0][6].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ano", tbl.Rows[0][7].ToString()));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("port1", verificaSeEzero( tbl.Rows[0][8].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("port2", verificaSeEzero(tbl.Rows[1][8].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("port3", verificaSeEzero(tbl.Rows[2][8].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("port4", verificaSeEzero(tbl.Rows[3][8].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mport", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][8].ToString()),Convert.ToDouble(tbl.Rows[1][8].ToString()),Convert.ToDouble(tbl.Rows[2][8].ToString()),Convert.ToDouble(tbl.Rows[3][8].ToString()),"port", id_aluno))));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fal1", verificaSeEzero(tbl.Rows[0][19].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fal2", verificaSeEzero(tbl.Rows[1][19].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fal3", verificaSeEzero(tbl.Rows[2][19].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fal4", verificaSeEzero(tbl.Rows[3][19].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("totfal", verificaSeEzero(calcula_Falta(Convert.ToInt32(tbl.Rows[0][19].ToString()), Convert.ToInt32(tbl.Rows[1][19].ToString()), Convert.ToInt32(tbl.Rows[2][19].ToString()), Convert.ToInt32(tbl.Rows[3][19].ToString()), id_aluno))/*final*/));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mat1", verificaSeEzero(tbl.Rows[0][9].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mat2", verificaSeEzero(tbl.Rows[1][9].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mat3", verificaSeEzero(tbl.Rows[2][9].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mat4", verificaSeEzero(tbl.Rows[3][9].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mmat", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][9].ToString()), Convert.ToDouble(tbl.Rows[1][9].ToString()), Convert.ToDouble(tbl.Rows[2][9].ToString()), Convert.ToDouble(tbl.Rows[3][9].ToString()), "mat", id_aluno))));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("his1", verificaSeEzero(tbl.Rows[0][10].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("his2", verificaSeEzero(tbl.Rows[1][10].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("his3", verificaSeEzero(tbl.Rows[2][10].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("his4", verificaSeEzero(tbl.Rows[3][10].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mhis", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][10].ToString()), Convert.ToDouble(tbl.Rows[1][10].ToString()), Convert.ToDouble(tbl.Rows[2][10].ToString()), Convert.ToDouble(tbl.Rows[3][10].ToString()), "hist", id_aluno))));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("geo1", verificaSeEzero(tbl.Rows[0][11].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("geo2", verificaSeEzero(tbl.Rows[1][11].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("geo3", verificaSeEzero(tbl.Rows[2][11].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("geo4", verificaSeEzero(tbl.Rows[3][11].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mgeo", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][11].ToString()), Convert.ToDouble(tbl.Rows[1][11].ToString()), Convert.ToDouble(tbl.Rows[2][11].ToString()), Convert.ToDouble(tbl.Rows[3][11].ToString()), "geog", id_aluno))));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cie1", verificaSeEzero(tbl.Rows[0][12].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cie2", verificaSeEzero(tbl.Rows[1][12].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cie3", verificaSeEzero(tbl.Rows[2][12].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cie4", verificaSeEzero(tbl.Rows[3][12].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mcie", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][12].ToString()), Convert.ToDouble(tbl.Rows[1][12].ToString()), Convert.ToDouble(tbl.Rows[2][12].ToString()), Convert.ToDouble(tbl.Rows[3][12].ToString()), "ciencia", id_aluno))));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("art1", verificaSeEzero(tbl.Rows[0][13].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("art2", verificaSeEzero(tbl.Rows[1][13].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("art3", verificaSeEzero(tbl.Rows[2][13].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("art4", verificaSeEzero(tbl.Rows[3][13].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mart", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][13].ToString()), Convert.ToDouble(tbl.Rows[1][13].ToString()), Convert.ToDouble(tbl.Rows[2][13].ToString()), Convert.ToDouble(tbl.Rows[3][13].ToString()), "arte", id_aluno))));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rel1", verificaSeEzero(tbl.Rows[0][14].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rel2", verificaSeEzero(tbl.Rows[1][14].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rel3", verificaSeEzero(tbl.Rows[2][14].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rel4", verificaSeEzero(tbl.Rows[3][14].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mrel", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][14].ToString()), Convert.ToDouble(tbl.Rows[1][14].ToString()), Convert.ToDouble(tbl.Rows[2][14].ToString()), Convert.ToDouble(tbl.Rows[3][14].ToString()), "religiao", id_aluno))));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ing1", verificaSeEzero(tbl.Rows[0][15].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ing2", verificaSeEzero(tbl.Rows[1][15].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ing3", verificaSeEzero(tbl.Rows[2][15].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ing4", verificaSeEzero(tbl.Rows[3][15].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ming", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][15].ToString()), Convert.ToDouble(tbl.Rows[1][15].ToString()), Convert.ToDouble(tbl.Rows[2][15].ToString()), Convert.ToDouble(tbl.Rows[3][15].ToString()), "ingles", id_aluno))));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fis1", verificaSeEzero(tbl.Rows[0][16].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fis2", verificaSeEzero(tbl.Rows[1][16].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fis3", verificaSeEzero(tbl.Rows[2][16].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fis4", verificaSeEzero(tbl.Rows[3][16].ToString())));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mfis", verificaSeEzero(calcula_Atualiza(Convert.ToDouble(tbl.Rows[0][16].ToString()), Convert.ToDouble(tbl.Rows[1][16].ToString()), Convert.ToDouble(tbl.Rows[2][16].ToString()), Convert.ToDouble(tbl.Rows[3][16].ToString()), "fisica", id_aluno))));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont = false;
            btnParar.BackColor = Color.AliceBlue;
            btnParar.ForeColor = Color.DarkBlue;
            btnParar.Text = "Parado";
            btnParar.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
