using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Respository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
        
    }
}
