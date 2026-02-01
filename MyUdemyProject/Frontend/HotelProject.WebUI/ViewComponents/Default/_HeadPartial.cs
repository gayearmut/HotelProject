using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _HeadPartial:ViewComponent 
    {
        public IViewComponentResult Invoke() //Default method name is Invoke
        {
            return View();
        }
    }
}
