using Moq;
using MyApp.Console;
using MyApp.Console.Interfaces;
using MyApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyApp.ConsoleTests
{
    public class AppRunnerTest
    {
        
        [Fact]
        public void StartApp_InvokeCorrect()
        {
            Mock<IMenu> menu = new Mock<IMenu>();
            Mock<IConsole> console = new Mock<IConsole>();
            Mock<ISongService> songService = new Mock<ISongService>();

            console.Setup(c => c.GetResponeFromUser()).Returns(10);

            var menuObject = menu.Object;
            var consoleObject = console.Object;
            var songServiceObject = songService.Object;

            var appRuner = new AppRunner(menuObject, consoleObject, songServiceObject);

            appRuner.StartApp();

            console.Verify(x => x.Clear(), Times.Once);
            console.Verify(x => x.WriteLine("Bye bye"), Times.Once);
        }
    }
}
