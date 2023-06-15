using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Respository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Respository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRespository
    {
        private readonly ApplicationDBContext _db;

        public VillaNumberRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
        

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.VillaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
