using Microsoft.AspNetCore.Mvc;

namespace ClosedBurger.Client.Components.Client
{
    public class Footer : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
