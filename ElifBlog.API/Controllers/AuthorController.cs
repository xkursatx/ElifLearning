using ElifBlog.API.Data;
using ElifBlog.API.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ElifBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AuthorController(
                ApplicationDbContext applicationDbContext
            )
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet("GetAuthors")]
        public IActionResult GetAuthors()
        {
            return Ok(applicationDbContext.AuthorTable.ToList());
        }

        [HttpPost("AddAuthor")]
        public IActionResult AddAuthor([FromBody] Author author)
        {
            applicationDbContext.AuthorTable.Update(author);
            applicationDbContext.SaveChanges();
            return Ok(author);
        }

        [HttpPut("EditAuthor")]
        public IActionResult EditAuthor([FromQuery] int Id, [FromBody] Author author)
        {
            var _author = applicationDbContext.AuthorTable.Where(x => x.Id == Id).FirstOrDefault();
            if(_author is null)
                return NotFound($"{Id} ye sahip yazar bulunamadı...");

            _author.Name=author.Name;
            _author.Surname=author.Surname;

            applicationDbContext.AuthorTable.Update(_author);
            applicationDbContext.SaveChanges();
            return Ok(_author);
        }

        [HttpDelete("DeleteAuthor")]
        public IActionResult DeleteAuthor([FromBody] int Id)
        {
            var _author = applicationDbContext.AuthorTable.Where(x => x.Id == Id).FirstOrDefault();
            if (_author is null)
                return NotFound($"{Id} ye sahip yazar bulunamadı...");

            applicationDbContext.AuthorTable.Remove(_author);

            return Ok($"{Id} numaralı yazar silindi...");
        }

    }
}
