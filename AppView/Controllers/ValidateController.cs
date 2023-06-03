using Microsoft.AspNetCore.Mvc;

namespace AppView.Controllers
{
    public class ValidateController : Controller
    {
        public IActionResult CreateValidate()
        {
            if(ModelState.IsValid) { 
                return View();
            }
            return Content("Bạn nhập sai rồi");
        }
    }
}
