using System.Globalization;

namespace Exe03_POO_Methods {
    internal class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno(); 
            
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double nf = aluno.NotaFinal();
            Console.WriteLine("NOTA FINAL = " + nf.ToString("F2", CultureInfo.InvariantCulture));
            
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " 
                    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS");
            }
        }
    }
}
