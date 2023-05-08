using FakeStore.DataAccess.DTO;
using FakeStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess.DAO.Interface
{
    public interface IUserDAO 
    {
        public IEnumerable<User> GetUsersLimited(int limit);
        public IEnumerable<User> GetUsers();
        public IEnumerable<User> GetUsersSortedBy<TKey>(Func<User, TKey> keySelector);
        public User GetUserById(int id);
        public Task<User> AddUser(UserToAddDTO userDto);
        public Task<User> UpdateUser(UserToUpdateDTO userDto);
        public Task DeleteUserById(int id);
    }
}
