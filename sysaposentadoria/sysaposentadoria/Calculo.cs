using System;
namespace sysaposentadoria
{
    public class Calculo
    {
        // idade >= 65 || trabalhado >= 30 anos

        // idade >= 60 || trabalhado >=25 
        public string Nome { get; set; }
        public double Idade { get; set; }
        public double Trabalhado { get; set; }
         
        public string CalculoApos() {
            if ((Idade >= 60 && Idade < 65) && (Trabalhado >= 25)) {
                return "APOSENTADO";
            } else if (Idade >= 65 || Trabalhado > 30) {
                return "APOSENTADO";

            } else {
                return "NAO PODE SER APOSENTAR";
            }
        }
        //IDADE MINIMA DE 65
        //TER TRABALHADO 30
        //ELE TER MINIMO 60 E 25 CONTRIBUIR


        public Calculo()
        {
        }
    }
}
