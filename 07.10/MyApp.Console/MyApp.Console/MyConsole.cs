using MyApp.Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Console
{
    public class MyConsole : IConsole
    {
        public void Clear()
        {
            System.Console.Clear();
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void WriteLine(object msg)
        {
            System.Console.WriteLine(msg);
        }


        public int GetResponeFromUser()
        {
            while (true)
            {
                var res = ReadLine();
                if (int.TryParse(res, out var intResponse))
                {
                    return intResponse;
                }
                WriteLine("Jeszcze raz - to nie jest int");
            }
        }
    }
}
