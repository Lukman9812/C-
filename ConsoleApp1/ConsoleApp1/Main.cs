using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class main
    {
        static void Main(string[] args)
        {
            Zdravic zdravic = new Zdravic("Ahoj uživatelu", "Karel", "XYZ");
            zdravic.Pozdrav();
            zdravic.SetJmeno("Lukas");
            zdravic.Pozdrav();
            Console.ReadKey();
        }
    }
}
