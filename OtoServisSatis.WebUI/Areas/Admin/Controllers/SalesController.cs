using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OtoServisSatis.Entity;
using OtoServisSatis.Servis;

namespace OtoServisSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SalesController : Controller
    {
        // GET: SalesController
        private readonly IService<Satis> _service;
        private readonly IService<Arac> _serviceArac;
        private readonly IService<Musteri> _serviceMusteri;

        public SalesController(IService<Satis> service, IService<Arac> serviceArac, IService<Musteri> serviceMusteri )
        {
            _service = service;
            
            _serviceArac = serviceArac;
            _serviceMusteri = serviceMusteri;
        }

        public async Task<ActionResult> IndexAsync()
        {
            var model= await _service.GetAllAsync();
            return View(model);
        }

        // GET: SalesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SalesController/Create
        public async Task<ActionResult> CreateAsync()
        {
            ViewBag.AracId= new SelectList(await _serviceArac.GetAllAsync(),"Id","Modeli");
            ViewBag.MusteriId= new SelectList(await _serviceMusteri.GetAllAsync(),"Id", "Adi");
            return View();
        }

        // POST: SalesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(Satis satis)
        {
            try
            {
                await _service.AddAsync(satis);
                await _service.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Hata oluştu başkan");
            }
            ViewBag.AracId = new SelectList(await _serviceArac.GetAllAsync(), "Id", "Modeli");
            ViewBag.MusteriId = new SelectList(await _serviceMusteri.GetAllAsync(), "Id", "Adi");
            return View(satis);
        }

        // GET: SalesController/Edit/5
        public async Task<ActionResult> EditAsync(int id)
        {
            ViewBag.AracId = new SelectList(await _serviceArac.GetAllAsync(), "Id", "Modeli");
            ViewBag.MusteriId = new SelectList(await _serviceMusteri.GetAllAsync(), "Id", "Adi");
            var model=await _service.FindAsync(id);
            return View(model);
        }

        // POST: SalesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Satis satis)
        {
            try
            {
                _service.Update(satis);
                _service.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                
            }
            ViewBag.AracId = new SelectList(await _serviceArac.GetAllAsync(), "Id", "Modeli");
            ViewBag.MusteriId = new SelectList(await _serviceMusteri.GetAllAsync(), "Id", "Adi");
            return View();

        }

        // GET: SalesController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model= await _service.FindAsync(id);
            return View(model);
        }

        // POST: SalesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Satis satis)
        {
            try
            {
                _service.Delete(satis);
                _service.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
