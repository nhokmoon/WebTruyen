using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebTruyen.Models;
using WebTruyen.Models.ViewModels;

namespace WebTruyen.Controllers
{
    public class TruyenController : Controller
    {
        private readonly ITruyenRepository truyenRepository;
        public TruyenController(ITruyenRepository _truyenRepository)
        {
            truyenRepository = _truyenRepository;
        }
        public ViewResult List(string theloai)
        {
            return View(new TruyenListViewModel()
            {
                Truyens = truyenRepository.Truyens.Where(p=>theloai==null||p.TheLoai==theloai).OrderBy(p=>p.TruyenId),
            });
        }
        public IActionResult Details(int truyenId)
        {
            return View(truyenRepository.Truyens.FirstOrDefault(p=>p.TruyenId==truyenId));
        }

        public ViewResult searchName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return View(new TruyenListViewModel()
                {
                    Truyens = truyenRepository.Truyens.Where(p=>p.TenTruyen.Contains(name)).OrderBy(p=>p.TruyenId),
                });
            }
            else
            {
                return View(new TruyenListViewModel()
                {
                    Truyens = truyenRepository.Truyens.ToList(),
                });
            }
        }
    }
}
