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
    public partial class CadastroAlunos : Form
    {
        private int codigo;

        public CadastroAlunos()
        {
            InitializeComponent();
        }

        public CadastroAlunos(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            Aluno aluno = new AlunoRepositorio().ObterPelocodigo(codigo);
            PreencherCampos(aluno);
        }

        private void PreencherCampos(Aluno aluno)
        {
            txtCodigo.Text = aluno.Id.ToString();
            txtNome.Text = aluno.Nome;
            txtCodigoMatricula.Text = aluno.CodigoMatricula;
            nudFrequencia.Value = aluno.Frequencia;
            txtNota1.Text = aluno.Nota01.ToString();
            txtNota2.Text = aluno.Nota02.ToString();
            txtNota3.Text = aluno.Nota03.ToString();
            lblMedia.Text = aluno.Media.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            
            aluno.Nome = txtNome.Text;
            aluno.CodigoMatricula = txtCodigoMatricula.Text;
            aluno.Frequencia = Convert.ToByte(nudFrequencia.Value);
            aluno.Nota01 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota02 = Convert.ToDouble(txtNota2.Text);
            aluno.Nota03 = Convert.ToDouble(txtNota3.Text);
            aluno.Media = Convert.ToDouble(lblMedia.Text);
           

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                int id = new AlunoRepositorio().Inserir(aluno);
                txtCodigo.Text = id.ToString();
                MessageBox.Show("Resgistrado com sucesso");
            }
            else
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                aluno.Id = id;
                bool alterou = new AlunoRepositorio().Alterar(aluno);
                if (alterou)
                {
                    MessageBox.Show("Registro alterado com sucesso");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar");
                }
            }            

           
        }

        private void LimparCampos()
        {
            txtCodigoMatricula.Text = "";
            txtNome.Text = "";
            nudFrequencia.Value = 0;
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    Aluno aluno = new AlunoRepositorio().ObterPelocodigo(id);
                    if (aluno != null)
                    {
                        PreencherCampos(aluno);
                    }
                    else
                    {
                        MessageBox.Show("O registro não existe");
                        txtCodigo.Focus();
                        txtCodigo.SelectionStart = 0; // Seleciona o texto
                        txtCodigo.SelectionLength = txtCodigo.Text.Length;
                    }
                }
                catch (NotFiniteNumberException ex)
                {
                    MessageBox.Show("Digite um código válido");
                    txtCodigo.Focus();
                }
            }
        }

        private void CalcularMediaDoAluno()
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;

            if (string.IsNullOrEmpty(txtNota1.Text.Replace(",", "").Replace(" ", "")))
            {
                nota1 = 0;
            }
            else
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
            }

            if (string.IsNullOrEmpty(txtNota2.Text.Replace(",", "").Replace(" ", "")))
            {
                nota2 = 0;
            }
            else
            {
                nota2 = Convert.ToDouble(txtNota2.Text);
            }

            if (string.IsNullOrEmpty(txtNota3.Text.Replace(",", "").Replace(" ", "")))
            {
                nota3 = 0;
            }
            else
            {
                nota3 = Convert.ToDouble(txtNota3.Text);
            }

            double media = (nota1 + nota2 + nota3) / 3;
            lblMedia.Text = String.Format("{0:n}", media);
        }

        private void SituacaoDoAluno()
        {
            double media = Convert.ToDouble(lblMedia.Text);
            if (media < 5)
            {
                lblSituacaoAluno.Text = "Reprovado";
            }
            if ((media >= 5) && (media < 7))
            {
                lblSituacaoAluno.Text = "Recuperação";
            }
            if (media >= 7)
            {
                lblSituacaoAluno.Text = "Aprovado";
            }
        }

        private void txtNota1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtNota1.Text) >= 10)
            {
                MessageBox.Show("Nota 1 deve ser menor ou igual 10");
                txtNota1.Focus();
                txtNota1.SelectionStart = 0;
                txtNota1.SelectionLength = txtNota1.Text.Length;
                return;
            }
            CalcularMediaDoAluno();
            SituacaoDoAluno();
            
        }

        private void txtNota2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtNota2.Text) >= 10)
            {
                MessageBox.Show("Nota 2 deve ser menor ou igual 10");
                txtNota2.Focus();
                txtNota2.SelectionStart = 0;
                txtNota2.SelectionLength = txtNota2.Text.Length;
                return;
            }
            CalcularMediaDoAluno();
            SituacaoDoAluno();
        }

        private void txtNota3_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtNota3.Text) >= 10)
            {
                MessageBox.Show("Nota 3 deve ser menor ou igual 10");
                txtNota3.Focus();
                txtNota3.SelectionStart = 0;
                txtNota3.SelectionLength = txtNota3.Text.Length;
                return;
            }
            CalcularMediaDoAluno();
            SituacaoDoAluno();
        }
 
    }
}
