using AssistControl.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace AssistControl.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context= context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTickets();
        }
        private async Task CheckTickets()
        {
            if (!_context.Tickets.Any())
            {
                for(int i = 0; i <= 50000; i++)
                {
                    _context.Tickets.Add(new Ticket {Porteria = String.Empty});
                    Console.WriteLine(i);

                }
                await _context.SaveChangesAsync();
            }

        }
    }
}

