using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
            
        }
        [HttpGet]
        [Route("portfolio")]
        public IActionResult portfolio(){
            return View("portfolio");
        }
        [HttpGet]
        [Route("contact")]
        public IActionResult contact(){
            return View("contact");
        }

    }
}


// BELOW IS EXAMPLE OF JSON data to page
//         [HttpGet]
//         [Route("displayint")]
//         public JsonResult DisplayInt()
//         {
//             var AnonObject = new
//             {
//                 FirstName = "Hello",
//                 LastName = "World",
//                 Age = 101
//             };
//             return Json(AnonObject);
//         }