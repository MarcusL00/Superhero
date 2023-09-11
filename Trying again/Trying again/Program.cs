using System.Security.Cryptography.X509Certificates;

namespace Trying_again
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero1 = new SuperHero()
            {
                // Filling in data into the objects
                Name = "Clark kent",
                Age = 35,
                Alias = "Superman",
                SuperPowers = "Superhuman strength, speed, and flight",
                ArchNemesis = "Lex Luthor",
                Motivation = "To protect Earth and its people from threats"


            };

            superHero1.Introduction();
        }

    }
}