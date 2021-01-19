using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine("Digite seu primeiro nome: ");
    string x = Console.ReadLine();
    
    Console.WriteLine($"Bem vindo ao C#, {x}");
  }
}