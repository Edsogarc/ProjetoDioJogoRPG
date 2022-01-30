using System;
using ProjetoDIOJogoRPG.src.Entities;

namespace ProjetoDIOJogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 42, "Ninja");
            BWizard topapa = new BWizard("Topapa", 38, "Black Wizard");

            Console.WriteLine($"{arus.Attack(6)}");
            Console.WriteLine($"{wizard.Attack(7)}");
            Console.WriteLine($"{wedge.Attack(8)}");
            Console.WriteLine($"{topapa.Attack(9)}");
        }
    }    
}
