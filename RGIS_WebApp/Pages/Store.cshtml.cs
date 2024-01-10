using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace RGIS_WebApp.Pages
{
    public class StoreModel : PageModel
    {
        public Uporabnik loggedUser { get; set; }
        public void OnGet()
        {
            var json = TempData.Peek("CurrentUserData") as string;

            if (!string.IsNullOrEmpty(json))
            {
                loggedUser = JsonSerializer.Deserialize<Uporabnik>(json);
            }

        }

        public IActionResult OnPostStore()
        {
            OnGet();

            Uporabnik uporabnik = new Uporabnik();
            
            Database db = new Database();

            if (db.ObjectExists(loggedUser.Username)){

                uporabnik = db.UporabnikDB.FirstOrDefault(u => u.Username == loggedUser.Username);

                uporabnik.IsPremium = true;

                db.UporabnikDB.Update(uporabnik);
            }

            db.SaveChanges();

            return RedirectToPage("/CurrentUser");








        }
    }
}
