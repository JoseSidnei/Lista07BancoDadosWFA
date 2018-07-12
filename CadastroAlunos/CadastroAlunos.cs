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

        private void PreencherCampos(Aluno aluno)
        {

            txtNome.Text = aluno.Nome;
            txtCodigoMatricula.Text = aluno.CodigoMatricula;
            txtFrequancia.Text = aluno.Frequancia.ToString();
            txtNota1.Text = aluno.Nota01.ToString();
            txtNota2.Text = aluno.Nota02.ToString();
            txtNota3.Text = aluno.Nota03.ToString();           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtNome.Text;
            aluno.CodigoMatricula = txtCodigoMatricula.Text;
            aluno.Frequancia = Convert.ToByte(txtFrequancia.Text);
            aluno.Nota01 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota02 = Convert.ToDouble(txtNota2.Text);
            aluno.Nota03 = Convert.ToDouble(txtNota3.Text);

            if (string.IsNullOrEmpty(txtCodigoMatricula.Text))
            {
                int id = new AlunoRepositorio().Inserir(aluno);
                txtCodigoMatricula.Text = id.ToString();
                MessageBox.Show("Resgistrado com sucesso");
            }
            else
            {
                int id = Convert.ToInt32(txtCodigoMatricula.Text);
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
            txtFrequancia.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";

        }
    }
}
