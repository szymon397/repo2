using MyApp.Console.Interfaces;
using MyApp.Core.Services;

namespace MyApp.Console
{
    public class AppRunner
    {
        private readonly IMenu _menu;
        private readonly IConsole _console;
        private readonly ISongService _songService;

        public AppRunner(IMenu menu, IConsole  console, ISongService songService)
        {
            _menu = menu;
            _console = console;
            _songService = songService;
        }

        public void StartApp()
        {
            while(true)
            {
                _console.Clear();
                _menu.MainMenu();
                var res = _console.GetResponeFromUser();
                switch (res)
                {
                    case 1:
                        ShowAllSongs();
                        break;
                    case 10:
                        _console.WriteLine("Bye bye");
                        return;
                    default:
                        _console.WriteLine("Nie wiem o co chodzi");
                        break;
                }
            }
        }

        private void ShowAllSongs()
        {
            var sonsgs = _songService.GetAllSongs();
            foreach (var item in sonsgs)
            {
                _console.WriteLine(item);
            }
            _console.ReadLine();
        }

    }
}
