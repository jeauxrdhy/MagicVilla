using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Respository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        
        Task<Villa> UpdateAsync(Villa entity);
        
    }
}
