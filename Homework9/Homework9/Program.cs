using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Некоторый текст в одну строку; текст может содержать знаки препинания.");
            var input = Console.ReadLine().Split();

            var text = new int[input.Length];
            for (var i = 0; i < text.Length; i++)
                text[i] = int.Parse(input[i]);

            PrintIntArray(text);
            {

            }

            ReductArray(text);
            Console.WriteLine("Массив в нижнем регистре");


        }
        
        static void PrintIntArray(int[] array)
        {
            foreach (var elem in array)
                Console.WriteLine($"{elem}");
            Console.WriteLine();
        }

        static void ReductArray(int[] array)
        {
            
        }
    }
}
