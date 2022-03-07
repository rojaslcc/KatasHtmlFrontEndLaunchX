using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mi_pasteleria.Pages.Make
{
    public class QuoteModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostPayment()
        {
            return RedirectToPage("/Make/Payment");
        }
    }
}
