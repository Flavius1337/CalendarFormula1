using CalendarFormula1.Data;
using CalendarFormula1.Data.Services;
using CalendarFormula1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarFormula1.Controllers
{
    public class PilotiiController : Controller
    {
        private readonly IPilotiiService _service;

        public PilotiiController(IPilotiiService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Piloti/create
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create([Bind("NumePilot,ProfilePictureURL,NumarPilot,Echipa")] Piloti piloti)
        {
            if (!ModelState.IsValid)
            {
                return View(piloti);
            }
            await _service.AddAsync(piloti);
            return RedirectToAction(nameof(Index));
        }
        //detalii



        public async Task<IActionResult> Edit(int id)
        {
            var pilotiiDetails = await _service.GetByIdAsync(id);
            if (pilotiiDetails == null) return View("Not Found");
            return View(pilotiiDetails);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumePilot,ProfilePictureURL,NumarPilot,Echipa")] Piloti piloti)
        {
            if (!ModelState.IsValid)
            {
                return View(piloti);
            }
            await _service.UpdateAsync(id, piloti);
            return RedirectToAction(nameof(Index));
        }

        //delete

        public async Task<IActionResult> Delete(int id)
        {
            var pilotiiDetails = await _service.GetByIdAsync(id);

            if (pilotiiDetails == null) return View("Not Found");
            return View(pilotiiDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pilotiDetails = await _service.GetByIdAsync(id);
            if (pilotiDetails == null) return View("Not Found");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}
