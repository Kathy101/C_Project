  using System;
  using System.Collections.Generic;

  namespace Calculator
  {
  class Program
  {
    public static void Main(string[] arge)
    {
      int a = 42;
      int b = 116;
      Console.WriteLine("enter your calculation");
      Console.ReadKey();

    int menu; //Variable for the number the user inputs
    float num1, num2, result; //Float variables for the user input and output, used floats in case the user enters e.g. 14.7

    printf("Enter a number from the list below\n\n");

    printf("1. Addition\n"); //Calculator menu, user must enter a value from 1 - 4 for the program to work
    printf("2. Subtraction\n");
    printf("3. Multiplication\n");
    printf("4. Division\n\n");

    printf("Enter number: "); //User input for the calculator menu
    scanf("%d", &menu);

    printf("\n");

     Calculator(menu,number1,number2,result);
    }
  }
}
