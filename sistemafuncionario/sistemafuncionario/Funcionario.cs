using System;
namespace sistemafuncionario
{
    public class Funcionario
    {
        public string Nome{
            get; set;
        }
        public double Salario{
            get;set;
        }

        public double trazNovoSalario()
        {
            if (Salario <= 1000) {
                Salario += Salario * 0.3;
                return Salario;
            } else if (Salario > 1000 && Salario <= 1500 ){
                Salario += Salario * 0.15;
                return Salario;
            } else if (Salario > 1500) {
                Salario += Salario * 0.1;
                return Salario;
            }
            return Salario;
        }

        public Funcionario()
        {
        }
    }
}
