using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            if(userFirstName.Length > userLastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            else if (userFirstName.Length < userLastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi.")
            }
            else
            {
                Console.WriteLine("sama pikad");
            }
        }
    }
}
