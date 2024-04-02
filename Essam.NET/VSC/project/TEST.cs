
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

            //string[] Friends = new string[5];
            string[] Friends = new string[5] {
                                            
                                             "Awad"  ,
                                             "Ali"   ,
                                             "Mohmed",
                                             "Ahmed" ,
                                             "Farg"  ,
                                                    };

            var x = 2..3;

           string[] slice1 = Friends[x];
            slice1.Print();
            Console.WriteLine(slice1);

            Friends.Print();
            Console.ReadKey();
        }

    }
}
