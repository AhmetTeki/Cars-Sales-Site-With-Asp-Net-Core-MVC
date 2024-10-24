using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OtoServisSatis.Entity;
using OtoServisSatis.Servis;
using OtoServisSatis.WebUI.Util;

namespace OtoServisSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class CarsController : Controller
    {
        // GET: CarsController
        private readonly IService<Arac> _service;
        private readonly IService<Marka> _serviceMarka;

        public CarsController(IService<Arac> service, IService<Marka> serviceMarka)
        {
            _service = service;
            _serviceMarka = serviceMarka;
        }

        public async Task<ActionResult> IndexAsync()
        {
            var model = await _service.GetAllAsync();
            return View(model);
        }

        // GET: CarsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarsController/Create
        public async Task<ActionResult> CreateAsync()
        {
            ViewBag.MarkaId =new SelectList(await _serviceMarka.GetAllAsync(),"Id","Adi");
            return View();
        }

        // POST: CarsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Arac arac, IFormFile? Resim1, IFormFile? Resim2, IFormFile? Resim3)
        {
            try
            {
                arac.Resim1 = await FileHelper.FileLoaderAsync(Resim1);
                arac.Resim2 = await FileHelper.FileLoaderAsync(Resim2);
                arac.Resim3 = await FileHelper.FileLoaderAsync(Resim3);
                await _service.AddAsync(arac);
                await _service.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu");
            }
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            return View(arac);
        }

        // GET: CarsController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            var model= await _service.FindAsync(id);
            return View(model);
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Arac arac, IFormFile? Resim1, IFormFile? Resim2, IFormFile? Resim3)
        {
            try
            {
                if (Resim1 is not null)
                {
                    arac.Resim1 = await FileHelper.FileLoaderAsync(Resim1);
                }
                if (Resim2 is not null)
                {
                    arac.Resim2 = await FileHelper.FileLoaderAsync(Resim2);
                }
                if (Resim3 is not null)
                {
                    arac.Resim3 = await FileHelper.FileLoaderAsync(Resim3);
                }


                _service.Update(arac);
                await _service.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu");
            }
            ViewBag.MarkaId = new SelectList(await _serviceMarka.GetAllAsync(), "Id", "Adi");
            return View(arac);
        }

        // GET: CarsController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model= await _service.FindAsync(id);
            return View(model);
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Arac arac)
        {
            try
            {
                _service.Delete(arac);
                _service.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
               
            }
            return View(arac);
        }
    }
}
