using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mi_pasteleria.Pages.Catalogue
{
    public class QuoteModel : PageModel
    {
        public void OnGet(string selected)
        {
            ViewData["PastelSeleccionado"] = selected;
        }

        public IActionResult OnPostPayment()
        {
            return RedirectToPage("/Catalogue/Payment");
        }
    }
}
