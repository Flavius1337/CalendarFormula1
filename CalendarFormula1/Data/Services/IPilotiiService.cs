using CalendarFormula1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalendarFormula1.Data.Services
{
    public interface IPilotiiService
    {
        Task<IEnumerable<Piloti>> GetAllAsync();
        Task<Piloti> GetByIdAsync(int id);
        Task AddAsync(Piloti piloti);
        Task<Piloti> UpdateAsync(int id, Piloti newPiloti);
        Task DeleteAsync(int id);
    }
}
