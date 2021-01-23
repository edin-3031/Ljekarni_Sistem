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
    public class PrijemController : Controller
    {
        private readonly ApplicationDbContext db;

        public PrijemController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Prikaz(DateTime? OD, DateTime? DO)
        {
            lista_prijemPrikazVM model = new lista_prijemPrikazVM();

            if ((OD == null && DO == null) || OD == null || DO == null)
            {
                List<prijemPrikazVM> prijemi = db.Prijem.Include(a => a.ljekar).Include(a => a.pacijent).AsQueryable().Select(x => new prijemPrikazVM
                {
                    Datum_Vrijeme = x.Datum_Vrijeme,
                    Hitni_Prijem = x.Hitni_Prijem,
                    ljekar = x.ljekar,
                    pacijent = x.pacijent,
                    PrijemID = x.PrijemID
                }).ToList();

                model.lista = prijemi.OrderBy(a => a.Datum_Vrijeme.Date).ToList();
            }
            else
            {
                List<prijemPrikazVM> prijemi = db.Prijem.Include(a => a.ljekar).Include(a => a.pacijent).AsQueryable().Where(a=>a.Datum_Vrijeme.Date>=OD.Value && a.Datum_Vrijeme.Date<=DO.Value).Select(x => new prijemPrikazVM
                {
                    Datum_Vrijeme = x.Datum_Vrijeme,
                    Hitni_Prijem = x.Hitni_Prijem,
                    ljekar = x.ljekar,
                    pacijent = x.pacijent,
                    PrijemID = x.PrijemID
                }).ToList();

                model.lista = prijemi.OrderBy(a => a.Datum_Vrijeme.Date).ToList();
            }
            return View(model);
        }

        public List<Ljekar> DobavljanjeLjekaraSpecijaistaSortirano()
        {
            return db.Ljekar.AsQueryable().Include(a => a.titula).Where(a => a.titula.Naziv == "specijalista").Select(x => new Ljekar
            {
                Ime = x.Ime,
                Prezime = x.Prezime,
                LjekarID = x.LjekarID,
                titula = x.titula,
                Sifra = x.Sifra
            }).OrderBy(a => a.Ime).ToList();
        }

        public List<Pacijent> DobavljanjePacijenataSortirano()
        {
            return db.Pacijent.AsQueryable().Select(x => new Pacijent
            {
                Ime = x.Ime,
                Prezime = x.Prezime,
                PacijentID = x.PacijentID
            }).OrderBy(a => a.Ime).ToList();

        }

        public IActionResult Unos()
        {
            ViewData["pacijenti"] = DobavljanjePacijenataSortirano();
            ViewData["ljekari"] = DobavljanjeLjekaraSpecijaistaSortirano();
            
            return View();
        }

        public IActionResult UnosSnimi(Prijem prijem)
        {
            db.Prijem.Add(prijem);
            db.SaveChanges();

            return Redirect("/Prijem/Prikaz");
        }

        public IActionResult Otkazi(int id)
        {
            Prijem temp = db.Prijem.Where(a => a.PrijemID == id).FirstOrDefault();

            if (temp != null)
            {
                db.Remove(temp);
                db.SaveChanges();
            }
            return Redirect("/Prijem/Prikaz");
        }

        public IActionResult Izmijeni(int id)
        {
            ViewData["prijem"] = db.Prijem.Where(a => a.PrijemID == id).Include(a => a.ljekar).Include(a => a.pacijent).Select(x => new Prijem
            {
                Datum_Vrijeme=x.Datum_Vrijeme,
                pacijent=x.pacijent,
                ljekar=x.ljekar,
                Hitni_Prijem=x.Hitni_Prijem,
                PrijemID=x.PrijemID

            }).FirstOrDefault();

            ViewData["pacijenti"] = DobavljanjePacijenataSortirano();
            ViewData["ljekari"] = DobavljanjeLjekaraSpecijaistaSortirano();

            return View();
        }

        public IActionResult IzmijeniSnimi(Prijem p)
        {
            Prijem temp = db.Prijem.Where(a => a.PrijemID == p.PrijemID).FirstOrDefault();

            temp.Hitni_Prijem = p.Hitni_Prijem;
            temp.Datum_Vrijeme = p.Datum_Vrijeme;
            temp.ljekar_FK = p.ljekar_FK;
            temp.pacijent_FK = p.pacijent_FK;

            db.SaveChanges();

            return Redirect("/Prijem/Prikaz");
        }
    }
}
