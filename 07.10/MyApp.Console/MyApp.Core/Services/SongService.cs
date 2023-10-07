using MyApp.Core.Models;
using MyApp.Core.Repository;

namespace MyApp.Core.Services
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _sqlSongRepository;

        public SongService(ISongRepository sqlSongRepository)
        {
            _sqlSongRepository = sqlSongRepository;
        }

        public Song[] GetAllSongs()
        {
            //Tu sprawdzam uprawnienia
            var songs = _sqlSongRepository.GetSongs();
            return songs;
        }
    }
}
