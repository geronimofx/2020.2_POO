using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Digite o intervalo de tempo no formato 'HH:MM:SS':");
    string [] luz = Console.ReadLine().Split(':');
    int H = int.Parse(luz[0]);
    int M = int.Parse(luz[1]);
    int S = int.Parse(luz[2]);

    double seg = (H*3600) + (M*60) + S;
    double distancia = seg*300000;
    //Console.WriteLine(seg);

    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
  }
}
