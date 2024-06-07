using Microsoft.AspNetCore.Mvc;

namespace ClosedBurger.Client.Components.AdminPanel
{
    public class Chatbox : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
