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
                Database database = new Database();

                Uporabnik uporabnik = new Uporabnik();
              uporabnik.Username = Username;
              uporabnik.Geslo = Password;
                uporabnik.Email = Email;
                uporabnik.IsModerator = false;
                uporabnik.IsPremium = false;

                if (!database.ObjectExists(Username)){

                    database.UporabnikDB.Add(uporabnik);
                    database.SaveChanges();
                    return RedirectToPage("/Index");
                }
                else { throw new Exception("Uporabnik že obstaja!"); }
            }

            return Page();
        }
    }
}
