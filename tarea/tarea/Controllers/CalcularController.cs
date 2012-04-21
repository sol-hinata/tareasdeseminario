using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tarea.Models;

namespace tarea.Controllers
{
    public class CalcularController : Controller
    {
        //
        // GET: /Calcular/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sumar()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Sumar(Calcular operador)
        {
            this.ViewBag.resultado = (operador.a+operador.b);
            return this.View();
        }
       public ActionResult Restar()
       {
           return View();
       }
       [HttpPost]
        public ActionResult Restar(Calcular operador)
        {
            this.ViewBag.resultado =(operador.a-operador.b); 
            return this.View();
        }
       public ActionResult Multiplicar()
       {
           return View();
       }
       [HttpPost]
        public ActionResult Multiplicar(Calcular operador)
        {
            this.ViewBag.resultado = (operador.a*operador.b);
            return this.View();
        }
       public ActionResult Dividir()
       {
           return View();
       }
       [HttpPost]   
        public ActionResult Dividir(Calcular operador)
        {

            if (operador.b == 0)
            {
                this.ViewBag.resultado = "indeterminado";
                return this.View();
            }
            else
            {
                float r = (operador.a / operador.b);
                ViewBag.resultado = r;
                return this.View();
            }
        }
    
    }
}
