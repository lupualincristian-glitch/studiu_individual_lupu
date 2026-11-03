using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AplicatieWeb.Data;
using AplicatieWeb.Models;

namespace AplicatieWeb.Controllers
{
    public class RezultateController : Controller
    {
        private readonly AplicatieDbContext _context;

        public RezultateController(AplicatieDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string text)
        {
            List<Rezultat> toate = _context.Rezultate.ToList();
            List<Rezultat> filtrate = new List<Rezultat>();

            if (!string.IsNullOrEmpty(text))
            {
                foreach (Rezultat r in toate)
                {
                    if (r.NumeSportiv != null && r.NumeSportiv.ToLower().Contains(text.ToLower()))
                    {
                        filtrate.Add(r);
                    }
                }
            }
            else
            {
                filtrate = toate;
            }

            ViewBag.TextCautat = text;
            return View(filtrate);
        }

        public IActionResult Detalii(int id)
        {
            Rezultat? rezultat = _context.Rezultate.Find(id);
            if (rezultat == null)
            {
                return NotFound();
            }
            return View(rezultat);
        }

        public IActionResult Adauga()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Adauga(Rezultat rezultat)
        {
            if (ModelState.IsValid)
            {
                _context.Rezultate.Add(rezultat);
                _context.SaveChanges();
                TempData["Mesaj"] = "Rezultatul a fost adăugat cu succes!";
                return RedirectToAction(nameof(Index));
            }
            return View(rezultat);
        }

        public IActionResult Editeaza(int id)
        {
            Rezultat? rezultat = _context.Rezultate.Find(id);
            if (rezultat == null)
            {
                return NotFound();
            }
            return View(rezultat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editeaza(Rezultat rezultat)
        {
            if (ModelState.IsValid)
            {
                _context.Rezultate.Update(rezultat);
                _context.SaveChanges();
                TempData["Mesaj"] = "Rezultatul a fost modificat!";
                return RedirectToAction(nameof(Index));
            }
            return View(rezultat);
        }

        public IActionResult Sterge(int id)
        {
            Rezultat? rezultat = _context.Rezultate.Find(id);
            if (rezultat == null)
            {
                return NotFound();
            }
            return View(rezultat);
        }

        [HttpPost, ActionName("Sterge")]
        [ValidateAntiForgeryToken]
        public IActionResult StergeConfirmat(int id)
        {
            Rezultat? rezultat = _context.Rezultate.Find(id);
            if (rezultat != null)
            {
                _context.Rezultate.Remove(rezultat);
                _context.SaveChanges();
                TempData["Mesaj"] = "Rezultatul a fost șters!";
            }
            return RedirectToAction(nameof(Index));
        }
    }
}