using H1_Jedi_Mind_Tricks.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Jedi_Mind_Tricks.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> controls the whole program
    /// </summary>
    internal class MainController
    {
        public void Start()
        {
            Gui gui = new Gui();
            Dictionary<string, int> people = new Dictionary<string, int>();

            // Adds different KeyValuePairs to dictionary
            people.Add("Nicklas", 18);
            people["Anders"] = 34;
            people["Andreas"] = 24;
            people["Silas"] = 19;

            // Removes key 'Silas' if it exists
            if(people.Remove("Silas"))
            {
                gui.ShowKeyRemoveSucces("Silas");
            }
            else
            {
                gui.ShowKeyError("Silas");
            }

            // Prints the Dictionary's KVP
            gui.ShowDictionaryKVP(people);
        }
    }
}
