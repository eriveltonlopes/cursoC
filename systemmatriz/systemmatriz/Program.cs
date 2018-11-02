using System;

namespace systemmatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = " ";
            for (int i = 1; i < 11; i++) {

                for (int j = 1; j < 11; j++) {
                    texto += j + " ";
                }
                Console.WriteLine(i + "," + texto);
                texto = "";
            }

        }
    }
}
