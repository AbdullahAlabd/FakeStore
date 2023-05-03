using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeStore.DataAccess;
using FakeStore.DataAccess.DAO.Interface;

namespace FakeStore.Business.EntityManagers
{
    public class UserManager
    {
        private readonly IUserDAO _userDAO;
        public UserManager(IUserDAO userDAO)
        {
            _userDAO = userDAO;
        }
        public async Task AddUser()
        {
            // TODO: implement
            _userDAO.AddUser("Dummy", "123");
        }
    }
}
