using System;

namespace systemimc
{
    class Program
    {
        static void Main(string[] args)
        {

            //metodo replace(".", ",") troca a , pelo .
            //metodo 
            string pesoTela, alturaTela;

            IMC iMC = new IMC();
            Console.WriteLine("Informe o nome: ");

            iMC.Nome = Console.ReadLine();

            Console.WriteLine("Informe o peso: ");
            pesoTela = Console.ReadLine().Replace(".", ",");
            iMC.Peso = double.Parse(pesoTela);

            Console.WriteLine("Informe a altura: ");
            alturaTela = Console.ReadLine().Replace(".", ",");
            iMC.Altura = double.Parse(alturaTela);

            Console.WriteLine("{0} tem peso {1}, altura {2} "
                              , iMC.Nome, iMC.Peso, iMC.Altura);
            Console.WriteLine("{0} ", iMC.Massa());

        }
    }
}
