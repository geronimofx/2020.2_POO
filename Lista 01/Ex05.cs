using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Digite a base do retângulo:");
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a altura do retângulo:");
    double h = double.Parse(Console.ReadLine());

    double A = b*h;
    double P = 2*b + 2*h;
    double diag = Math.Sqrt((b*b + h*h));

    Console.WriteLine ($"Área = {A:0.00} - Perímetro = {P:0.00} - Diagonal = {diag:0.00}");
  }
}