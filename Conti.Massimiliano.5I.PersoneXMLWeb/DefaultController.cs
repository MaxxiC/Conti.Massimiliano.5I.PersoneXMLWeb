using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Conti.Massimiliano._5I.PersoneXMLWeb
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string nomeFile = HostingEnvironment.MapPath(@"~/App_Data/Persone.xml");
            XElement data = XElement.Load(nomeFile);
            var persone = (from l in data.Elements("Persona") select new Persona(l)).ToList();

            return View(persone);
        }
    }
}