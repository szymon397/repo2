using MyApp.Core.Models;
using MyApp.Core.Repository;
using MyApp.Core.Services;
using System.Linq;
using Xunit;

namespace MyApp.CoreTests.Services
{
    public class SongServiceTest
    {
        [Fact]
        public void GetAllSongs_ReturnCorrectData()
        {
            var songServices = new SongService(new MockSongRepo());

            var result = songServices.GetAllSongs();

            Assert.True(result.Count() == 1);
        }

        public class MockSongRepo : ISongRepository
        {
            public Song[] GetSongs()
            {
                return new Song[]
                {
                    new Song
                    {
                         Album = "Fake Album"
                    }
                };
            }
        }


    }
}
