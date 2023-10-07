using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Repository
{
    public class SqlSongRepository : ISongRepository
    {
        private Song[] _allSongs = new Song[5];
        
        public Song[] GetSongs()
        {
            //Tu pobieram dane z SqlBd
            for (int i = 0; i < 5; i++)
            {
                _allSongs[i] = new Song { Album = $"A{i}", Artist = "Artysta", Id = i + 1, Title = $"T{i}" };
            }            
            return _allSongs;
        }
    }
}
