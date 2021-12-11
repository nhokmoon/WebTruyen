using System.Collections.Generic;

namespace WebTruyen.Models.ViewModels
{
    public class TruyenListViewModel
    {
        public IEnumerable<Truyen> Truyens { get; set; }
        public string CurrentTheLoai { get; set; }  
    }
}
