using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1
{
    class Program
    {
        static void Main(string[] args)
        {



            int n = 2;
            double g = 9.8;

            Console.WriteLine(n);
            Console.WriteLine(g);
            Console.WriteLine(n++ + ++n);
            Console.WriteLine(n);

            int x = 3, y = 4, z = 5;
            Console.WriteLine(x + y * z);

            x = y += 2;
            Console.WriteLine(x);

            double angle = Math.PI / 6;
            double sinusX = Math.Sin(angle);
            Console.WriteLine(sinusX);

            //int k;
            //k = 1;

            var k = "1";
            Console.WriteLine(k);

            angle = x;
            Console.WriteLine(angle);

            x = (int)Math.Pow(2, 3);
            Console.WriteLine(x);

            x = (int)Math.Sqrt(3);
            Console.WriteLine(x);

            x = (int)Math.Round(Math.Sqrt(3));
            Console.WriteLine(x);

            Console.WriteLine((int)(-1.5));
            Console.WriteLine(Math.Floor(-1.5));

            int integerNumber;
            long longNumber;
            checked
            {
                longNumber = 100;
                integerNumber = (int)longNumber;
                Console.WriteLine(integerNumber);
                //longNumber = 30000000000L
                //integerNumber = (int)longNumber
                //Console.WriteLine(integerNumber);

            }
            Console.WriteLine(Square(5));
            Console.WriteLine(Square(1.5));

            Console.WriteLine("Введите целое число");
            var val = int.Parse(Console.ReadLine());
            Console.WriteLine(++val);

            var v = 0x91;
            var w = v.ToString();
            Console.WriteLine(w);
            w = Convert.ToString(v, 2);
            Console.WriteLine(w);

            Console.ReadKey();




            /// <summary>
            /// Этот метод возводит в квадрат целое число
            /// </summary>
            /// <param name="number">число, возводимое в квадрат</param>
            /// <returns>квадрат числа </returns>

        }
        static int Square(int number)

        {
            return number * number;

        }
        static double Square(double number)
        {
            return number* number;
        }
    }

}