using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.Repositories
{
    public static class AlbumRepository
    {
        private static List<Album> _albums;

        public static List<Album> FindAll()
        {
            if (_albums == null)
            {
                _albums = new List<Album>();
                _albums.Add(new Album() { Artist = "Led Zeppelin", Genre = "Rock", Name = "Led Zeppelin II" });
                _albums.Add(new Album() { Artist = "Queen", Genre = "Rock", Name = "Live Killers" });
                _albums.Add(new Album() { Artist = "Pink Floyd", Genre = "Rock", Name = "The Wall" });
                _albums.Add(new Album() { Artist = "Queen", Genre = "Rock", Name = "Made in Heaven" });
            }
            return _albums;
        }

        public static void Add(Album album)
        {
            _albums = AlbumRepository.FindAll();
            _albums.Add(album);
        }
    }
}