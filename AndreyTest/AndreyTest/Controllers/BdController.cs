using AndreyTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndreyTest.Controllers
{
    [ApiController]
    public class BdController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("projectView")]
        public IActionResult ProjectView()
        {
            return View();
        }
        
        [Route("workerView")]
        public IActionResult WorkerView()
        {
            return View();
        }
    }
}