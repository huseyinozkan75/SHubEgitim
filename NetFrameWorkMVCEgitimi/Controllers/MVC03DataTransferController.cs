using NetFrameWorkMVCEgitimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFrameWorkMVCEgitimi.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        // GET: MVC03DataTransfer
        public ActionResult Index()
        {
            // 3 Farklı Yöntemle Controllerdan View a Basit Veriler Gönderebiliriz. 

            // 1-ViewBag : Tek Kullanımlık ömrü vardır.
            ViewBag.UrunKategorisi = "Bilgisayar"; // Burada Viewbag ismi standart olarak
                                                   // yazılır sonrasında . deyip dileiğimiz değişken
                                                   // adını yazabiliriz.

            // 2-ViewData = Tek kullanımlık ömrü vardır.
            // 
            var urunListesi = new List<Urun>()
            {
                new Urun() { Adi = "Oyun Bilgisayari", Fiyati = 49000, Stok = 5 },
                new Urun() { Adi = "Laptop", Fiyati = 29000, Stok = 7 },
                new Urun() { Adi = "İş İstasyonu", Fiyati = 99000, Stok = 3 }
            };

            ViewData["Urunler"] = urunListesi;

            // 3-TempData : 2 kullanımlık ömrü vardır.
            TempData["UrunBilgi"] = "Toplam" + urunListesi.Count + " Ürün Bulundu..";

            return View();
        }

        [HttpGet] // attribute : Dikkat bir metodun üzerinde attribute yokse varsayılen tür GET dir.
        public ActionResult Search(string txtAra)
        {
            ViewBag.GetVerisi = txtAra; // querystring deki txtAra yapısının değerini getir.
            return View();
        }


        [HttpPost] // attribute
        public ActionResult Index(string txtUrunAdi, string ddlKategori, 
            bool cbOnay, string rbOnay, FormCollection formCollection)
        {
            var urunListesi = new List<Urun>()
            {
                new Urun() { Adi = "Oyun Bilgisayari", Fiyati = 49000, Stok = 5 },
                new Urun() { Adi = "Laptop", Fiyati = 29000, Stok = 7 },
                new Urun() { Adi = "İş İstasyonu", Fiyati = 99000, Stok = 3 }
            };

            ViewData["Urunler"] = urunListesi;

            ViewBag.Baslik1 = "1. yöntem parametreyle veri yakalama";
            ViewBag.Mesaj1 = "TextBox değeri: " + txtUrunAdi;
            ViewBag.Mesaj2 = "Dropdown değeri: " + ddlKategori;
            ViewBag.Mesaj3 = "cbOnay değeri: " + cbOnay;
            ViewBag.Mesaj4 = "rbOnay değeri: " + rbOnay;


            ViewBag.Baslik2 = "2. yöntem FormCollection ile yakalama";
            ViewBag.Mesaj5 = "TextBox değeri: " + formCollection["txtUrunAdi"];
            ViewBag.Mesaj6 = "Dropdown değeri: " + formCollection["ddlKategori"];
            ViewBag.Mesaj7 = "cbOnay değeri: " + formCollection.GetValues("cbOnay")[0];
            ViewBag.Mesaj8 = "rbOnay değeri: " + formCollection.GetValues("rbOnay")[0];


            ViewBag.Baslik3 = "2. yöntem Request Form ile yakalama";
            ViewBag.Mesaj9 = "TextBox değeri: " + Request.Form["txtUrunAdi"];
            ViewBag.Mesaj10 = "Dropdown değeri: " + Request.Form["ddlKategori"];
            ViewBag.Mesaj11 = "cbOnay değeri: " + Request.Form.GetValues("cbOnay")[0];
            ViewBag.Mesaj12 = "rbOnay değeri: " + Request.Form.GetValues("rbOnay")[0];

            return View();
        }
    }
}