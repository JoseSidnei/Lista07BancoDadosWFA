namespace CadastroAlunos
{
    partial class CadastroAlunos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigoMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudFrequencia = new System.Windows.Forms.NumericUpDown();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblSituacaoAluno = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFrequencia = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(462, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtCodigoMatricula
            // 
            this.txtCodigoMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMatricula.Location = new System.Drawing.Point(55, 168);
            this.txtCodigoMatricula.Name = "txtCodigoMatricula";
            this.txtCodigoMatricula.Size = new System.Drawing.Size(300, 22);
            this.txtCodigoMatricula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código da Matrícula";
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(55, 296);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(300, 22);
            this.txtNota1.TabIndex = 4;
            this.txtNota1.Leave += new System.EventHandler(this.txtNota1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 1";
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(55, 358);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(300, 22);
            this.txtNota2.TabIndex = 5;
            this.txtNota2.Leave += new System.EventHandler(this.txtNota2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota 2";
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(55, 417);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(300, 22);
            this.txtNota3.TabIndex = 6;
            this.txtNota3.Leave += new System.EventHandler(this.txtNota3_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nota 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Frequência";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(605, 390);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(181, 49);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Informações do Aluno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Notas do Aluno";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(55, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(300, 22);
            this.txtCodigo.TabIndex = 123;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Código ";
            // 
            // nudFrequencia
            // 
            this.nudFrequencia.Location = new System.Drawing.Point(462, 168);
            this.nudFrequencia.Name = "nudFrequencia";
            this.nudFrequencia.Size = new System.Drawing.Size(300, 20);
            this.nudFrequencia.TabIndex = 3;
            this.nudFrequencia.Leave += new System.EventHandler(this.nudFrequencia_Leave);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(578, 268);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(25, 25);
            this.lblMedia.TabIndex = 125;
            this.lblMedia.Text = "0";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(482, 268);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(90, 25);
            this.lblM.TabIndex = 124;
            this.lblM.Text = "Média :";
            // 
            // lblSituacaoAluno
            // 
            this.lblSituacaoAluno.AutoSize = true;
            this.lblSituacaoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacaoAluno.Location = new System.Drawing.Point(704, 330);
            this.lblSituacaoAluno.Name = "lblSituacaoAluno";
            this.lblSituacaoAluno.Size = new System.Drawing.Size(25, 25);
            this.lblSituacaoAluno.TabIndex = 126;
            this.lblSituacaoAluno.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(482, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 25);
            this.label10.TabIndex = 127;
            this.label10.Text = "Situação do aluno :";
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.AutoSize = true;
            this.lblFrequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequencia.Location = new System.Drawing.Point(625, 298);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(25, 25);
            this.lblFrequencia.TabIndex = 129;
            this.lblFrequencia.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(482, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 25);
            this.label12.TabIndex = 128;
            this.label12.Text = "Frequência:";
            // 
            // CadastroAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 456);
            this.Controls.Add(this.lblFrequencia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSituacaoAluno);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.nudFrequencia);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigoMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudFrequencia;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblSituacaoAluno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.Label label12;
    }
}

