using System.Linq;

namespace WebTruyen.Models
{
    public class TruyenRepository:ITruyenRepository
    {
        private readonly ApplicationDbContext context;
        public TruyenRepository(ApplicationDbContext _context)
        {
            context = _context;
        }
        public IQueryable<Truyen> Truyens => context.Truyens;

        public Truyen DeleteTruyen(int truyenId)
        {
            throw new System.NotImplementedException();
        }
    }
}
