using System;
namespace systemsoma
{
    public class Soma
    {

        public int result { get; set; }
        public Soma( int n1, int n2) {
            result = n1 + n2;
        }
        public Soma(int n1, int n2, int n3){
            result = n1 + n2 + n3; 
        }
        public Soma(int n1, int n2, int n3, int n4 ){
            result = n1 + n2 + n3 + n4;
        }
    }
}
