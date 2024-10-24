using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using OtoServisSatis.Entity;
using OtoServisSatis.Servis;
using System.Security.Claims;

namespace OtoServisSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IService<Kullanici> _service;

        public LoginController(IService<Kullanici> service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> LogOutAsync()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Admin/Login");
        }
        [HttpPost]
        public async Task<IActionResult> IndexAsync(string email, string password)
        {
            try
            {
                var account= _service.Get(k=> k.Email==email && k.Sifre==password && k.AktifMi==true);

                if(account==null)
                {
                    TempData["Mesaj"] = "Email veya Şifreniz Yanlış";
                    return Redirect("/Admin/Login");
                }
                else
                {
                    var claims= new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, account.Adi),
                        new Claim("Roles", "Admin")
                    }; 
                    var userIdentity= new ClaimsIdentity(claims, "Login");   
                    ClaimsPrincipal principal= new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return Redirect("/Admin");
                }
            }
            catch (Exception)
            {

                TempData["Mesaj"] = "Hata Oluştu";
            }
            return View();
        }
    }
}
