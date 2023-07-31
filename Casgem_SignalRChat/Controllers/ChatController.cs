using Microsoft.AspNetCore.Mvc;

namespace Casgem_SignalRChat.Controllers
{
    public class ChatController:Controller
    {
        public IActionResult UserChat()
        {
            return View();
        }
        
    }
}