using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{

    class clsCalcuater
    {
        private string _lastOP;

        private float _Result;
        
           
        

        public float add(float num)
        {
            _lastOP = $"Adding {num}" ;
            _Result= _Result + num;
            return _Result ;
        }

        public float Subtract(float num)
        {
            _lastOP = $"Subtracting {num}" ;
            _Result = _Result - num;
            return _Result ;
        }

        public float Divide(float num)
        {


            if (num == 0)
                num = 1;

            _lastOP = $"Dividing {num}";
            _Result = _Result / num;
            return _Result ;
        }

        public float Multply(float num)
        {

            _lastOP = $"Multply {num}";
            _Result = _Result * num;
            return _Result ;
        }

        public void Clear()
        {
            _lastOP = $" Clear ";
            _Result=0;
        }


        public void PrintResult()
        {
            Console.WriteLine($"Result after {_lastOP} is : {_Result}"); 
        }


    }




    class Program
    {
        static void Main(string[] args)
        {

            clsCalcuater Calc = new clsCalcuater();

            Calc.Clear();
           

            Calc.add(10);
            Calc.PrintResult();

            Calc.add(100);
            Calc.PrintResult();

            Calc.Divide(0);
            Calc.PrintResult();

            Calc.Clear();
            Calc.PrintResult();

            Console.ReadKey();
        }
    }
}
