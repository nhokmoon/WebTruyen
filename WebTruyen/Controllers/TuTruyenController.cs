using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebTruyen.Infrastructure;
using WebTruyen.Models;
using WebTruyen.Models.ViewModels;

namespace WebTruyen.Controllers
{
    public class TuTruyenController : Controller
    {
        private readonly ITruyenRepository truyenRepository;

        public TuTruyenController(ITruyenRepository _truyenRepository)
        {
            truyenRepository = _truyenRepository;
        }

        private TuTruyen GetTruyen()
        {
            TuTruyen tutruyen = HttpContext.Session.Getjson<TuTruyen>("TuTruyen") ?? new TuTruyen();
            return tutruyen;
        }

        private void SaveTuTruyen(TuTruyen tutruyen)
        {
            HttpContext.Session.SetJson("TuTruyen", tutruyen);
        }

        public RedirectToActionResult AddTuTruyen(int truyenId, string returnUrl)
        {
            Truyen truyen = truyenRepository.Truyens.FirstOrDefault(p=>p.TruyenId == truyenId);
            if (truyen != null)
            {
                TuTruyen tutruyen = GetTruyen();
                tutruyen.AddTruyen(truyen, 1);
                SaveTuTruyen(tutruyen);
            }
            return RedirectToAction("Index",new {returnUrl});
        }

        public RedirectToActionResult RemoveTuTruyen(int truyenId, string returnUrl)
        {
            Truyen truyen = truyenRepository.Truyens.FirstOrDefault(p=>p.TruyenId==truyenId);
            if(truyen != null)
            {
                TuTruyen tutruyen = GetTruyen();
                tutruyen.RemoveTruyen(truyen);
                SaveTuTruyen(tutruyen);
            }
            return RedirectToAction("Index",new {returnUrl});
        }

        public ViewResult Index(string returnUrl)
        {
            var model = new TuTruyenIndexViewModel
            {
                TuTruyen = GetTruyen(),
                ReTurnUrl = returnUrl
            };
            return View(model);
        }
    }
}
