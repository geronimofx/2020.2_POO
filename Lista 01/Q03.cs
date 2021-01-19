using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine ("Digite a nota do primeiro bimestre da disciplina:");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite a nota do segundo bimestre da disciplina:");
    int y = int.Parse(Console.ReadLine());

    int media = (x*2 + y*3)/5;

    Console.WriteLine ($"Média parcial = {media}");
  }
}