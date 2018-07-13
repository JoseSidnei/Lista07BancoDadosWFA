using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos.Modelo
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CodigoMatricula { get; set; }
        public double Nota01 { get; set; }
        public double Nota02 { get; set; }
        public double Nota03 { get; set; }
        public byte Frequencia { get; set; }
        public double Media { get; set; }

    }
}
