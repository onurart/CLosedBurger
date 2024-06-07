using Microsoft.AspNetCore.Mvc;

namespace ClosedBurger.Client.Components.Client
{
    public class HomeAboutUsCard : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();  
        }

    }
}
