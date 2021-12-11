using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebTruyen.Models;

namespace WebTruyen.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private readonly ITruyenRepository repository;

        public NavigationMenuViewComponent(ITruyenRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Truyens.Select(x=>x.TheLoai).Distinct().OrderBy(x=>x));
        }
    }
}
