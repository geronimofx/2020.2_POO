using System;

class MainClass {
  public static void Main (string[] args) {
    
    int dist = int.Parse(Console.ReadLine());
    double gasolina = double.Parse(Console.ReadLine());

    double consumo = dist/gasolina;

    Console.WriteLine($"{consumo:F3} km/l");
  }
}