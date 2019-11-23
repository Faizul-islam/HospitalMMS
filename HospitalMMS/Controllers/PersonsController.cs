using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalMMS.Data;
using HospitalMMS.Modules.PersonModels.Models;

namespace HospitalMMS.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonRepository _context;

        public PersonsController(IPersonRepository context)
        {
            _context = context;
        }

        // GET: Persons
        public ViewResult Index()
        {
            var model = _context.GetAllPerson();
            return View(model);
        }

        //// GET: Persons/Details/5
        //public async Task<IActionResult> Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var person = await _context.Person
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(person);
        //}

        //// GET: Persons/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Persons/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,PersonName,PhoneNo,Email,BirthDate,Gender,PresentAddress,PermanentAddress,PhotoPath,IUser,IDate,EUsaer,EDate")] Person person)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(person);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(person);
        //}

        //// GET: Persons/Edit/5
        //public async Task<IActionResult> Edit(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var person = await _context.Person.FindAsync(id);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(person);
        //}

        //// POST: Persons/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(long id, [Bind("Id,PersonName,PhoneNo,Email,BirthDate,Gender,PresentAddress,PermanentAddress,PhotoPath,IUser,IDate,EUsaer,EDate")] Person person)
        //{
        //    if (id != person.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(person);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PersonExists(person.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(person);
        //}

        //// GET: Persons/Delete/5
        //public async Task<IActionResult> Delete(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var person = await _context.Person
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(person);
        //}

        //// POST: Persons/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(long id)
        //{
        //    var person = await _context.Person.FindAsync(id);
        //    _context.Person.Remove(person);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PersonExists(long id)
        //{
        //    return _context.Person.Any(e => e.Id == id);
        //}
    }
}
