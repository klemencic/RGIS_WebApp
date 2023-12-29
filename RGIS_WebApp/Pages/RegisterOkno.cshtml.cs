using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

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
                Random random = new Random();
                Uporabnik uporabnik = new Uporabnik();
              uporabnik.Username = Username;
              uporabnik.Geslo = Password;
                uporabnik.Email = Email;
                uporabnik.IsModerator = false;
                uporabnik.IsPremium = false;
                uporabnik.Wins = random.Next(0, 30); 
                uporabnik.Kills = random.Next(0, 100);
                uporabnik.Deaths = random.Next(0, 100);
                uporabnik.Matches = random.Next(0, 30);
                uporabnik.Assists = random.Next(0, 100);
                uporabnik.KDR = random.NextDouble() * 10.0;
                uporabnik.Losses = random.Next(0, 30);



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
