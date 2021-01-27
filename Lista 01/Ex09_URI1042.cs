using System;

class MainClass {
  public static void Main (string[] args) {
    
    string [] num = Console.ReadLine().Split(' ');
    int a = int.Parse(num[0]);
    int b = int.Parse(num[1]);
    int c = int.Parse(num[2]);

    // ordenar em crescente
    if (a > b && a > c){ //a é o maior
      if (b > c){
        Console.WriteLine(c);
        Console.WriteLine(b);
        Console.WriteLine(a);
      }
      else {
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(a);
      }
    }
    else if ( b > a && b > c){ //b é o maior
      if (a > c){
        Console.WriteLine(c);
        Console.WriteLine(a);
        Console.WriteLine(b);        
      }
      else {
        Console.WriteLine(a);
        Console.WriteLine(c);
        Console.WriteLine(b);
      }
    }
    else if (c > a && c > b){ //c é o maior
      if (a > b){
        Console.WriteLine(b);
        Console.WriteLine(a);
        Console.WriteLine(c);        
      }
      else {
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
      }
    }

    Console.WriteLine(); //linha em branco

    //mostrar na ordem que foram digitados
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);  

  }
}