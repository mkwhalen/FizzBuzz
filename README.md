# FizzBuzz
A take on fizz buzz that allows users to input number and keyword combinations that will "fizz" and "buzz" at the desired number from 1 to 100.

Console app written in C#

When run, the console will prompt you to enter a number. Once you enter a number, it will prompt you to enter a keyword. You can do this as many times as you would like. When you want to finish entering number and keyword combinations, type "done".

Console will give a list of 1 to 100. Any multiple of any number you specified, will appear as the corresponding keyword.

Assumptions:

1. Keywords can be any character (including nothing)
2. Numbers should be between 1-100 but can be any number
3. When there is a number that is a multiple of more than one input combos will show all keywords on separate lines.
Example: inputs of {3, "Bentley"} and {5, "Ryder"} will appear as:

13  
14  
Bentley  
Ryder  
16  
17  
