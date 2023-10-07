using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Console.Interfaces
{
    public interface IConsole
    {
        void Clear();

        void WriteLine(object msg);

        string ReadLine();

        int GetResponeFromUser();
    }
}
