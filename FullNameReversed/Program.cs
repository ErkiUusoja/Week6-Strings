using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime tagurpidi
            //eesnimi ja perekonnanimi kuvatakse eraldi
            //kasutame for tsüklit

            Console.WriteLine("Sisesta eesnimi:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            for (int i = userFirstName.Length - 1; i >= 0; i--)
            {
                Console.Write(userFirstName[i]);
            }
            for (int i = userLastName.Length - 1; i >= 0; i--)
            {
                Console.Write(userLastName[i]);
            }
        }
    }
}
