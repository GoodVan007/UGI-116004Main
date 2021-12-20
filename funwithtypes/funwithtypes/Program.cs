using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funwithtypes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                double PI = Math.PI;
                int oneThousand = 1000000;
                float piF = (float)PI;
                float oneThousandPi =(float) (PI * oneThousand);
                int rounded1000Pi =(int)Math.Round(oneThousandPi); //тут должно правильно округляться
                int integerPart =(int)(Math.Round(oneThousandPi)); //а тут нужно вычислить целую часть
                Console.WriteLine(rounded1000Pi);
                Console.WriteLine(integerPart);

                double a = 10;
                a += 0.5; //надо исправить, чтоб работало
                Console.WriteLine(a);

                var b = "15";
                var c = a + double.Parse(b); //тут что-то не так! надо поправить
                Console.WriteLine(c);
                Console.ReadKey();
            }
        }
    }
}
    

