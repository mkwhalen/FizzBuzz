using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzLibrary
{
    public class Fizzing
    {
        List<string> result = new List<string>();

        public List<string> ListFizzBuzz(List<UserInput> userList)
        {

            var input = userList;

            var i = 1;

            while (i <= 100)
            {
                if (input.Any(var => i % Convert.ToInt32(var.Number) == 0))
                {

                    for (var j = 0; j < input.Count(); j++)
                    {
                        if (i % Convert.ToInt32(input[j].Number) == 0)
                        {
                            result.Add($"{input[j].KeyWord}");
                        }
                    }
                }
                else
                {
                    result.Add(i.ToString());

                }

                i++;

            }

            // get each value of the result list
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(result[15]);

            return result;

        }
    }
}


