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
    public partial class frmAlunos : Form
    {
        BaseSelectBimestre bim = new BaseSelectBimestre();
        
        SqlConnection conexao = new SqlConnection();
        SqlDataAdapter atp;
        DataTable tbl;
        BindingSource binding = new BindingSource();
        DataTable tblTurma = new DataTable();
        string str = @"SELECT [id_aluno]
	  ,tbl_alunos.id_cliente 
      ,[nome]
      ,[id_mac]
      ,tbl_turma.descricao
      ,tbl_cliente.fone_pai
      ,tbl_cliente.fone_mae
      ,[nascimento]
      ,[sexo]
      ,[naturalidade]
      ,[uf]
      ,[dadosClinicos]
      ,[remedios]
      ,[ano_recente]
      ,[integral]
  FROM [tbl_Alunos] 
  
  join tbl_turma 
  on tbl_alunos.id_turma = tbl_turma.id_turma
  
  join tblano on tbl_turma.id_ano = tblano.id_ano

  join BDAtaFinal.dbo.tbl_cliente 
  on tbl_Alunos.id_cliente = tbl_cliente.id_cliente 
  ";
        
        public frmAlunos()
        {
            conexao.ConnectionString = bim.conexao();
            InitializeComponent();
            
            dt.Columns[0].Width = 35;
            dt.Columns[1].Width = 35;
            dt.Columns[2].Width = 250;
            dt.Columns[3].Width = 100;
            dt.Columns[4].Width = 110;
            dt.Columns[5].Width = 100;
            dt.Columns[6].Width = 100;
            dt.Columns[7].Width = 70;
            dt.Columns[8].Width = 50;
            dt.Columns[10].Width = 35;
            dt.Columns[13].Width = 50;

            cb.Items.Add("Turma");
            cb.SelectedIndex = 0;


            atp = new SqlDataAdapter(string.Format("select id_turma, descricao from tbl_Turma where ano = {0}",txtano.Text),conexao);
            atp.Fill(tblTurma);
            foreach (DataRow lin in tblTurma.Rows)
            {
                cb.Items.Add(lin[1].ToString());
            }

            preencheTabela();
        }
        private void preencheTabela()
        {
            string str2 = string.Format("where tbl_turma.ano = {0} and tblano.id_nivel = 2 ",txtano.Text) +  " order by tbl_turma.descricao , nome";
            SqlCommand comando = new SqlCommand(str + str2, conexao);
            atp = new SqlDataAdapter(comando);
            atp.Fill(tbl = new DataTable());
            binding.DataSource = tbl;
            dt.DataSource = binding;
            lbl.Text = "Quantidade : " + dt.Rows.Count;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void textBox1_Validating(object sender, KeyEventArgs e)
        {
            /*
            
            if (txtnome.Text != "" & e.KeyValue == 13)
            {
                string str3 = "where ano_recente = '" + txtano.Text + "' and nome like '%" + txtnome.Text + "%' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str3, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }

            else if (txtnome.Text == "" & e.KeyValue == 13)
            {
                string str2 = "where ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str2, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }*/
        }

        private void txtnome_Validating(object sender, CancelEventArgs e)
        {
            /*if (txtnome.Text != "" )
            {
                string str3 = "where ano_recente = '" + txtano.Text + "' and nome like '%" + txtnome.Text + "%' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str3, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }

            else if (txtnome.Text == "" )
            {
                string str2 = "where ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str2, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }*/
        }

        private void cb_Validated(object sender, EventArgs e)
        {
            /*if (cb.SelectedIndex > 0)
            {
                string str2 = "where tbl_Alunos.id_turma = " + tblTurma.Rows[cb.SelectedIndex - 1][0].ToString() + " and ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str2, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
            }*/
        }

        private void cb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb.SelectedIndex > 0)
            {
                string str2 = "where tbl_Alunos.id_turma = " + tblTurma.Rows[cb.SelectedIndex - 1][0].ToString() + "order by tbl_turma.descricao , nome";
                SqlCommand comando = new SqlCommand(str + str2, conexao);
                atp = new SqlDataAdapter(comando);
                atp.Fill(tbl = new DataTable());
                dt.DataSource = tbl;
                lbl.Text = "Quantidade : " + dt.Rows.Count;
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            if (txtnome.Text != "")
            {
                binding.Filter = "ano_recente = '" + txtano.Text + "' and nome like '*" + txtnome.Text + "*'";
                binding.Sort = "descricao asc, nome asc";
                ////SqlCommand comando = new SqlCommand(str + str3, conexao);
                //atp = new SqlDataAdapter(comando);
                //atp.Fill(tbl = new DataTable());
               // dt.DataSource = tbl;
            }

            else if (txtnome.Text == "")
            {
                binding.RemoveFilter();
                //string str2 = "where ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                //SqlCommand comando = new SqlCommand(str + str2, conexao);
                //atp = new SqlDataAdapter(comando);
                //atp.Fill(tbl = new DataTable());
                //dt.DataSource = tbl;
            }
            lbl.Text = "Quantidade : " + dt.Rows.Count;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCC_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {
            if (txtCC.Text != "")
            {
                binding.Filter=  "ano_recente = '" + txtano.Text + "' and id_cliente = " + txtCC.Text ;
                binding.Sort = "descricao asc, nome asc";
                //SqlCommand comando = new SqlCommand(str + str3, conexao);
                //atp = new SqlDataAdapter(comando);
                
                //atp.Fill(tbl = new DataTable());
                //dt.DataSource = tbl;
            }
            else
            {
                binding.RemoveFilter();
                //string str2 = "where ano_recente = '" + txtano.Text + "' order by tbl_turma.descricao , nome";
                //SqlCommand comando = new SqlCommand(str + str2, conexao);
                //atp = new SqlDataAdapter(comando);
                //atp.Fill(tbl = new DataTable());
                //dt.DataSource = tbl;
            }
            lbl.Text = "Quantidade : " + dt.Rows.Count;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            cbInter.SelectedIndex = 0;
            int inttxtcodmuda = 0;
            try
            {
                inttxtcodmuda = Convert.ToInt32(txtCodMuda.Text);
            }
            catch
            {
                MessageBox.Show("somente numeros");
                
                txtCC.Focus();
                txtCodMuda.Text = "";
                txtnomeAluno.Text = "";

                cbAno.Items.Clear();
                data.Value = DateTime.Now.Date;
                cbInter.SelectedIndex = 0;
                
                return;
            }
            if (txtCodMuda.Text != "")
            {
                cbAno.Items.Clear();
                DataTable tabela = new DataTable();

                //DataRow []linha = tbl.Select("id_aluno = " + inttxtcodmuda);
                
                
                atp = new SqlDataAdapter(new SqlCommand("select id_ano, descricao, nome , nascimento, integral from Bdatafinal.dbo.tbl_alunos join Bdatafinal.dbo.tbl_turma on tbl_Alunos.id_turma = tbl_turma.id_turma where id_aluno = " + txtCodMuda.Text, conexao));
                
                atp.Fill(tabela);
                int id_Do_Ano = 0;
                if (tbl.Rows.Count > 0)
                {
                    id_Do_Ano = Convert.ToInt32(tabela.Rows[0]["id_ano"].ToString());
                    txtnomeAluno.Text = tabela.Rows[0]["nome"].ToString();
                    data.Value = Convert.ToDateTime(tabela.Rows[0]["nascimento"].ToString()).Date;
                    if (tabela.Rows[0]["integral"].ToString() == null)
                    {
                        cbInter.SelectedIndex = 0;
                    }
                    else if (tabela.Rows[0]["integral"].ToString() == "não")
                    {
                        cbInter.SelectedIndex = 1;
                    }
                    else if (tabela.Rows[0]["integral"].ToString() == "Sim")
                    {
                        cbInter.SelectedIndex = 2;
                    }
                }
                else
                {
                    MessageBox.Show("não encontrado");
                    txtCC.Focus();
                    txtCodMuda.Text = "";
                    txtnomeAluno.Text = "";

                    cbAno.Items.Clear();
                    data.Value = DateTime.Now.Date;
                    cbInter.SelectedIndex = 0;
                    return;
                }

                SqlDataAdapter atapt = new SqlDataAdapter("select id_turma ,descricao from tbl_turma where id_ano = " + id_Do_Ano, conexao);
                DataTable tbl2 = new DataTable();
                atapt.Fill(tbl2);
                foreach (DataRow i in tbl2.Rows)
                {
                    cbAno.Items.Add(i[1].ToString());
                }
                cbAno.SelectedIndex = 0;
                if (tbl.Rows[0][1].ToString() != cbAno.Text)
                {
                    cbAno.SelectedIndex = 1;
                }
            }
            else
            {
                txtCC.Focus();
                txtCodMuda.Text = "";
                txtnomeAluno.Text = "";

                cbAno.Items.Clear();
                data.Value = DateTime.Now.Date;
                cbInter.SelectedIndex = 0;
            }

        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int id_turma = 0;
            if (txtCodMuda.Text == "")
            {
                txtCodMuda.Focus();
                return;
            }
            if (txtnomeAluno.Text == "")
            {
                txtnomeAluno.Focus();
                return;
            }
            if (cbAno.Text == "")
            {
                cbAno.Focus();
                return;
            }
            if (data.Value == DateTime.Now.Date)
            {
                data.Focus();
                return;
            }
            if (cbInter.SelectedIndex == 0)
            {
                cbInter.Focus();
                return;
            }

            if (MessageBox.Show("tem derteza que quer mudar os dados ?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                SqlDataAdapter adaptador = new SqlDataAdapter("select id_turma from tbl_turma where descricao = '" + cbAno.Text + "'", conexao);
                DataTable tbl2 = new DataTable();
                adaptador.Fill(tbl2);
                id_turma = Convert.ToInt32(tbl2.Rows[0][0].ToString());

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                conexao.Open();
                comando.Parameters.AddWithValue("@nome", txtnomeAluno.Text);
                comando.Parameters.AddWithValue("@nascimento", data.Value.Date);
                comando.Parameters.AddWithValue("@id_turma", id_turma);
                comando.Parameters.AddWithValue("@inter", cbInter.Text);
                comando.CommandText = "update tbl_alunos set nome = @nome, nascimento = @nascimento, id_turma = @id_turma, integral = @inter where id_aluno = " + txtCodMuda.Text;
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("modificado Com Sucesso");
                Form1_Load(null, null);
                txtCC.Focus();
                txtCodMuda.Text = "";
                txtnomeAluno.Text = "";

                cbAno.Items.Clear();
                data.Value = DateTime.Now.Date;
                cbInter.SelectedIndex = 0;
                preencheTabela();

            }
            else
            {
                txtCC.Focus();
                txtCodMuda.Text = "";
                txtnomeAluno.Text = "";

                cbAno.Items.Clear();
                data.Value = DateTime.Now.Date;
                cbInter.SelectedIndex = 0;
            }
        }

        

        
        
        
    }
}
