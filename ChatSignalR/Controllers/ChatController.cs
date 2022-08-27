using Microsoft.AspNetCore.Mvc;

namespace ChatSignalR.Controllers
{
    public class ChatController : Controller
    {
        public static Dictionary<int, string> Rooms =
            new Dictionary<int, string>()
            {
                {1, "Programación" },
                {2, "Multimedia" },
                {3, "Energias Renovables" },
                {4, "Sonido" }
            };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
