using ClassDiagramCODScout;
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
                Database db = new Database();
                Uporabnik uporabnik = new Uporabnik();
                uporabnik.Username = Username;
                uporabnik.Geslo = Password;

                if(db.ObjectExists(Username) && db.PasswordMatch(Password))
                {

                }
            }

            return Page();
        }
    }}
