using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class Arma
    {
        public string Nome { get; set; }
        public double DanoBase { get; set; }
      
        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Dano: {DanoBase}");
        }
        public abstract double CalcularAtaqueCritico();
    }
}
