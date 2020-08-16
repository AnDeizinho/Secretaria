using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretaria
{

    public partial class Base_frm : Form
    {
        BaseSelectBimestre bimestre = new BaseSelectBimestre();
        DataTable tblTurma = new DataTable();
        int contador = 1;
        BindingSource binding = new BindingSource();
        public Base_frm()
        {
            
            InitializeComponent();
            cbTurma.SelectedIndex = 0;
            cbBimestre.SelectedIndex = 0;
            cbTurno.SelectedIndex = 0;
            bimestre.select2(tblTurma, string.Format("select id_turma, descricao from tbl_turma a join tblano b on a.id_ano = b.id_ano where b.id_nivel = 2 and a.ano = {0}",txtAno.Text));
            for (int i = 0 ; i < tblTurma.Rows.Count; i++)
            {
                cbTurma.Items.Add(tblTurma.Rows[i][1].ToString());
            }
            
            
        }/*
        private void exibe(Form janela)
        {
            
            janela.TopLevel = false;
            janela.Dock = DockStyle.Fill;

            this.PNgrid.Controls.Add(janela);
            this.PNgrid.Tag = janela;
            janela.Show();
        }*/
        private void indicador( int idexe)
        {
            if (idexe < 0)
                return;

             lblIndex.Text = "Linha de Impressão = " + idexe;


             if (idexe > 1)
                 dt.Rows[idexe - 2].Selected = false;
             else if (idexe == 0)
                 dt.Rows[idexe].Selected = false;
             else
                 dt.Rows[idexe - 1].Selected = true;
             
        }
        private void Base_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDAtaFinalDataSet.tbl_Bimestre' table. You can move, or remove it, as needed.
            //this.tbl_BimestreTableAdapter.Fill(this.bDAtaFinalDataSet.tbl_Bimestre);
            DataTable tbl = new DataTable();
            
            bimestre.SelectSemFiltro(tbl, int.Parse(txtAno.Text));
            binding.DataSource = tbl;

            dt.DataSource = binding;
            lbl.Text = "Quantidade : " + dt.Rows.Count;
            indicador( contador);
            
            

        }
        private void REC_filtro(int cb_bi, int cb_turm, int cb_turn)
        {
            /* bi - ano - turn
             * bi - ano - 0
             * bi - 0 - turn
             
            
             * */
            if (cb_bi > 0)
            {
                
                //filtra somente o bi
            }

            if (cb_turm > 0)
            {
                // filtra somente a turma
            }
            if(cb_turn > 0)
            {
                // filtra somente o ano
            }
        }
        private void filtro()
        {
            if (cbBimestre.SelectedIndex == 0)
            {
                cbBimestre.Focus();
                return;
            }
            if (cbTurma.SelectedIndex == 0)
            {
                cbTurma.Focus();
                return;
            }
            
            DataTable tbl = new DataTable();
            bimestre.SelectCompletoBimestre(tbl, cbBimestre.SelectedIndex, Convert.ToInt32(tblTurma.Rows[cbTurma.SelectedIndex - 1][0].ToString()) );
            //binding.Filter = "bimestre = " + cbBimestre.Selectedndex + "and id_ano =  + Convert.ToInt32(tblTurma.Rows[cbTura.SelectedIndex - 1][0].ToString()) + " and turno ='" + cbTurno.Text + "'";
            binding.DataSource = tbl;
            lbl.Text = "Quantidade : " + dt.Rows.Count;
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                filtro();
                if (dt.Rows.Count > 0)
                {
                    contador = 1;
                    indicador(contador);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            while (contador - 1 < dt.Rows.Count)
            {
                this.Cursor = Cursors.WaitCursor;


                Boletins bol = new Boletins(Convert.ToInt32(dt.Rows[contador -1].Cells["CodAluno"].Value.ToString()), int.Parse(txtAno.Text));

                bol.ShowDialog();

                this.Cursor = Cursors.Default;
                if (bol.continuar() == false)
                {
                    contador++;
                    if (contador - 1 == dt.Rows.Count)
                    {
                        indicador(contador = 1);
                        
                    }
                    else
                    {
                        indicador(contador);
                    }
                    return;
                }
                
                contador++;
                if (contador - 1 == dt.Rows.Count)
                {
                    indicador(contador = 1);
                    return;

                }
                else
                {
                    indicador(contador);
                }
                

            }
        }

        private void dt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.ToString() != "")
            {
                if (this.dt.Columns[e.ColumnIndex].Name == "m1")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                if (this.dt.Columns[e.ColumnIndex].Name == "m2")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                if (this.dt.Columns[e.ColumnIndex].Name == "m3")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                if (this.dt.Columns[e.ColumnIndex].Name == "m4")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                if (this.dt.Columns[e.ColumnIndex].Name == "m5")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                if (this.dt.Columns[e.ColumnIndex].Name == "m6")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                if (this.dt.Columns[e.ColumnIndex].Name == "m7")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                if (this.dt.Columns[e.ColumnIndex].Name == "m8")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                if (this.dt.Columns[e.ColumnIndex].Name == "m9")
                {
                    if (Convert.ToDouble(e.Value.ToString()) < 6)
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(192, 192, 255);
                        e.CellStyle.ForeColor = Color.DarkBlue;
                    }
                }
                

            }
            else
            {
                e.CellStyle.BackColor = Color.LightCoral;
                e.CellStyle.ForeColor = Color.Red;
            }

        }

        private void txtAluno_TextChanged(object sender, EventArgs e)
        {
            
                try
                {
                    //DataTable tbl = new DataTable();
                    //bimestre.FiltroPorNome(txtAluno.Text, txtAno.Text, tbl);
                    binding.Filter = "nome like '*" + txtAluno.Text +"*'";
                }
                catch
                {
                    MessageBox.Show("deu ruim");
                }
                if (dt.Rows.Count > 0)
                {
                    contador = 1;
                    indicador(contador);
                }
            
            
        }

        private void dt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            indicador(contador = e.RowIndex + 1);
        }
    }
}
