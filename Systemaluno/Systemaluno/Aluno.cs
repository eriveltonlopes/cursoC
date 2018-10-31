using System;
namespace Systemaluno
{
    public class Aluno
    {
        public string Nome{
            get; set;
        }
        public double Nota{
            get; set;
        }
        public double Media() {
            Nota = Nota / 3;
            return Nota;
        }
        public Aluno()
        {
        }
    }
}
