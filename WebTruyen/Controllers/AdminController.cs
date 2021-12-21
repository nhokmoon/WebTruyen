using Microsoft.AspNetCore.Mvc;
using WebTruyen.Models;
using WebTruyen.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebTruyen.Controllers
{
    public class AdminController : Controller
    {
        private ITruyenRepository truyenRepository;
        private IHostingEnvironment hostingEnvironment;

        public AdminController(ITruyenRepository _truyenRepository, IHostingEnvironment _hostingEnvironment)
        {
            truyenRepository = _truyenRepository;
            hostingEnvironment = _hostingEnvironment;

        }

        public IActionResult Index()
        {
            return View(new TruyenListViewModel()
            {
                Truyens = truyenRepository.Truyens.OrderBy(p => p.TruyenId)
            }  
            );
        }

        public IActionResult Edit(int truyenId)
        {
            return View(truyenRepository.Truyens.FirstOrDefault(p => p.TruyenId == truyenId));
        }

        [HttpPost]
        public IActionResult Edit(Truyen truyen)
        {
            if(ModelState.IsValid)
            {
                truyenRepository.SaveTruyen(truyen);
                return RedirectToAction("Index");
            }else
            {
                return View(truyen);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TruyenAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                string fileName = null;

                if (model.Photo != null)
                {
                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    fileName = model.Photo.FileName;
                    string filePath = Path.Combine(path, fileName);
                    //lưu hình vào thư mục images
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Truyen p = new Truyen
                {
                    TenTruyen = model.TenTruyen,
                    ChuThich = model.ChuThich,
                    TrangThai = model.TrangThai,
                    TheLoai = model.TheLoai,
                    SoChuong = model.SoChuong,
                    ImageUrl = fileName,
                };
                truyenRepository.SaveTruyen(p);

                return RedirectToAction("Index", model);
            }
            else return View(model);
        }

        public IActionResult Delete(int truyenId)
        {
            truyenRepository.DeleteTruyen(truyenId);
            return RedirectToAction("Index");
        }
    }
}
