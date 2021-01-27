using System;

class MainClass {
  public static void Main (string[] args) {
    
    int t = int.Parse(Console.ReadLine());
    int v = int.Parse(Console.ReadLine());

    double dist = t*v;

    Console.WriteLine($"{(dist/12):F3}");
  }
}