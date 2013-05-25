using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Office.Interop.Word;

namespace MathEquationsViaWord.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string eq)
        {
            if (string.IsNullOrWhiteSpace(eq)) 
            {
                return Redirect("/E=MC^2");
            }

            using (var fic = new FormulaImageConverter(new Application()))
            {
                var bytes = fic.ConvertFormulaToImage(eq);
                return File(bytes, "image/png"); ;
            }
        }
    }
}