using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Secretaria
{
    

    class BaseSelectBimestre
    {
        public string conexao() { return @"Data Source = PC-SERVIDOR,1433\sqlexpress ; Database = bdatafinal; User Id = sa; Password = yerdna"; } 
        
        
        string strSelect = @"
SELECT TOP 1000 
        [id_Bimestre]
        ,bimestre
      ,tbl_bimestre.[id_aluno]
      ,tbl_Alunos.nome
      ,tblAno.ano
      ,tbl_turno.turno
      ,tbl_professor.professor
      ,tbl_bimestre.[ano] 
      ,[port]
      ,[mat]
      ,[hist]
      ,[geog]
      ,[ciencia]
      ,[arte]
      ,[religiao]
      ,[ingles]
      ,[fisica]
      ,[ap]
      ,[r]
      ,[faltas]
      
  FROM [BDAtaFinal].[dbo].[tbl_Bimestre]
  join tbl_Alunos on tbl_Bimestre.id_aluno = tbl_alunos.id_aluno
  join tbl_turma on tbl_Bimestre.id_turma = tbl_turma.id_turma
  join tbl_professor on tbl_turma.id_professor = tbl_professor.id_prof
  join tbl_turno on tbl_turma.id_turno = tbl_turno.id_turno
  join tblAno on tbl_turma.id_ano = tblAno.id_Ano
  
";
        string final = " order by tblAno.ano, turno, professor, nome ";
        public void select(DataTable tabela, string _select, string ano)
        {
            try{
                
            SqlConnection con = new SqlConnection(conexao());
            SqlDataAdapter adp = new SqlDataAdapter(_select + " where ano = "+ ano, con);
            adp.Fill(tabela);
            }catch
            {
                System.Windows.Forms. MessageBox.Show("Deu ruim");
            }
        }
        public void select2(DataTable tabela, string _select)
        {
            try
            {

                SqlConnection con = new SqlConnection(conexao());
                SqlDataAdapter adp = new SqlDataAdapter(_select, con);
                adp.Fill(tabela);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Deu ruim");
            }
        }
        public void SelectSemFiltro(DataTable tabela, int ano)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao());
                SqlDataAdapter adp = new SqlDataAdapter(string.Format(" {0} where tbl_bimestre.ano = {1} {2}",strSelect ,ano,  final), con);
                adp.Fill(tabela);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Deu ruim");
            }
        }
        public void SelectComFiltro(DataTable tabela, int bm, int ano)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao());
                SqlCommand comando = new SqlCommand();
                comando.Connection = con;
                comando.CommandText = strSelect + " where bimestre = " + bm +" and tbl_bimestre.ano = "+ ano + final;
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                adp.Fill(tabela);
                
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Deu ruim");
            }
        }
        public void SelectComTurma(DataTable tabela, int Turma)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao());
                SqlCommand comando = new SqlCommand();
                comando.Connection = con;
                comando.CommandText = strSelect + " where tbl_Turma.id_Ano = " + Turma + final;
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                adp.Fill(tabela);

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Deu ruim");
            }
        }
        public void SelectComturno(DataTable tabela, string Turno)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao());
                SqlCommand comando = new SqlCommand();
                comando.Connection = con;
                comando.CommandText = strSelect + " where tbl_turno.Turno ='" + Turno + "'" + final;
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                adp.Fill(tabela);

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Deu ruim");
            }

        }
        public void SelectAnoETurno(DataTable tabela, int Turma,string Turno)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao());
                SqlCommand comando = new SqlCommand();
                comando.Connection = con;
                comando.CommandText = strSelect + " where tbl_Aluno.id_Turma = " + Turma + "and tbl_Turno.Turno = '" + Turno + "'" + final;
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                adp.Fill(tabela);

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Deu ruim");
            }

        }
        public void SelectCompletoBimestre(DataTable tabela, int Bimestre, int id_turma )
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao());
                SqlCommand comando = new SqlCommand();
                comando.Connection = con;
                comando.CommandText = string.Format("{0} where bimestre ={1} and tbl_bimestre.id_turma = {2} {3}", strSelect, Bimestre, id_turma,final);
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                adp.Fill(tabela);

            }
            catch(Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Deu ruim\n\t" + erro.ToString());
            }

        }
        public void SelectPeloId(DataTable tabela, int id, int _ano)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexao());
                SqlCommand comando = new SqlCommand();
                comando.Connection = con;
                comando.CommandText = string.Format("{0}  where tbl_bimestre.id_Aluno =  {1} and tbl_bimestre.ano = {2} {3}",strSelect, id,_ano,final);
                SqlDataAdapter adp = new SqlDataAdapter(comando);
                adp.Fill(tabela);

            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show("Deu ruim\n\t" + erro.ToString());
            }

        }
        public void FiltroPorNome(string nome, string ano, DataTable tabela)
        {
            if (nome != "")
            {
                SqlConnection con = new SqlConnection(conexao());
                string str = strSelect +  "where tbl_bimestre.ano = '" + ano + "' and nome like '%" + nome + "%' " + final;
                SqlCommand comando = new SqlCommand(str, con);
                
                SqlDataAdapter atp = new SqlDataAdapter(comando);
                atp.Fill(tabela);

            }

            else
            {
                SelectSemFiltro(tabela, int.Parse(ano));

            }

        }
        public void FiltroPorNome(int bimestre ,string nome, string ano, DataTable tabela)
        {
            if (nome != "")
            {
                SqlConnection con = new SqlConnection(conexao());
                string str = strSelect + "where tbl_bimestre.ano = '" + ano + "' and nome like '%" + nome + "%' and bimestre = "+ bimestre + final;
                SqlCommand comando = new SqlCommand(str, con);

                SqlDataAdapter atp = new SqlDataAdapter(comando);
                atp.Fill(tabela);

            }

            else
            {
                SelectSemFiltro(tabela, int.Parse(ano));

            }

        }
    }
}
