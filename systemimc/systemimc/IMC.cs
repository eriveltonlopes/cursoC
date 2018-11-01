using System;
namespace systemimc
{
    public class IMC
    {
        public string Nome {
            get; set;
        }
        public double Altura {
            get; set;
        }
        public double Peso {
            get; set;
        }
        public double Massa(){
            double resultado = (Peso / (Altura * Altura));
            if (resultado < 18.5) {
                Console.WriteLine("Abaixo do peso!!");
            } else if (resultado >= 18.5 && resultado < 25) {
                Console.WriteLine("Normal");
            }else if (resultado >= 25 && resultado < 35 ){
                Console.WriteLine("OB leve");
            } else if (resultado >= 35 && resultado < 40 ) {
                Console.WriteLine("OB Moderada");
            } else {
                Console.WriteLine("OB Morbido");
            }
            return resultado;
        }
        public IMC()
        {
        }
    }
}
