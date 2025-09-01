using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.DataContext;
using Service.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroGenerosController : ControllerBase
    {
        private readonly BiblioContext _context;

        public LibroGenerosController(BiblioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LibroGenero>>> GetLibroGeneros()
        {
            return await _context.LibroGeneros.AsNoTracking().Where(lg => !lg.IsDeleted).ToListAsync();
        }

        [HttpGet("deleteds")]
        public async Task<ActionResult<IEnumerable<LibroGenero>>> GetDeletedsLibroGeneros()
        {
            return await _context.LibroGeneros.AsNoTracking().IgnoreQueryFilters().Where(lg => lg.IsDeleted).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LibroGenero>> GetLibroGenero(int id)
        {
            var libroGenero = await _context.LibroGeneros.AsNoTracking().FirstOrDefaultAsync(lg => lg.Id.Equals(id));
            if (libroGenero == null)
            {
                return NotFound();
            }
            return libroGenero;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibroGenero(int id, LibroGenero libroGenero)
        {
            if (id != libroGenero.Id)
            {
                return BadRequest();
            }
            _context.Entry(libroGenero).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroGeneroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<LibroGenero>> PostLibroGenero(LibroGenero libroGenero)
        {
            _context.LibroGeneros.Add(libroGenero);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetLibroGenero", new { id = libroGenero.Id }, libroGenero);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibroGenero(int id)
        {
            var libroGenero = await _context.LibroGeneros.FindAsync(id);
            if (libroGenero == null)
            {
                return NotFound();
            }
            libroGenero.IsDeleted = true;
            _context.LibroGeneros.Update(libroGenero);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("Restore/{id}")]
        public async Task<IActionResult> RestoreLibroGenero(int id)
        {
            var libroGenero = await _context.LibroGeneros.IgnoreQueryFilters().FirstOrDefaultAsync(lg => lg.Id.Equals(id));
            if (libroGenero == null)
            {
                return NotFound();
            }
            libroGenero.IsDeleted = false;
            _context.LibroGeneros.Update(libroGenero);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool LibroGeneroExists(int id)
        {
            return _context.LibroGeneros.Any(e => e.Id == id);
        }
    }
}
