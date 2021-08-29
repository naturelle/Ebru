using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TesislerDairesi.Data;
using TesislerDairesi.Models;

namespace TesislerDairesi.Controllers
{
    public class AirsModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AirsModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AirsModels
        public async Task<IActionResult> Index()
        {
            //veya 
            //IEnumerable<AirsModel> objList = _context.AirsModel;
            // return View(objList);

            return View(await _context.AirsModel.ToListAsync());
        }

        // GET: AirsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airsModel = await _context.AirsModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airsModel == null)
            {
                return NotFound();
            }

            return View(airsModel);
        }

        // GET: AirsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AirsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Title,Body,Category,Relevant")] AirsModel airsModel)
        {
            //checks if all of the rules defined in the model are valid
            if (ModelState.IsValid)
            {
                _context.Add(airsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airsModel);
        }

        // GET: AirsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airsModel = await _context.AirsModel.FindAsync(id);
            if (airsModel == null)
            {
                return NotFound();
            }
            return View(airsModel);
        }

        // POST: AirsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Title,Body,Category,Relevant")] AirsModel airsModel)
        {
            if (id != airsModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirsModelExists(airsModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(airsModel);
        }

        // GET: AirsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airsModel = await _context.AirsModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airsModel == null)
            {
                return NotFound();
            }

            return View(airsModel);
        }

        // POST: AirsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var airsModel = await _context.AirsModel.FindAsync(id);
            _context.AirsModel.Remove(airsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirsModelExists(int id)
        {
            return _context.AirsModel.Any(e => e.Id == id);
        }
    }
}
