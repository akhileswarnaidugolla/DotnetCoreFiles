using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToMany.DbContex;
using OneToMany.Models;

namespace OneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public string Get()
        {
            throw new ArithmeticException();
           // return "akhil";
        }

        // GET: api/Author
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Book>>> GetAuthors()
        //{
        //    // Include books in the response
        //    //return await _context.Authors.Include(a => a.Books).ToListAsync();
        //    //return await _context.Authors.ToListAsync();
        //    return await _context.Books.ToListAsync();
        //}

        ////// GET: api/Author/5
        ////[HttpGet("{id}")]
        ////public async Task<ActionResult<Author>> GetAuthor(int id)
        ////{
        ////    var author = await _context.Authors
        ////                               .Include(a => a.Books) // Include books for the author
        ////                               .FirstOrDefaultAsync(a => a.AuthorId == id);

        ////    if (author == null)
        ////    {
        ////        return NotFound();
        ////    }

        ////    return author;
        ////}

        ////// POST: api/Author
        ////[HttpPost]
        ////public async Task<ActionResult<Author>> PostAuthor(Author author)
        ////{
        ////    _context.Authors.Add(author);
        ////    await _context.SaveChangesAsync();

        ////    return Ok("Added Author Successfully");
        ////}

        ////// PUT: api/Author/5
        ////[HttpPut("{id}")]
        ////public async Task<IActionResult> PutAuthor(int id, Author author)
        ////{
        ////    if (id != author.AuthorId)
        ////    {
        ////        return BadRequest();
        ////    }

        ////    _context.Entry(author).State = EntityState.Modified;

        ////    try
        ////    {
        ////        await _context.SaveChangesAsync();
        ////    }
        ////    catch (DbUpdateConcurrencyException)
        ////    {
        ////        if (!_context.Authors.Any(e => e.AuthorId == id))
        ////        {
        ////            return NotFound();
        ////        }
        ////        else
        ////        {
        ////            throw;
        ////        }
        ////    }

        ////    return NoContent();
        ////}

        ////// DELETE: api/Author/5
        ////[HttpDelete("{id}")]
        ////public async Task<IActionResult> DeleteAuthor(int id)
        //{
        //    var author = await _context.Authors.FindAsync(id);
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Authors.Remove(author);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}
    }



}
