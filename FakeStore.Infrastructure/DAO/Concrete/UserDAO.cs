using FakeStore.DataAccess.DAO.Interface;
using FakeStore.DataAccess.DTO;
using FakeStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess.DAO.Concrete
{
    public class UserDAO : IUserDAO
    {
        private readonly ApplicationDBContext _context;
        public UserDAO(ApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsersLimited(int limit) 
        {
            return _context.Users.Take(limit);
        }
        public IEnumerable<User> GetUsers() // TODO: implement paging
        {
            return _context.Users; 
        }
        public IEnumerable<User> GetUsersSortedBy<TKey>(Func<User, TKey> keySelector) // TODO: implement paging
        {
            return _context.Users.OrderBy(keySelector);
        }
        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }
        public async Task<User> AddUser(UserToAddDTO userDto)
        {
            try
            {
                User user = new User
                {
                    Email = userDto.Email,
                    Username = userDto.Username,
                    Password = userDto.Password,
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    MSISDN = userDto?.MSISDN
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return user;
            } catch(Exception ex)
            {
                // Log Exception to logger.
                // Propagate the exception.
                throw;
            } 
        }
        public async Task<User> UpdateUser(UserToUpdateDTO userDto)
        {
            try
            {
                User user = GetUserById(userDto.Id);
                user.Email = userDto.Email;
                user.Username = userDto.Username;
                user.Password = userDto.Password;
                user.FirstName = userDto.FirstName;
                user.LastName = userDto.LastName;
                user.MSISDN = userDto?.MSISDN;
                user.Country = userDto?.Country;
                user.City = userDto?.City;
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                // Log Exception to logger.
                // Propagate the exception.
                throw;
            }
        }
        public async Task DeleteUserById(int id)
        {
            var user = GetUserById(id);
            user.IsDeleted = true;
            user.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync();
        }
    }
}
