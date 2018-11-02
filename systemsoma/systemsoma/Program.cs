using System;

namespace systemsoma
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma soma = new Soma(1, 2);
            Soma soma1 = new Soma(1, 2, 3);
            Soma soma2 = new Soma(1, 2, 3, 4);
            Console.WriteLine("soma: " + soma.result);
            Console.WriteLine("soma: " + soma1.result);
            Console.WriteLine("soma: " + soma2.result);
        }
    }
}
