using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entity;
using OtoServisSatis.Servis;
using OtoServisSatis.WebUI.Models;
using System.Diagnostics;

namespace OtoServisSatis.WebUI.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IService<Arac> _serviceArac;

        public HomeController(IService<Arac> serviceArac)
        {
            _serviceArac = serviceArac;
        }

        public  IActionResult Index()
        {

            var model = _serviceArac.GetAll();
            
            
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}