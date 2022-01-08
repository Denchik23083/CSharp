using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEntity.Db;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly MvcContext _context;

        public PhoneRepository(MvcContext context)
        {
            _context = context;
        }

        public async Task<List<Phone>> GetPhone()
        {
            var phone = await _context.Phones.ToListAsync();

            return phone;
        }

        public async Task<Phone> Push(int id)
        {
            var pushPhone = await _context.Phones.FirstOrDefaultAsync(p => p.Id == id);

            return pushPhone;
        }
    }
}