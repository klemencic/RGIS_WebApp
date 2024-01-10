using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;
using System.Text.Json;


namespace RGIS_WebApp.Pages
{
    public class LeaderboardModel : PageModel
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
    }
}
