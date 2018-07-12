using CadastroAlunos.Modelo;
using System;
using System.Collections.Generic;
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
            VALUES (@NOME, @CODIGO_MATRICULA, @NOTA_1, @NOTA_2, @NOTA_3, @FREQUENCIA)";

            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.CodigoMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota01);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota02);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota03);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequancia);

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
nota_1 = @NOTA_1"

        }

    }
}
