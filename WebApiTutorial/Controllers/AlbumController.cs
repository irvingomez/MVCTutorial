using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.Models;
using MvcApplication1.Repositories;

namespace WebApiTutorial.Controllers
{
    public class AlbumController : ApiController
    {
        // GET api/album
        public IEnumerable<Album> Get()
        {
            return AlbumRepository.FindAll();
        }

        // GET api/album/5
        public Album Get(int id)
        {
            return AlbumRepository.FindAll().Where(x => x.Id == id).FirstOrDefault();
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
