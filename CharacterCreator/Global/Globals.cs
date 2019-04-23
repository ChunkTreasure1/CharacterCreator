using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Global
{
    public static class Globals
    {
        public static int Strength = 0;
        public static int Agility = 0;
        public static int Intelligence = 0;

        public static Gender Gender = Gender.Male;
        public static string Name = "";
    }

    public enum Gender
    {
        Male,
        Female,
        Random
    }

    public enum Race
    {
        Human,
        Elf,
        Dwarf
    }

    public enum Class
    {
        Wizard,
        Archer,
        Warrior
    }
}
