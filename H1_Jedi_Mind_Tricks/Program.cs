using H1_Jedi_Mind_Tricks.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Jedi_Mind_Tricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController mainCtrl = new MainController();
            mainCtrl.Start();
            Console.ReadLine();
        }
    }
}
