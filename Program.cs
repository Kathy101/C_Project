using System;
using System.Linq;
using ProjectCalc.Calculator;

namespace ProjectCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      string restart_calculator = "no";
      string[] operator_array = new string[4]{ "+", "-", "*", "/" };
      int number1;
      int number2;
      
      do // run the program a first time and then loop it depending of the user input
      {
        Console.WriteLine("What type of calculation do you want to perform? (+, -, *, /)");
        string type_of_calculation = Console.ReadLine();

        // verify if user input is not a valid operator contain in the array.
        while(!operator_array.Contains(type_of_calculation))
        {
          Console.WriteLine("choose a valid operator !");
          type_of_calculation = Console.ReadLine();
        }
        Console.WriteLine("choose the first number");
        string input = Console.ReadLine();

        // verify if user input is an int before parsing
        while(int.TryParse(input, out int n1) == false)
        {
          Console.WriteLine("try again ! This time with an actual number... :P");
          input = Console.ReadLine();
        }
        number1 = Int32.Parse(input);
        Console.WriteLine("Choose the second number");
        input = Console.ReadLine();
        
        // verify if user input is an int before parsing
        while(int.TryParse(input, out int n2) == false)
        {
          Console.WriteLine("try again ! This time with an actual number... :P");
          input = Console.ReadLine();
        }
        number2 = Int32.Parse(input);
   
          if (number2 == 0) Console.WriteLine("Cannot divided by zero");
          else {
          Console.WriteLine("The Answer is " + Calculator.Division(number1, number2)); };
          Console.WriteLine("Hit 'Enter' to restart the calculator ");
          restart_calculator = Console.ReadLine();
        }
        else
        {
          Console.WriteLine("unknown Error");
        }
      }	while(restart_calculator == "");

        System.Environment.Exit(0);
    }
  }
}


