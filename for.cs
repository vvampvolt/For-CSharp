using System;
class HelloWorld {
  static void Main(string[] args)
  {
      int N, i;
      Console.WriteLine("Início do Programa");
      Console.WriteLine("Entre com um valor numérico inteiro: ");
      N = int.Parse(Console.ReadLine());
      
      Console.WriteLine("Valor N entrado: {0}", N);
      
      if (N < 10)
      {
          Console.WriteLine("Valor Inválido");
      }
      else
      {
          for (i = 1; i <= N; i++)
          {
              Console.WriteLine("{0}. USCS", i);
          }
      }
      
      Console.WriteLine("Fim do Programa");
      Console.ReadKey();
  }
}
