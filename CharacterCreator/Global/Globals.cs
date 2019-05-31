using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CharacterCreator.Global
{
    public static class Globals
    {
        public static int Strength = 5;
        public static int Agility = 5;
        public static int Intelligence = 5;

        public static Gender Gender = Gender.Male;
        public static Race Race = Race.Human;
        public static Class Class = Class.Warrior;

        public static string Name = "";
        public static Image Picture;

        public static List<Image> m_MaleImages = new List<Image>();
        public static List<Image> m_FemaleImages = new List<Image>();
        public static List<Image> m_Images = new List<Image>();

        public static string GenderToString()
        {
            if (Gender == Gender.Male)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }
        public static Gender StringToGender(string gender)
        {
            if (gender == "Male")
            {
                return Gender.Male;
            }
            else
            {
                return Gender.Female;
            }
        }
        public static string RaceToString()
        {
            if (Race == Race.Dwarf)
            {
                return "Dwarf";
            }
            else if (Race == Race.Elf)
            {
                return "Elf";
            }
            else
            {
                return "Human";
            }
        }
        public static Race StringToRace(string race)
        {
            if (race == "Dwarf")
            {
                return Race.Dwarf;
            }
            else if (race == "Elf")
            {
                return Race.Elf;
            }
            else
            {
                return Race.Human;
            }
        }
        public static string ClassToString()
        {
            if (Class == Class.Wizard)
            {
                return "Wizard";
            }
            else if (Class == Class.Archer)
            {
                return "Archer";
            }
            else
            {
                return "Warrior";
            }
        }
        public static Class StringToClass(string classT)
        {
            if (classT == "Wizard")
            {
                return Class.Wizard;
            }
            else if (classT == "Archer")
            {
                return Class.Archer;
            }
            else
            {
                return Class.Warrior;
            }
        }
        public static string GetImageIndex()
        {
            if (Gender == Gender.Male)
            {
                for (int i = 0; i < m_MaleImages.Count; i++)
                {
                    if (Picture == m_MaleImages[i])
                    {
                        return i.ToString();
                    }
                }

                return "";
            }
            else
            {
                for (int i = 0; i < m_FemaleImages.Count; i++)
                {
                    if (Picture == m_FemaleImages[i])
                    {
                        return i.ToString();
                    }
                }
                return "";
            }
        }
        //Loads the base images
        public static void LoadImages()
        {
            for (int i = 0; i < 9; i++)
            {
                m_MaleImages.Add(Image.FromFile("Images/Male/M_portrait0" + i.ToString() + ".jpg"));
            }

            for (int i = 0; i < 9; i++)
            {
                m_FemaleImages.Add(Image.FromFile("Images/Female/F_portrait0" + i.ToString() + ".jpg"));
            }
        }
    }

    public enum Gender
    {
        Male,
        Female
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
