using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mi_pasteleria.Pages.Catalogue
{
    public class ComplementModel : PageModel
    {
        public void OnGet(int id)
        {
            switch (id)
            {
                case 1:
                    ViewData["PastelSeleccionado"] = "Tentación de mango";
                    break;
                case 2:
                    ViewData["PastelSeleccionado"] = "Tentación de fresa";
                    break;
                case 3:
                    ViewData["PastelSeleccionado"] = "Tentación de mango-fresa";
                    break;
                case 4:
                    ViewData["PastelSeleccionado"] = "Tentación de Nutella®";
                    break;
                case 5:
                    ViewData["PastelSeleccionado"] = "Nevado de fresa";
                    break;
                case 6:
                    ViewData["PastelSeleccionado"] = "Nevado de nuez";
                    break;
                case 7:
                    ViewData["PastelSeleccionado"] = "Nevado MilkyWay®";
                    break;
                case 8:
                    ViewData["PastelSeleccionado"] = "Nevado Oreo®";
                    break;
                case 9:
                    ViewData["PastelSeleccionado"] = "Chocolate tortuga";
                    break;
                case 10:
                    ViewData["PastelSeleccionado"] = "Chocolate alemán";
                    break;
                case 11:
                    ViewData["PastelSeleccionado"] = "Chocolate bombon";
                    break;
                case 12:
                    ViewData["PastelSeleccionado"] = "Chocolate Carlos V®";
                    break;
            }
        }

        public IActionResult OnPostQuote(string selected)
        {
            return RedirectToPage("/Catalogue/Quote", new
            {
                selected = selected
            });
        }
    }
}
