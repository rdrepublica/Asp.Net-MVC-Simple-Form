using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DatosPersonales()
        {
            Form modelo = new Form();
            modelo.Name = Request.Form["Name"].ToString();
            modelo.Cedula = Request.Form["Cedula"].ToString();
            modelo.Age = int.Parse(Request.Form["age"]);
            modelo.Tel = Request.Form["Tel"].ToString();
            modelo.Email = Request.Form["Email"].ToString();
            modelo.Gender = Request.Form["Gender"].ToString();
            modelo.Last = Request.Form["Last"].ToString();
            modelo.CivilStatus = "Casado";
            String Hobbys = "";
            if (modelo.Hobbys == true)
            {
                Hobbys = "No Tengo Hobbys";
            }

            Hobbys = "Si Tengo Hobbys";
            modelo.HobbieDefinitivo = Hobbys;

            return View(modelo);
        }

    }
}