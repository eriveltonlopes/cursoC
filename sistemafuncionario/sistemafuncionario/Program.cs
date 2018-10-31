using System;

namespace sistemafuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Salário");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine(funcionario.Nome + " R$ " + funcionario.trazNovoSalario());
        }
    }
}
