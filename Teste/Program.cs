using System;
using System.Reflection.Metadata;
using System.Globalization;

namespace Teste {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int room = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura:");
            string info = Console.ReadLine();
            string[] info2 = info.Split(' ');

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(name);
            Console.WriteLine(room);
            Console.WriteLine(value.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(info2[0]);
            Console.WriteLine(info2[1]);
            Console.WriteLine(info2[2]);

           
        }
    }
}