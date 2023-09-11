using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trying_again
{
    public class SuperHero
    {
        private string _name = "";
        private int? _age;
        private string? _alias = "";
        private string? _superPowers = "";
        private string? _archNemesis = "";
        private string? _motivation = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int? Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string? Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        public string? SuperPowers
        {
            get { return _superPowers; }
            set { _superPowers = value; }
        }
        public string? ArchNemesis
        {
            get { return _archNemesis; }
            set { _archNemesis = value; }
        }
        public string? Motivation
        {
            get { return _motivation; }
            set { _motivation = value; }
        }
        public void Introduction()
        {
            Console.WriteLine($"I am {Name}, im {Age} years old, and also known as {Alias}. i have special ability such as {SuperPowers}. My arch Nemisis is {ArchNemesis}");
        }
    }
}
