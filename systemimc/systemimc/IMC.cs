using System;
namespace systemimc
{
    public class IMC
    {
        public string Nome {get; set;}
        public double Altura {get; set;}
        public double Peso {get; set;}
        public double CalculoImc () {
            return (Peso / (Altura * Altura));
        }
        public string Massa(){

            if (CalculoImc() < 18.5) {
                return "ABAIXO";
            } else if (CalculoImc() >= 18.5 && CalculoImc() < 25) {
                return "NORMAL";

            }else if (CalculoImc() >= 25 && CalculoImc() < 35 ){
                return "OB MODERADA";

            }else if (CalculoImc() >= 35 && CalculoImc() < 40 ) {
                return " OB MODERADA";

            } else {
                return "OB MORBIDA";
            }

        }
        public IMC()
        {
        }
    }
}
