using System;

class Program {
  public static void Main (string[] args) {

  while (true) 
{
    Console.WriteLine("Give a number!");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 0)
    {
        break;
    }
  else if (num < 0)
  {
    Console.WriteLine("That is negative!");
  }
  else if (num > 0 * num)
  {
    Console.WriteLine(num*num);
  }
  }
}
  }
  
