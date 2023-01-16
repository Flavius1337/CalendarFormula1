using CalendarFormula1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarFormula1.Data.Services
{
    public class PilotiiService : IPilotiiService
    {
        private readonly AppDbContext _context;
        public PilotiiService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Piloti piloti)
        {
            await _context.Pilotii.AddAsync(piloti);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Pilotii.FirstOrDefaultAsync(n => n.Id == id);
            _context.Pilotii.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Piloti>> GetAllAsync()
        {
            var result = await _context.Pilotii.ToListAsync();
            return result;
        }

        public async Task<Piloti> GetByIdAsync(int id)
        {
            var result = await _context.Pilotii.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Piloti> UpdateAsync(int id, Piloti newPiloti)
        {
            _context.Update(newPiloti);
            await _context.SaveChangesAsync();
            return newPiloti;
        }
    }
}
