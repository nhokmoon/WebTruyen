using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTruyen.Models
{
    public class TruyenRepository : ITruyenRepository
    {
        private readonly ApplicationDbContext context;

        public TruyenRepository(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IQueryable<Truyen> Truyens => context.Truyens;

        public Truyen DeleteTruyen(int truyenId)
        {
            Truyen truyen = context.Truyens.FirstOrDefault(p => p.TruyenId == truyenId);
            if (truyen != null)
            {
                context.Truyens.Remove(truyen);
                context.SaveChanges();
            }
            return truyen;
        }
        public void SaveTruyen(Truyen truyen)
        {
            if (truyen.TruyenId == 0)
            {
                context.Truyens.Add(truyen);
            }
            else
            {
                Truyen p = context.Truyens.FirstOrDefault(p => p.TruyenId == truyen.TruyenId);
                if (p != null)
                {
                    p.TenTruyen = truyen.TenTruyen;
                    p.ChuThich = truyen.ChuThich;
                    p.TrangThai = truyen.TrangThai;
                    p.TheLoai = truyen.TheLoai;
                    p.SoChuong = truyen.SoChuong;
                    p.ImageUrl = truyen.ImageUrl;
                }
            }
            context.SaveChanges();
        }
    }
}
