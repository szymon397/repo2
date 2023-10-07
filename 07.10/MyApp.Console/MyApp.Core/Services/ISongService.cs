using MyApp.Core.Models;

namespace MyApp.Core.Services
{
    public interface ISongService
    {
        Song[] GetAllSongs();
    }
}