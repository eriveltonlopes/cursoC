using System;
namespace systemcomparar
{
    public class Numero
    {
        public int N1 {
            get; set;
        }
        public int N2 {
            get; set;
        }

        public void Compara () {
            if (N1 > N2) {
                Console.WriteLine("Primeiro numero é maior");
                //return N1;
            } else if (N2 > N1) {
                Console.WriteLine("segundo numero é maior");
                //return N2;
            } else {
                Console.WriteLine("Os dois números sao iguais");
                //return (N1 = N2);
            }

        }
        public Numero()
        {
        }
    }
}
