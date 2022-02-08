using System;

namespace ExercicioDois.ConsoleApp
{
    public class Program
    {
        //Escreva um algoritmo que leia três valores inteiros e diferentes e
        //mostre-os em ordem decrescente.
        public static void Main(string[] args)
        {
            int valorA, valorB, valorC;

            while (true)
            {
                Console.Clear();

                Console.Write("Digite o valor A: ");
                valorA = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o valor B: ");
                valorB = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o valor C: ");
                valorC = Convert.ToInt32(Console.ReadLine());

                if (valorA > valorB && valorB > valorC)
                    Console.WriteLine("{0} {1} {2}", valorA, valorB, valorC);

                else if (valorA > valorB && valorA > valorC && valorC > valorB)
                    Console.WriteLine("{0} {1} {2}", valorA, valorC, valorB);

                else if (valorB > valorA && valorA > valorC)
                    Console.WriteLine("{0} {1} {2}", valorB, valorA, valorC);

                else if (valorB > valorA && valorB > valorC && valorC > valorA)
                    Console.WriteLine("{0} {1} {2}", valorB, valorC, valorA);

                else if (valorC > valorB && valorB > valorA)
                    Console.WriteLine("{0} {1} {2}", valorC, valorB, valorA);

                else if (valorC > valorB && valorA > valorB)
                    Console.WriteLine("{0} {1} {2}", valorC, valorA, valorB);

                Console.ReadKey(); 
            }
        }
    }
}
