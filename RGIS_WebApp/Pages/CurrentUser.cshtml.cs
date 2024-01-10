using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace RGIS_WebApp.Pages
{
    public class CurrentUserModel : PageModel
    {
        public Uporabnik loggedUser { get; set; }

        

        public void OnGet()
        {
            var json = TempData.Peek("ObjectData") as string;
            Console.WriteLine(json);
            if (!string.IsNullOrEmpty(json))
            {
                loggedUser = JsonSerializer.Deserialize<Uporabnik>(json);
            }
            loggedUser ??= new Uporabnik { Username = "DefaultUsername" };
            System.Diagnostics.Debug.WriteLine($"OnGet - Username: {loggedUser.Username}");

            TempData["CurrentUserData"] = JsonSerializer.Serialize(loggedUser); 

            

        }

        public IActionResult SendDataToLeaderBoard() { 
            return RedirectToPage("/Leaderboard", new { area = "", username = loggedUser.Username });
        }

       


       

    }
}
