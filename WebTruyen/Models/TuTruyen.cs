using System.Collections.Generic;
using System.Linq;

namespace WebTruyen.Models
{
    public class TuTruyen
    {
        private readonly List<TuTruyenItem> tutruyenItems = new();

        public virtual void AddTruyen(Truyen truyen, int solantruycap)
        {
            TuTruyenItem item = tutruyenItems.Where(p => p.Truyen.TruyenId == truyen.TruyenId).FirstOrDefault();
            
            if(item == null)
            {
                tutruyenItems.Add(new TuTruyenItem
                {
                    Truyen=truyen,
                    SoLanTruyCap=solantruycap,
                });
            }
            else
            {
                item.SoLanTruyCap += solantruycap;
            }
        }
        public virtual void RemoveTruyen(Truyen truyen)
        {
            tutruyenItems.RemoveAll(p => p.Truyen.TruyenId == truyen.TruyenId);
        }
        public virtual void Clear()
        {
            tutruyenItems.Clear();
        }
        public IEnumerable<TuTruyenItem> Items => tutruyenItems;
    }
}
