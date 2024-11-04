using System;

namespace GroupTwo
{
    public class Super4
    {
        public static int Bucle(int min, int max)
        {
            int num;
            do
            {
                Console.Write($"Write a number between {min} and {max}");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < min || num > max);
            return num;
        }

        public static string ChoseName()
        {
            string name = "";
            do
            {
                Console.WriteLine();
            } while (EspecialChar(name));
            return name;
        }

        public static string LenghtName(int min, int max)
        {
            string name;
            do
            {
                Console.Write("Write a name: ");
                name = Console.ReadLine();
            } while (name.Length < 2 || name.Length > 25);
            return name;
        }

        public static bool EspecialChar(string name)
        {
            string[] bannedChar = { "@", "#", "-", "/", "_" };
            bool repeat = false;

            foreach (string item in bannedChar)
            {
                foreach (char letter in name)
                {
                    if (item != letter.ToString())
                    {
                        repeat = true;
                    }
                }
            }
            return repeat;
        }

        //El pseudocodi no s'enté
        public static bool GetVocals(string name, ref int power, ref int evilness)
        {
            string[] vocals = { "a", "e", "i", "o", "u" };
            bool success = false;
            int vocalCounter = 0;
            foreach (char item in name) 
            { 
                foreach (string vocal in vocals)
                {
                    if (item.ToString() == vocal)
                    {
                        vocalCounter++;
                    }
                }
            }
            if ()
            {
                power = evilness / 4;
                evilness = evilness % 4;
            } else
            {
                power = evilness / 20 / 4;
            }
            return success;
        }

        public static int Spell(int evilness, ref string name)
        {
            int power;
            if (GetVocals(name))
            {
                power = evilness / 4;
                evilness = evilness % 4;
            }
            else
            {
                 power = evilness / 20 / 4;
            }
            return power;
        }

        public static void Main()
        {
            int numChar, evilness, power = 0;
            string name;

            numChar = Bucle(1, 4);
            name = ChoseName();
            evilness = Bucle(1000, 50000);
            power = Spell(evilness, ref name);
        }
    }
}
