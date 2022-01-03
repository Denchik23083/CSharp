using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEntity.Db;
using MvcEntity.Db.Entities;

namespace MvcEntity.WebDb
{
    public class Repository : IRepository
    {
        private readonly MvcContext _context;
        private static User _user;

        public Repository(MvcContext context)
        {
            _context = context;
        }

        public async Task<User> Login(User model)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);

            return user;
        }

        public async Task Register(User user)
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Phone>> GetPhone()
        {
            var phone = await _context.Phones.ToListAsync();

            return phone;
        }

        public async Task AddPhone(Phone model)
        {
            await _context.Phones.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task<Phone> GetToEditPhone(int id)
        {
            var getToEditPhone = await _context.Phones.FirstOrDefaultAsync(p => p.Id == id);

            if (getToEditPhone is null)
            {
                throw new ArgumentNullException();
            }

            return getToEditPhone;
        }

        public Phone EditPhone(Phone model)
        {
            return model;
        }

        public async Task DeletePhone(int id)
        {
            var phoneToDelete = await _context.Phones.FirstOrDefaultAsync(b => b.Id == id);

            if (phoneToDelete is null)
            {
                throw new ArgumentNullException();
            }

            _context.Phones.Remove(phoneToDelete);
            await _context.SaveChangesAsync();
        }

        public User GetUser(User user)
        {
            _user = user;
            
            return user;
        }

        public async Task<User> EditUser(User user)
        {
            var userToUpdate = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);

            return userToUpdate;
        }

        public async Task DeleteUser(int id)
        {
            var userToDelete = await _context.Users.FirstOrDefaultAsync(b => b.Id == id);

            if (userToDelete is null)
            {
                throw new ArgumentNullException();
            }

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Phone> Push(int id)
        {
            var pushPhone = await _context.Phones.FirstOrDefaultAsync(p => p.Id == id);

            return pushPhone;
        }
        public async Task Payment(int totalPrice)
        {
            _user.Balance -= totalPrice;

            _context.Users.Update(_user);

            await _context.SaveChangesAsync();
        }

        public async Task Replenish(Replenish replenish)
        {
            _user.Balance += replenish.Money;

            _context.Users.Update(_user);

            await _context.SaveChangesAsync();
        }
    }
}