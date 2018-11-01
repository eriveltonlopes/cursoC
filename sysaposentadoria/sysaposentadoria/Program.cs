using System;

namespace sysaposentadoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calculo = new Calculo();
            Console.WriteLine("Informe o Nome");
            calculo.Nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe a idade");
            calculo.Idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Ano servico");
            calculo.Trabalhado = double.Parse(Console.ReadLine());

            Console.WriteLine(calculo.Nome +  " " +  calculo.CalculoApos());
        }
    }
}
