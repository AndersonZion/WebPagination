using System.Threading.Tasks;
using WebPagination.Models;

namespace WebPagination.Data.Repositories
{
    public interface IPhoneRepository 
    {
        Task AddAsync(Phone entity);
    }
}
