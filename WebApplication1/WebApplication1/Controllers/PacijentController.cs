using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.VM;

namespace WebApplication1.Controllers
{
    public class PacijentController : Controller
    {
        private readonly ApplicationDbContext db;

        public PacijentController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<Spol> DobavljanjeSortiranihSpolova()
        {
            List<Spol> spol = db.Spol.AsQueryable().ToList();

            return db.Spol.OrderBy(a => a.Naziv).ToList();
        }

        public IActionResult Prikaz()
        {
            List<PacijentPrikazVM> pacijenti = db.Pacijent.Include(a => a.spol).Select(x => new PacijentPrikazVM
            {
                Adresa=x.Adresa,
                spol=x.spol,
                BrojTelefona=x.BrojTelefona,
                PacijentID=x.PacijentID,
                DatumRodjenja=x.DatumRodjenja,
                Ime=x.Ime,
                Prezime=x.Prezime
            }).ToList();

            lista_PacijentPrikazVM model = new lista_PacijentPrikazVM
            {
                lista = pacijenti
            };

            return View(model);
        }

        public IActionResult Unos()
        {
            List<Spol>spol = db.Spol.AsQueryable().ToList();

            ViewData["spol"] = DobavljanjeSortiranihSpolova();

            return View();
        }

        public IActionResult UnosSnimi(string ime, string prezime, DateTime datum_rodjenja, int spol, string adresa, string telefon)
        {
            Pacijent p = new Pacijent
            {
                Adresa = adresa,
                BrojTelefona = telefon,
                spol_FK = spol,
                DatumRodjenja = datum_rodjenja,
                Ime = ime,
                spol = db.Spol.Where(a => a.SpolID == spol).FirstOrDefault(),
                Prezime = prezime
            };

            db.Pacijent.Add(p);
            db.SaveChanges();

            return Redirect("/Pacijent/Prikaz");
        }

        public IActionResult Uredi(int id)
        {
            ViewData["pacijent"] = db.Pacijent.Where(a => a.PacijentID == id).Include(a => a.spol).Select(x => new Pacijent
            {
                Adresa = x.Adresa,
                BrojTelefona = x.BrojTelefona,
                DatumRodjenja = x.DatumRodjenja,
                Ime = x.Ime,
                PacijentID = x.PacijentID,
                Prezime = x.Prezime,
                spol = x.spol,
                spol_FK = x.spol_FK
            }).FirstOrDefault();

            ViewData["spol"] = DobavljanjeSortiranihSpolova();

            return View();
        }

        public IActionResult UrediSnimi(int id, string ime, string prezime, DateTime datum_rodjenja, int spol, string adresa, string telefon)
        {
            Pacijent p = db.Pacijent.Where(a => a.PacijentID == id).FirstOrDefault();

            if (p != null) {

                p.Ime = ime;
                p.Prezime = prezime;
                p.DatumRodjenja = datum_rodjenja;
                p.spol_FK = spol;
                p.spol = db.Spol.Where(a => a.SpolID == spol).FirstOrDefault();
                p.Adresa = adresa;
                p.BrojTelefona = telefon;

                db.SaveChanges();
            }

            return Redirect("/Pacijent/Prikaz");
        }

        public IActionResult Ukloni(int id)
        {
            Pacijent p = db.Pacijent.Where(a => a.PacijentID == id).FirstOrDefault();

            if (p != null)
            {
                db.Remove(p);
                db.SaveChanges();
            }

            return Redirect("/Pacijent/Prikaz");
        }
    }
}
