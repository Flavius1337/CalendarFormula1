using CalendarFormula1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Threading.Tasks;


namespace CalendarFormula1.Controllers
{
    public class CursaaController : Controller
    {
        private readonly AppDbContext _context;

        public CursaaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCursaa = await _context.Cursaa.ToListAsync();
            return View(allCursaa);
        }
    }
}
