using CadastroAlunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos.Repositorio
{
    class AlunoRepositorio
    {
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\104895\Documents\ListaExerciciosBancoDadosWFA.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection = null;

        public AlunoRepositorio()
        {
            connection = new SqlConnection(connectionString);
        }

        public int Inserir(Aluno aluno)
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"INSERT INTO alunos (nome, codigo_matricula, nota_1, nota_2, nota_3, frequencia)
OUTPUT INSERTED.ID
            VALUES (@NOME, @CODIGO_MATRICULA, @NOTA_1, @NOTA_2, @NOTA_3, @FREQUENCIA)";

            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.CodigoMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota01);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota02);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota03);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);

            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            connection.Close();
            return id;
        }

        public bool Alterar(Aluno aluno)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"UPDATE alunos SET
nome = @NOME,
codigo_matricula = @CODIGO_MATRICULA,
nota_1 = @NOTA_1,
nota_2 = @NOTA_2,
nota_3 = @NOTA_3,
frequencia = @FREQUENCIA
WHERE id = @CODIGO";

            comando.Parameters.AddWithValue("@NOME", aluno.Nome);
            comando.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.CodigoMatricula);
            comando.Parameters.AddWithValue("@NOTA_1", aluno.Nota01);
            comando.Parameters.AddWithValue("@NOTA_2", aluno.Nota02);
            comando.Parameters.AddWithValue("@NOTA_3", aluno.Nota03);
            comando.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            comando.Parameters.AddWithValue("@CODIGO", aluno.Id);

            int quantidadeAlterada = comando.ExecuteNonQuery();
            connection.Close();
            return quantidadeAlterada == 1;
        }

        public List<Aluno> ObterAlunos(
                string textoParaPesquisar = "%%",
                string colunaOrdenacao = "nome",
                string tipoOrdenacao = "ASC"
            )
        {
            textoParaPesquisar = "%" + textoParaPesquisar + "%";
            List<Aluno> alunos = new List<Aluno>();
            connection.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"SELECT
id, nome, codigo_matricula, nota_1, nota_2, nota_3, ((nota_1 + nota_2 + nota_3) / 3)
FROM alunos
WHERE nome LIKE @PESQUISA OR codigo_matricula LIKE @PESQUISA OR ((nota_1 + nota_2 + nota_3) / 3) LIKE @PESQUISA
ORDER BY " + colunaOrdenacao + " " + tipoOrdenacao;
            comando.Parameters.AddWithValue("@PESQUISA", textoParaPesquisar);

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++) 
            {
                Aluno aluno = new Aluno();
                aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[i][0]);
                aluno.Nome = tabelaEmMemoria.Rows[i][1].ToString();
                aluno.CodigoMatricula = tabelaEmMemoria.Rows[i][2].ToString();
                aluno.Nota01 = Convert.ToDouble(tabelaEmMemoria.Rows[i][3]);
                aluno.Nota02 = Convert.ToDouble(tabelaEmMemoria.Rows[i][4]);
                aluno.Nota03 = Convert.ToDouble(tabelaEmMemoria.Rows[i][5]);
                aluno.Media = Convert.ToByte(tabelaEmMemoria.Rows[i][6]);
                alunos.Add(aluno);
            }

            connection.Close();
            return alunos;
        }

        public Aluno ObterPelocodigo(int codigo)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"SELECT
id, nome, codigo_matricula, nota_1, nota_2, nota_3, ((nota_1 + nota_2 + nota_3) /3), frequencia
FROM alunos
WHERE id = @CODIGO";
            comando.Parameters.AddWithValue("@CODIGO", codigo);

            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());
            if (tabelaEmMemoria.Rows.Count == 0)
            {
                return null;
            }

            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(tabelaEmMemoria.Rows[0][0].ToString());
            aluno.Nome = tabelaEmMemoria.Rows[0][1].ToString();
            aluno.CodigoMatricula = tabelaEmMemoria.Rows[0][2].ToString();
            aluno.Nota01 = Convert.ToDouble(tabelaEmMemoria.Rows[0][3].ToString());
            aluno.Nota02 = Convert.ToDouble(tabelaEmMemoria.Rows[0][4].ToString());
            aluno.Nota03 = Convert.ToDouble(tabelaEmMemoria.Rows[0][5].ToString());
            aluno.Frequencia = Convert.ToByte(tabelaEmMemoria.Rows[0][6].ToString());
            connection.Close();
            return aluno;
        }

        public bool Apagar(int codigo)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "DELETE FROM alunos WHERE id = @CODIGO";
            comando.Parameters.AddWithValue("@CODIGO", codigo);
            int quantidade = comando.ExecuteNonQuery();
            connection.Close();
            return quantidade == 1;
        }

    }
}
