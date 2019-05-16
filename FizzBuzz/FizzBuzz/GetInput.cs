using FizzLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using static FizzLibrary.Fizzing;

namespace FizzBuzz
{

    public class GetInput
    {
        List<UserInput> AllUserParameters = new List<UserInput>();

        // Get parameters from user
        public void GetUserInput()
        {
            Console.WriteLine("Enter a number: ");
            var inputNumber = Console.ReadLine();

            //validate they gave us a number
            int integer;
            if (Int32.TryParse(inputNumber, out integer) == false)
            {
                Console.WriteLine("Oops, looks like that isn't a number, please try again");
                GetUserInput();
            }
            if (Convert.ToInt32(inputNumber) > 100 || Convert.ToInt32(inputNumber) < 1)
            {
                Console.WriteLine("Oops, looks like this number is outside of our range (1-100). If you would like to proceed anyway, type 'YES'");
                var shouldContinue = Console.ReadLine();
                
                if (shouldContinue.ToUpper().Trim() != "YES")
                {
                    GetUserInput();
                }
            }

            Console.WriteLine("Enter a keyword: ");
            var inputKeyword = Console.ReadLine();

            UserInput userInput = new UserInput { Number = inputNumber.ToString(), KeyWord = inputKeyword.ToString() };

            AllUserParameters.Add(userInput);

            Console.WriteLine("Finished? Type 'DONE' if you are finished adding conditions. Otherwise, press Enter");
            var isFinished = Console.ReadLine();

            if (isFinished.ToUpper().Trim() == "DONE")
            {
                var createFizz = new Fizzing();
                createFizz.ListFizzBuzz(AllUserParameters);
            }

            else
            {
                GetUserInput();
            }
        }
    }
}
