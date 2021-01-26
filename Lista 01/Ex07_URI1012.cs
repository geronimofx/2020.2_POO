using System;

class MainClass {
  public static void Main (string[] args) {
    
    string [] area = Console.ReadLine().Split(' ');
    double a = double.Parse(area[0]);
    double b = double.Parse(area[1]);
    double c = double.Parse(area[2]);

    double Atrian = (a*c)/2;
    double Acirc = 3.14159*Math.Pow(c,2);
    double Atrap = ((a+b)*c)/2;
    double Aquad = b*b;
    double Aret = a*b;

    Console.WriteLine($"TRIANGULO: {Atrian:F3}");
    Console.WriteLine($"CIRCULO: {Acirc:F3}");
    Console.WriteLine($"TRAPEZIO: {Atrap:F3}");
    Console.WriteLine($"QUADRADO: {Aquad:F3}");
    Console.WriteLine($"RETANGULO: {Aret:F3}");

  }
}