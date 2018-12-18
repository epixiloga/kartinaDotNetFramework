using Kartina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kartina.Controllers
{
    public class VendeurController : Controller
    {
        // GET: Vendeur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            Vendeur vendeur = new Vendeur();
            using (Models.KartinaDotNetFrameworkEntities1 context=new KartinaDotNetFrameworkEntities1())
            {
                //var query = from item in context.Vendeur
                //            where item.Id == id
                //            select item;

                vendeur = context.Vendeur.First(item => item.Id == id);
            }
            this.ViewBag.MonVendeur = vendeur;
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
    }
}