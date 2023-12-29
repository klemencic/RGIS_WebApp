using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RGIS_WebApp.Pages
{
    public class RegisterOknoModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string ConfirmPassword { get; set; }

        [BindProperty]
        public string Email { get; set; }


        public void OnGet()
        {
        }


        public IActionResult OnPostRegister()
        {
            if (ModelState.IsValid)
            {
                System.Console.WriteLine($"Username: {Username}, Password: {Password}");
                Uporabnik uporabnik = new Uporabnik(Username, Password, Email);
            }

            return Page();
        }
    }
}
