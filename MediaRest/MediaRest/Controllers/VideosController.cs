using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediaRest.Models;



namespace MediaRest.Controllers
{
    [Route("api/[controller]")]
    public class VideosController : Controller
    {

        private readonly MediaContext _context;


        public VideosController (MediaContext context){
            _context = context;

        }

        // GET: api/Videos
        [HttpGet]
        public IEnumerable<Video> GetAll()

        {
            return _context.Videos.ToList(); 
        }

        // GET api/Videos/{id}
        [HttpGet("{id}", Name = "GetVideos")]
        public IActionResult GetById(int id)
        {
            var item = _context.Videos.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();

            }

            return new ObjectResult(item);

        }

        // POST api/Videos
        [HttpPost]
        public IActionResult Create([FromBody] Video vdo)
        {
            if (vdo == null)
            {
                return BadRequest();
            }

            _context.Videos.Add(vdo);
            _context.SaveChanges();

            return CreatedAtRoute("GetImages", new { id = vdo.Id }, vdo);

        }

        // PUT api/Videos/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Video vdo)
        {
            if (vdo == null || vdo.Id != id)
            {
                return BadRequest();
            }

            var item = _context.Videos.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            item.Width = vdo.Width;
            item.Height = vdo.Height;
            item.LengthTime = vdo.LengthTime;
            item.Format = vdo.Format;
            item.Name = vdo.Name; 


            _context.Videos.Update(item);
            _context.SaveChanges();

            return new NoContentResult();


        }



        // DELETE api/Images/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _context.Videos.FirstOrDefault(t => t.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            _context.Videos.Remove(item);
            _context.SaveChanges();

            return new NoContentResult();

        }


    }
}
