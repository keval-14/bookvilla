using BookStore.Models.DataModels;

namespace BookStore.Repository
{
    public class BaseRepository
    {
        protected readonly tatvadbContext _context = new tatvadbContext();
    }
}
