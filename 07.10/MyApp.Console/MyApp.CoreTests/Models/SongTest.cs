using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyApp.CoreTests.Models
{
    public class SongTest
    {
        [Fact]
        public void ToString_ReturnCorrectData()
        {
            var song = new Song
            {
                Id = 1,
                Album = "Album",
                Artist = "Artysta",
                Title = "Tytuł"
            };

            var str = song.ToString();

            Assert.Equal("Id: 1, Title: Tytuł, Album: Album, Artist: Artysta", str);
        }
    }
}
