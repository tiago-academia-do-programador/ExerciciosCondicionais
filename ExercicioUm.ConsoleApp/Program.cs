using System;

namespace ExercicioUm.ConsoleApp
{
    public class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
        //soma de A + B é menor que C.
        public static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Digite o valor A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a + b < c)
                Console.WriteLine("A + B é menor que C!");
            else
                Console.WriteLine("A + B não é menor que C!");

            Console.ReadKey();
        }
    }
}
