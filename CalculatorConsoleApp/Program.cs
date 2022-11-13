using CalculatorConsoleApp;
using System;

namespace BasicCalculatorConsoleApp
{
    public class Program {

        public static void Main(string[] args) {
            int [] array = {1, 2, 3};
            Calculate calc = new Calculate ();
            var result = calc.Average(array);
            Console.WriteLine(result);
            Console.ReadLine();
        
        }

    
    }
}
