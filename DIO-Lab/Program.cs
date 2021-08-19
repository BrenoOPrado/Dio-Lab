using System;
using DIO_Lab.src.Entities;

namespace DIO_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 42, "Knight", 749, 469, 72, 72);
            Ninja Wedge = new Ninja("Wedge", 42, "Ninja", 574, 292, 89, 89);
            WhiteWizard Jenica = new WhiteWizard("Jenica", 42, "White Wizard", 601, 325, 482, 474);
            BlackWizard Topapa = new BlackWizard("Topapa", 42, "Black Wizard", 385, 106, 641, 611);
            Archer Chirico = new Archer("Chirico", 42, "Archer", 473, 252, 341, 196);

            Console.WriteLine(Arus);
            Console.WriteLine(Arus.Attack());
            Console.WriteLine();
            Console.WriteLine(Wedge);
            Console.WriteLine(Wedge.Attack());
            Console.WriteLine();
            Console.WriteLine(Jenica);
            Console.WriteLine(Jenica.Attack());
            Console.WriteLine();
            Console.WriteLine(Topapa);
            Console.WriteLine(Topapa.Attack());
            Console.WriteLine();
            Console.WriteLine(Chirico);
            Console.WriteLine(Chirico.Attack());
        }
    }
}
