using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // const int n = 5;
            // char[] array = new char[n];
            // int i = 0;
            // int probel=0;
            // Console.WriteLine("Enter array: ");
            // while (array[i] != '.')
            // {
            //     array[i] = char.Parse(Console.ReadLine()); // тут вызывает исключение, решение не нашел
            //     i++;
            //     if(array[i] == ' ')
            //     {
            //         probel++;
            //     }
            // }
            // for (int k = 0; k < i; k++)
            // {
            //     Console.WriteLine(array[k]);
            // }
            // Console.WriteLine("Probelov = " + probel);
            //Console.WriteLine("******************************");
            // Console.ReadLine();


            Console.Write("Enter a ticket: ");
            int number_tram = int.Parse(Console.ReadLine());
            int a = number_tram / 100000;
            int b = (number_tram / 10000) % 10;
            int c = (number_tram / 1000) % 10;
            int a1 = (number_tram / 100) % 10;
            int b1 = (number_tram / 10) % 10;
            int c1 = number_tram % 10;
            if (a + b + c == a1 + b1 + c1)
            {
                Console.WriteLine("A lucky ticket!!!");
            }
            else
                Console.WriteLine("Ticket is not happy!!!");
            Console.WriteLine("******************************");
            Console.ReadLine();


            int lower = 0;
            int upper = 0;
            char symbolChar = ' ';
            Console.WriteLine("Enter text using upper and lower case (Пока не нажмете '.'!!!)");
            while (symbolChar != '.')
            {
                var symbol = Console.Read();

                if (symbol >= 65 && symbol <= 90)
                {
                    symbol += 32;
                    ++lower;
                }
                else if (symbol >= 97 && symbol <= 122)
                {
                    symbol -= 32;
                    ++upper;
                }
                symbolChar = Convert.ToChar(symbol);
                Console.Write(symbolChar);
            }
            Console.WriteLine();
            Console.WriteLine("Kolichestvo izmenennih simvolov " + (lower + upper));
            Console.WriteLine("******************************");
            Console.ReadLine();


            Console.WriteLine("Enter first and end number: ");
            int start_number = int.Parse(Console.ReadLine());
            int end_number = int.Parse(Console.ReadLine());
            for (int l = start_number; l <= end_number; l++)
            {
                for (int m = 0; m < l; m++)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("******************************");
            Console.ReadLine();


            int numbers = 439;
            int hundredth_elem = numbers / 100;
            int decimal_elem = (numbers / 10) % 10;
            int unit_elem = numbers % 10;
            Console.WriteLine(numbers + " число справа налево = " + unit_elem + ""
                + decimal_elem + "" + hundredth_elem);
            Console.WriteLine("******************************");
            Console.ReadLine();
        }
    }
}
