using System;

namespace Systemaluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe 3 notas ");
            for (int i = 0; i < 3; i++) {
                aluno.Nota += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("nota {0} = media {1}", aluno.Nome, aluno.Media());
        }
    }
}
/*
 * receber 3 notas e retornar sua media 
 * 
*/