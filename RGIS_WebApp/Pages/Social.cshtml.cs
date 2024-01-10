using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace RGIS_WebApp.Pages
{
    public class SocialModel : PageModel
    {
        public Uporabnik loggedUser { get; set; }
        public List<Uporabnik> Friends
        {
            get
            {
                var json = TempData.Peek("CurrentUserData") as string;
                if (!string.IsNullOrEmpty(json))
                {
                    loggedUser = JsonSerializer.Deserialize<Uporabnik>(json);
                }
                var friendsJson = TempData.Peek($"{loggedUser.Username}friends") as string;
                return string.IsNullOrEmpty(friendsJson)
                    ? new List<Uporabnik>()
                    : JsonSerializer.Deserialize<List<Uporabnik>>(friendsJson);
            }
            set
            {
                TempData[$"{loggedUser.Username}friends"] = JsonSerializer.Serialize(value);
            }
        }
        [BindProperty]
        public string username { get; set; }    

        public void OnGet()
        {
        }

        public IActionResult OnPostAddFriend()
        {
            Database DB = new Database();
            Uporabnik uporabnik = DB.UporabnikDB.FirstOrDefault(u => u.Username == username);

            var existingFriends = Friends;
            existingFriends.Add(uporabnik);
            Friends = existingFriends;

            return RedirectToPage("/Social");

           
        }

    }
}
