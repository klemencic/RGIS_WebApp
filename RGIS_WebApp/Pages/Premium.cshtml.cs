using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS_WebApp.Pages
{
    public class PremiumModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult getPremium()
        {
            return RedirectToPage("/Premium");
        }
    }
}
