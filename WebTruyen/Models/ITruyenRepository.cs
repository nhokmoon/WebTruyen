using System.Linq;

namespace WebTruyen.Models
{
    public interface ITruyenRepository
    {
        IQueryable<Truyen> Truyens { get; }
        void SaveTruyen(Truyen truyen);

        Truyen DeleteTruyen(int truyenId);
    }
}
