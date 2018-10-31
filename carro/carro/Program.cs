using System;

namespace carro
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroCor carroCor = new CarroCor();

            Console.WriteLine(" Informe o nome do carro");
            carroCor.Nome = Console.ReadLine();
            Console.WriteLine(" Informe o marcar do carro");
            carroCor.Marcar = Console.ReadLine();
            Console.WriteLine(" Informe o cor do carro");
            carroCor.Cor = Console.ReadLine();

            Console.WriteLine( "Resultado " + carroCor.Nome + carroCor.Marcar + carroCor.Cor);


        }
    }
}
