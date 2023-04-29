
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssistControl.Shared.Entities;
using AssistControl.API.Data;

namespace AssistControl.API.Controllers
{
    [ApiController]
    [Route("/api/tickets")]
    public class CategoriesController : ControllerBase
    {

        private readonly DataContext _context;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var ticket = await _context.Tickets.FirstOrDefaultAsync(ticket => ticket.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }
            return Ok(ticket);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Ticket ticket)
        {
            try
            {
                _context.Update(ticket);
                await _context.SaveChangesAsync();
                return Ok(ticket);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest($"Ya existe una entrada con el id: {ticket.Id}");
                }
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




    }



}
