using System;

namespace ProjectCalc.Calculator
{
  public static class Calculator
  {
    public static int Add(int x, int y)
    {
      int num1 = x;
      int num2 = y;
      int answer = num1 + num2;
      return answer;
    }
    public static int Subtraction(int x, int y)
    {
      int num1 = x;
      int num2 = y;
      int answer = num1 - num2;
      return answer;
    }
    public static int Multiplication(int x, int y)
    {
      int num1 = x;
      int num2 = y;
      int answer = num1 * num2;
      return answer;
    }
    public static int Division(int x, int y)
    {
      int num1 = x;
      int num2 = y;
      int answer = num1 / num2;
      return answer;
    }
  }
}
		