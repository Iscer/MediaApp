using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediaRest.Models;



namespace MediaRest.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {

        private readonly MediaContext _context;


        public ImagesController(MediaContext context){
            _context = context;

            if (_context.Images.Count() == 0 ){

                _context.Images.Add(new Image{  Name = "IMAGE001", Path = "/Users/rest"});
                _context.SaveChanges();
            }


        }

        // GET: api/Image
        [HttpGet]
        public IEnumerable<Image> Get()

        {
            return _context.Images.ToList();
        }

        // GET api/Image/{id}
        [HttpGet("{id}", Name =  "GetImages")]
        public IActionResult GetById(int id)
        {
            var item = _context.Images.FirstOrDefault(t => t.Id == id);
            if(item == null){
                return NotFound();

            }

            return new ObjectResult(item);

        }

        // POST api/Images
        [HttpPost]
        public IActionResult Create([FromBody] Image img)
        {
            if (img == null)
            {
                return BadRequest();
            }

            _context.Images.Add(img);
            _context.SaveChanges();

            return CreatedAtRoute("GetImages", new { id = img.Id }, img);

        }

        // PUT api/Images/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Image img)
        {
            if (img == null || img.Id != id)
            {
                return BadRequest();
            }

            var item = _context.Images.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            item.Width = img.Width;
            item.Height = img.Height;

            _context.Images.Update(item);
            _context.SaveChanges();

            return new NoContentResult();


        }



        // DELETE api/Images/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _context.Images.FirstOrDefault(t => t.Id == id);

            if(item == null ){
                return NotFound();
            }

            _context.Images.Remove(item);
            _context.SaveChanges();

            return new NoContentResult();

        }
    }
}
