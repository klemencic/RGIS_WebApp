using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            // Initialize loggedUser to a default instance if it's null
            loggedUser ??= new Uporabnik { Username = "DefaultUsername" };
            System.Diagnostics.Debug.WriteLine($"OnGet - Username: {loggedUser.Username}");

            // Your existing logic, if any
        }
    }
}
