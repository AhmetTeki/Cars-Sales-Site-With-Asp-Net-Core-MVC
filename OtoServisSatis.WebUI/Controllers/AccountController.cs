using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OtoServisSatis.Entity;
using OtoServisSatis.Servis;

namespace OtoServisSatis.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IService<Kullanici> _service;
        private readonly IService<Rol> _serviceRol;
        public AccountController(IService<Kullanici> service, IService<Rol> serviceRol)
        {
            _service = service;
            _serviceRol = serviceRol;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(Kullanici kullanici)
        {
            try
            {
                var rol = await _serviceRol.GetAsync(r => r.Adi == "Admin");
                kullanici.RolId=rol.Id;
                kullanici.AktifMi = true;
               await _service.AddAsync(kullanici);
              await  _service.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                
            }
            
            return View();
        }
    }
}
