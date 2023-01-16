using CalendarFormula1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Threading.Tasks;


namespace CalendarFormula1.Controllers
{
    public class TaraaController : Controller
    {
        private readonly AppDbContext _context;

        public TaraaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allTaraa = await _context.Taraa.ToListAsync();
            return View(allTaraa);
        }  
    }
}
