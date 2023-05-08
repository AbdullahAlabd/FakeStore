using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeStore.DataAccess;
using FakeStore.DataAccess.DAO.Interface;

namespace FakeStore.Business.EntityManagers
{
    public interface IUserManager
    {
        public UserDTO GetUserById(int id);
    }
    public class UserManager : IUserManager
    {
        private readonly IUserDAO _userDAO;
        public UserManager(IUserDAO userDAO)
        {
            _userDAO = userDAO;
        }
        public UserDTO GetUserById(int id) // TODO: use autoMapper instead of manual mapping
        {
            var user = _userDAO.GetUserById(id);
            if(user == null)
            {
                return null;
            }
            var userDto = new UserDTO{
                Id = user.Id,
                CreatedAt = user.CreatedAt,
                Email = user.Email,
                Username = user.Username,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                MSISDN = user.MSISDN,
                Country = user.Country,
                City = user.City
            };
            return userDto;
        }
    }
}
