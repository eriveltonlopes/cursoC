using System;

namespace systemquantidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior=0, menor =999 , numero=0, soma=0;
            Console.WriteLine("informe quantidade: ");
            int n;
            n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i ++){
                Console.WriteLine(" informe numero: ");
                numero = Int32.Parse(Console.ReadLine());

                if( numero > maior) {
                    maior = numero;
                }
                if (numero < menor) {
                    menor = numero;
                }
                soma =  soma + numero;
            }

            Console.WriteLine("Maior " + maior);
            Console.WriteLine("menor " + menor);
            Console.WriteLine("soma " + soma);
        }
    }
}
