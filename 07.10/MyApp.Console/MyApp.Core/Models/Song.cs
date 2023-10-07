using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Album { get; set; }

        public string Artist { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Album: {Album}, Artist: {Artist}";
        }
    }
}
