﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5OnlineTicariOtomasyon.Models.Classes;

namespace MVC5OnlineTicariOtomasyon.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        Context c= new Context();
        public ActionResult Index()
        {
            var degerler = c.SatisHarekets.ToList();    
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniSatis()
        {
            List<SelectListItem> deger1 = (from x in c.Uruns.ToList()
                                           select new SelectListItem
                                          {
                                              Text= x.UrunAd,
                                              Value= x.Urunid.ToString()

                                          }).ToList();
            List<SelectListItem> deger2 = (from x in c.Caris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CariAd+" "+x.CariSoyad,
                                               Value = x.CariId.ToString()

                                           }).ToList();
            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.PersonelAd+" "+x.PersonelSoyad,
                                               Value = x.PersonelId.ToString()

                                           }).ToList();
            ViewBag.dgr1 = deger1;
            ViewBag.dgr3 = deger3;
            ViewBag.dgr2=deger2;
            return View();
        }

        [HttpPost]

        public ActionResult YeniSatis (SatisHareket s)
        {
            s.Tarih= DateTime.Parse(DateTime.Now.ToString());   
            c.SatisHarekets.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");   

        }
    }
}