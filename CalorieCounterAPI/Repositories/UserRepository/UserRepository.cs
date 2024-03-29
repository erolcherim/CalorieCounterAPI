﻿using CalorieCounterAPI.DAL;
using CalorieCounterAPI.DAL.Models;
using CalorieCounterAPI.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CalorieCounterAPI.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public async Task<List<User>> GetAllUsersAsync() =>
        await _context.Users.ToListAsync();
        public async Task<User> GetUserAndUserRoleById(int userId) =>
            await _context.Users.Include(user => user.UserRoles).ThenInclude(ur => ur.Role).FirstOrDefaultAsync(u => u.Id.Equals(userId));

        public async Task<User> GetUserByEmail(string email) =>
            await _context.Users.Where(user => user.Email.Equals(email)).FirstOrDefaultAsync();
    }
}
