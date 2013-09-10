using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication2.Models;
using MvcApplication2.Repositories;

namespace MvcApplication2.Controllers
{
    public class AlbumController : ApiController
    {
        // GET api/album
        public IEnumerable<Album> Get()
        {
            var albums = AlbumRepository.FindAll();
            return albums;
        }

        // GET api/album/5
        public Album Get(int id)
        {
            var album = AlbumRepository.FindAll().Where(x => x.Id == id).FirstOrDefault();
            return album;
        }

        // POST api/album
        public void Post([FromBody]string value)
        {
        }

        // PUT api/album/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/album/5
        public void Delete(int id)
        {
        }
    }
}
