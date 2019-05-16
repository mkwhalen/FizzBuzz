using System;
using Xunit;
using FizzBuzz;
using FizzLibrary;
using System.Collections.Generic;

namespace FizzBuzz.Test
{
    public class FizzyTest
    {
        [Fact]
        public void MultipleKeywords()
        {
            //arrange

            var fizz = new UserInput() { Number = "3", KeyWord = "Bentley" };
            var buzz = new UserInput() { Number = "5", KeyWord = "Ryder" };

            List<UserInput> userList = new List<UserInput>() { fizz, buzz };

            var fizzle = new Fizzing();

            string bentleyCheck = "Bentley";
            string ryderCheck = "Ryder";

            //act

            var resultCheck = fizzle.ListFizzBuzz(userList);
           

            //assert

            Assert.Equal(resultCheck[14], bentleyCheck);
            Assert.Equal(resultCheck[15], ryderCheck);
        }
    }
}
