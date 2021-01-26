using System;

class MainClass {
  public static void Main (string[] args) {
    
    string [] X = Console.ReadLine().Split(' ');
    double x1 = double.Parse(X[0]);
    double y1 = double.Parse(X[1]);

    string [] Y = Console.ReadLine().Split(' ');
    double x2 = double.Parse(Y[0]);
    double y2 = double.Parse(Y[1]);

    double dist = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));

    Console.WriteLine($"{dist:F4}");

  }
}