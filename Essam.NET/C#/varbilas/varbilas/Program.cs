using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varbilas
{
        public static class EXtensions
        {
            public static void Print<T>(this T[] source)
            {
                if(!source.Any())
                {
                    Console.WriteLine("{}");
                    return;
                }
                Console.Write("{ ");
                for(var i=0;i<source.Length;i++)
                {
                    Console.Write($"{source[i]}");
                    Console.Write(i < source.Length - 1 ? "," : "");

                }
                Console.Write(" }");
            }
        }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wage : ");
            var wage = Convert.ToDouble(Console.ReadLine());

            

           


            

            Console.ReadKey();

        }
           

    }
}
