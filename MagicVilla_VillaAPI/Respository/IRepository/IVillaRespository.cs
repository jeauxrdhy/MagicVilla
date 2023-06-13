using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Respository.IRepository
{
    public interface IVillaRespository : IRepository<Villa>
    {
        
        Task<Villa> UpdateAsync(Villa entity);
        
    }
}
