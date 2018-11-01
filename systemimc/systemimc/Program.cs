using System;

namespace systemimc
{
    class Program
    {
        static void Main(string[] args)
        {
            IMC iMC = new IMC();
            Console.WriteLine("Informe o nome: ");
            iMC.Nome = Console.ReadLine();

            Console.WriteLine("Informe o peso: ");
            iMC.Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            iMC.Altura = double.Parse(Console.ReadLine());
            //iMC.Massa();
            Console.WriteLine("{0} tem peso {1}, altura {2} "
                              , iMC.Nome, iMC.Peso, iMC.Altura);
            Console.WriteLine("{0} ", iMC.Massa());

        }
    }
}
