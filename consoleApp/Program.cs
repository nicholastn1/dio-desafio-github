using System;

namespace consoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      int numDeVezes = 5;

      for (int i = 0; i < numDeVezes; i++)
      {
          Console.WriteLine($"Bem-vindo ao curso de .NET {i+1}");
      }
    }
  }
}
