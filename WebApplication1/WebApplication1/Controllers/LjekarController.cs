using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LjekarController : Controller
    {
        private readonly ApplicationDbContext db;

        public LjekarController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<Titula> DobavaljanjeSortiranihTitula()
        {
            List<Titula> titule = db.Titula.AsQueryable().ToList();

            return titule.OrderBy(a => a.Naziv).ToList();
        }

        public IActionResult Prikaz()
        {
            List<Ljekar> ljekari = db.Ljekar.Include(a => a.titula).Select(x => new Ljekar
            {
                Ime=x.Ime,
                titula=x.titula,
                LjekarID=x.LjekarID,
                Prezime=x.Prezime,
                Sifra=x.Sifra
            }).ToList();


            ViewData["ljekari"] = ljekari;

            return View();
        }

        public IActionResult Unos()
        {
            ViewData["titule"] = DobavaljanjeSortiranihTitula();

            return View();
        }

        public IActionResult UnosSnimi(Ljekar temp)
        {
            db.Ljekar.Add(temp);
            db.SaveChanges();

            return Redirect("/Ljekar/Prikaz");
        }

        public IActionResult Uredi(int id)
        {
            ViewData["titule"] = DobavaljanjeSortiranihTitula();

            Ljekar temp = db.Ljekar.Where(a => a.LjekarID == id).Include(a=>a.titula).Select(x=>new Ljekar { 
                titula=x.titula,
                titula_FK=x.titula_FK,
                Ime=x.Ime,
                LjekarID=x.LjekarID,
                Prezime=x.Prezime,
                Sifra=x.Sifra
            }).FirstOrDefault();

            ViewData["ljekar"] = temp;

            return View();
        }

        public IActionResult UrediSnimi(Ljekar temp)
        {
            Ljekar t = db.Ljekar.Where(a => a.LjekarID == temp.LjekarID).FirstOrDefault();
            t.Ime = temp.Ime;
            t.Prezime = temp.Prezime;
            t.Sifra = temp.Prezime;
            t.titula_FK = temp.titula_FK;

            db.SaveChanges();

            return Redirect("/Ljekar/Prikaz");
        }

        public IActionResult Ukloni(int id)
        {
            Ljekar t = db.Ljekar.Where(a => a.LjekarID == id).FirstOrDefault();

            if (t != null)
            {
                db.Remove(t);
                db.SaveChanges();
            }
            return Redirect("/Ljekar/Prikaz");
        }
    }
}