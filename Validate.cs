using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab10
{
    class Validate
    {
        public static Categories CheckInput(string Input)
        {
            while (true)
            {
                Categories genre;
                if (Enum.TryParse(Input, out genre) == true)
                {
                    if((int)genre > 4 || (int)genre < 1)
                    {
                        Console.WriteLine("I didn't understand that... Try again!");
                        Input = Console.ReadLine();
                    }
                    else
                        return genre;
                }
                else
                {
                    Console.WriteLine("I didn't understand that... Try again!");
                    Input = Console.ReadLine();
                }
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Continue? (y/n)");
            string x = Console.ReadLine().ToLower();

            while (true)
            {
                if (Regex.IsMatch(x, "^(yes|y)$"))
                {
                    Console.Clear();
                    return true;
                }
                else if (Regex.IsMatch(x, "^(no|n)$"))
                    return false;
                else
                {
                    Console.WriteLine("Invalid input. Try again!");
                    x = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
