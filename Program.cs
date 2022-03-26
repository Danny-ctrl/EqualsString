using System;
namespace EqualsString
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = "Este texto é um teste";

      System.Console.WriteLine(texto.Equals("Este texto é um teste"));
      System.Console.WriteLine(texto.Equals("esse texto é um teste"));
      System.Console.WriteLine(texto.Equals("este texto é um teste"));
    }
  }
}