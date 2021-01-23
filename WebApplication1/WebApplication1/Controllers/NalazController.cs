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
    public class NalazController : Controller
    {
        private readonly ApplicationDbContext db;

        public NalazController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Prikaz(int id)
        {
            Nalaz nalaz = db.Nalaz.Where(a => a.prijem_FK == id).FirstOrDefault();

            if (nalaz == null)
                return Redirect("/Nalaz/Unos?id="+id);

            NalazPrikazVM model = db.Nalaz.Include(a=>a.prijem.pacijent).Where(a => a.prijem_FK == id).Select(x => new NalazPrikazVM
            {
              datum_reiranja=x.Datum_Vrijeme_Kreiranja,
              opis=x.Opis,
              pacijent=x.prijem.pacijent,
              prijem=x.prijem
            }).FirstOrDefault();

            return View(model);
        }

        public IActionResult Unos(int id)
        {
            Prijem p = db.Prijem.Where(a => a.PrijemID == id).Include(a => a.pacijent).Include(a => a.ljekar).Select(x => new Prijem
            {
                Datum_Vrijeme=x.Datum_Vrijeme,
                ljekar=x.ljekar,
                Hitni_Prijem=x.Hitni_Prijem,
                pacijent=x.pacijent,
                PrijemID=x.PrijemID
            }).FirstOrDefault();

            ViewData["prijem"] = p;

            return PartialView();
        }

        public IActionResult UnosSnimi(Nalaz p)
        {
            p.Datum_Vrijeme_Kreiranja = DateTime.Now;

            db.Add(p);

            db.SaveChanges();

            return Redirect("/Prijem/Prikaz");
        }
    }
}
