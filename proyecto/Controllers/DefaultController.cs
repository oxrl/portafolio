using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto.Controllers
{
    public class DefaultController : Controller
    {
        private TablaDato tabladato = new TablaDato();
        public int Index()
        {
            return tabladato.Conteo();
        }
    }
}