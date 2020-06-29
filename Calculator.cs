using System;

namespace ProjectCalc.Calculator
{
  public static class Calculator
  {
    public static int Add(int x, int y)
    {
      int number1 = x;
      int number2 = y;
      int answer = number1 + number2;
      return answer;
    }
    public static int Subtraction(int x, int y)
    {
      int number1 = x;
      int number2 = y;
      int answer = number1 - number2;
      return answer;
    }
    public static int Multiplication(int x, int y)
    {
      int number1 = x;
      int number2 = y;
      int answer = number1 * number2;
      return answer;
    }
    public static int Division(int x, int y)
    {
      int number1 = x;
      int number2 = y;
      int answer = number1 / number2;
      return answer;
    }
  }
}
		