using System;
using FizzLibrary;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            var startFizz = new GetInput();
            startFizz.GetUserInput();

            Console.ReadLine();
        }
        
    }
}

// users pass in any number and word pair and as many as they want 
// if [3, burrito] return % 3 = burrito
// can pass in any number
// add unit testing library (xUnit) check for "15 case" when input meets both requirements