using System.Linq;

namespace WebTruyen.Models
{
    public interface ITruyenRepository
    {
        IQueryable<Truyen> Truyens { get; }
    }
}
