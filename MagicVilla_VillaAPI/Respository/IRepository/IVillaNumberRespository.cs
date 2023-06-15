using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Respository.IRepository
{
    public interface IVillaNumberRespository : IRepository<VillaNumber>
    {
        
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
        
    }
}
