using System;
namespace BemVindo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite quando jose tem: ");
            double x = double.Parse(Console.ReadLine());
            string resultado = (x == 100.00) ? "Jose tem 100 reais" : "Jose perdeu 100 reais";
            Console.WriteLine(resultado);
        }
    }
}
