using System;

class MainClass {
  public static void Main (string[] args) {
    string [] luz = Console.ReadLine().Split(' ');
    int a = int.Parse(luz[0]);
    int b = int.Parse(luz[1]);
    int c = int.Parse(luz[2]);

    int maior = (a+b + Math.Abs(a-b))/2;
    int Maior = (maior+c + Math.Abs(maior-c))/2;

    Console.WriteLine($"{Maior} eh o maior");    
  }
}