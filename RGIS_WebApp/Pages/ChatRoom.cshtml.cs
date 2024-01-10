using ClassDiagramCODScout;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Text.Json;

namespace RGIS_WebApp.Pages
{
    public class ChatRoomModel : PageModel
    {
        public Uporabnik loggedUser { get; set; }
        [BindProperty]
        public string vnos { get; set; }

        public List<Message> Messages
        {
            get
            {
                var messagesJson = TempData.Peek("Messages") as string;
                return string.IsNullOrEmpty(messagesJson)
                    ? new List<Message>()
                    : JsonSerializer.Deserialize<List<Message>>(messagesJson);
            }
            set
            {
                TempData["Messages"] = JsonSerializer.Serialize(value);
            }
        }

        public void OnGet()
        {
            var json = TempData.Peek("CurrentUserData") as string;

            if (!string.IsNullOrEmpty(json))
            {
                loggedUser = JsonSerializer.Deserialize<Uporabnik>(json);
            }
        }

        public IActionResult OnPostSubmit()
        {
            OnGet();

            var newMessage = new Message
            {
                Sender = loggedUser.Username,
                Vsebina = vnos
            };

            var existingMessages = Messages;
            existingMessages.Add(newMessage);
            Messages = existingMessages;

            Debug.WriteLine($"Messages count: {Messages.Count}");

            return Page();
        }
    }
}
