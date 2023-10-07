using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Console
{
    public class Menu : IMenu
    {
        public void MainMenu()
        {
            System.Console.WriteLine("Co chcesz zrobic");
            System.Console.WriteLine("1 - Wszystkie piosenki");
            System.Console.WriteLine("10 - Wyjdz");
        }
    }
}
