using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_evaluator
{
    class Program
    {
        static void Main(string[] args)
        {          
            try
            {
                Console.WriteLine(Parser.Evaluator("5+(6/6)+(666+663)/214*4 + (666+663)"));
            }
            catch (Exception e)
            {

                throw e;
            }
            Console.ReadKey();
        }

    }
}

