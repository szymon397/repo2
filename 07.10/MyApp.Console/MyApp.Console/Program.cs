using MyApp.Console.Interfaces;
using MyApp.Core.Repository;
using MyApp.Core.Services;
using System.Threading;

namespace MyApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();
            IConsole console = new MyConsole();
            ISongRepository songRepository = new SqlSongRepository();
            ISongService songService = new SongService(songRepository);

            var appRunner = new AppRunner(menu, console, songService);
            appRunner.StartApp();
        }

       
    }
}
