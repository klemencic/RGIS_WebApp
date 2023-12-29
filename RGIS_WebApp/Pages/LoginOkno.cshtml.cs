using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace RGIS_WebApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPostLogin()
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                Uporabnik uporabnik = new Uporabnik
                {
                    Username = Username,
                    Geslo = Password
                };

                if (db.ObjectExists(Username) && db.PasswordMatch(Password))
                {
                    uporabnik = db.UporabnikDB.FirstOrDefault(u => u.Username == Username);


                    // Serialize Uporabnik object to JSON and store it in TempData
                    TempData["ObjectData"] = JsonSerializer.Serialize(uporabnik);

                    return RedirectToPage("/CurrentUser", new { area = "", username = uporabnik.Username });
                }
            }

            return Page();
        }
    }
}
