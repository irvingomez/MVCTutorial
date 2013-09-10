using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication2.Models;

namespace MvcApplication2.Repositories
{
    public static class AlbumRepository
    {
        private static List<Album> _albums;

        public static List<Album> FindAll()
        {
            if (_albums == null)
            {
                _albums = new List<Album>();
                _albums.Add(new Album() { Id=1, Artist = "Led Zeppelin", Genre = "Rock", Name = "Led Zeppelin II" });
                _albums.Add(new Album() { Id = 2, Artist = "Queen", Genre = "Rock", Name = "Live Killers" });
                _albums.Add(new Album() { Id = 3, Artist = "Pink Floyd", Genre = "Rock", Name = "The Wall" });
                _albums.Add(new Album() { Id = 4, Artist = "Queen", Genre = "Rock", Name = "Made in Heaven" });
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