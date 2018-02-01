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
        public static string CheckInput(string Input)
        {
            while (true)
            {
                if (Regex.IsMatch(Input, "^(scifi|horror|animated)$"))
                {
                    return Input;
                }
                else
                {
                    Console.WriteLine("I didn't understand that... Try again!");
                    Input = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
