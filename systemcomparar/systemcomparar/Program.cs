using System;

namespace systemcomparar
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.WriteLine("Informe dois números ");
            numero.N1 = Int32.Parse(Console.ReadLine());
            numero.N2 = Int32.Parse(Console.ReadLine());
            numero.Compara();
            //Console.WriteLine(" {0}", numero.Compara());

        }
    }
}
