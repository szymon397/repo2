using MyApp.Core.Models;

namespace MyApp.Core.Repository
{
    public interface ISongRepository
    {
        Song[] GetSongs();
    }
}