using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RGIS_WebApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        
        public void OnGet()
        {
        }

        public IActionResult OnPostLogin()
        {
            if (ModelState.IsValid)
            {
                System.Console.WriteLine($"Username: {Username}, Password: {Password}");
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }}
