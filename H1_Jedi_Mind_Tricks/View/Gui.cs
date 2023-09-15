using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Jedi_Mind_Tricks.View
{
    /// <summary>
    /// Class <see cref="Gui"/> represents all graphical to the user
    /// </summary>
    internal class Gui
    {
        /// <summary>
        /// Prints a success message when a key is found and removed
        /// </summary>
        /// <param name="key">key which were removed</param>
        public void ShowKeyRemoveSucces(string key)
        {
            Console.Write($"Fandt nøglen ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"'{key}'");
            Console.ResetColor();
            Console.WriteLine(" og fjernede den");
        }

        /// <summary>
        /// Prints a error message when a key can't be found
        /// </summary>
        /// <param name="key">key which didn't exist</param>
        public void ShowKeyError(string key)
        {
            Console.Write($"Kunne ikke finde nøglen ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"'{key}'");
            Console.ResetColor();
        }

        /// <summary>
        /// Prints the given dictionary's key and value pairs
        /// </summary>
        /// <param name="dictionary"></param>
        public void ShowDictionaryKVP(Dictionary<string, int> dictionary)
        {
            Console.WriteLine("\n");
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                Console.Write($"Fandt: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Key[{kvp.Key}], Value[{kvp.Value}]");
                Console.ResetColor();
            }
        }
    }
}
