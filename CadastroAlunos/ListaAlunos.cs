using CadastroAlunos.Modelo;
using CadastroAlunos.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class ListaAlunos : Form
    {
        public ListaAlunos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroAlunos cadastroAlunos = new CadastroAlunos();
            cadastroAlunos.ShowDialog();
            
        }

        private void AtualizarLista()
        {
            string coluna = "nome";            
            if (rbCodigoMatriculaColuna.Checked)
            {
                coluna = "Codigo_matricula";
            }

            if (rbMediaColuna.Checked)
            {
                coluna = "(nota_1 + nota_2 + nota_3) / 3";
            }

            string tipoOrdenacao = "ASC";
            if (rbDESCOrdenar.Checked)
            {
                tipoOrdenacao = "DESC";
            }

            dataGridView1.Rows.Clear();
            List<Aluno> alunos = new AlunoRepositorio().ObterAlunos(txtPesquisa.Text, coluna, tipoOrdenacao);
            foreach (Aluno aluno in alunos)
            {
                dataGridView1.Rows.Add(new object[] 
                    {
                        aluno.Id,
                        aluno.Nome,
                        aluno.CodigoMatricula,
                        aluno.Nota01,
                        aluno.Nota02,
                        aluno.Nota03,
                        aluno.Media
                    });
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            int codigo = Convert.ToInt32(dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString());
            new CadastroAlunos(codigo).ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Nenhum aluno foi selecionado!");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            int codigo = Convert.ToInt32(dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString());
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[1].Value.ToString();
            DialogResult resultado = MessageBox.Show("Você deseja realmente apagar o registro " + "?", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                bool apagado = new AlunoRepositorio().Apagar(codigo);
                MessageBox.Show("Registro Apagado com sucesso");
            }
            else
            {
                MessageBox.Show(nome + " Não apagado");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void ListaAlunos_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }
       
        private void ListaAlunos_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbNomeColuna_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbFrequanciaColuna_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbCodigoMatriculaColuna_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbASCOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void rbDESCOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        
    }
}
