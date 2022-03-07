using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mi_pasteleria.Pages.Catalogue
{
    public class PaymentModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostOrdered()
        {
            return RedirectToPage("/Catalogue/Ordered");
        }
    }
}
