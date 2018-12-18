using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kartina.Controllers
{
    public class PhotoController : Controller
    {
        // Requete Get
        public ActionResult Creer()
        {
            return this.View();
        }

        //Requete Post
        [HttpPost]
        public ActionResult Creer(FormCollection dictio)
        {
            if (dictio["Titre"] !=null)
            {
                using (Models.KartinaDotNetFrameworkEntities1 context=new Models.KartinaDotNetFrameworkEntities1())
                {
                    Models.Photo photo = new Models.Photo();
                    photo.Title = dictio["Titre"];
                    photo.IdVendeur = 5;
                    context.Photo.Add(photo);
                    context.SaveChanges();
                }

            }
            return this.View();
        }
    }
}