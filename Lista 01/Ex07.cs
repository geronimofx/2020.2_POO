using System;

class MainClass {
  public static void Main (string[] args) {

    string name = Console.ReadLine();
    double sal_fixo = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());
    double total = sal_fixo + (vendas*(0.15));

    Console.WriteLine("TOTAL = R$ {0:F2}",total);
  }
}
