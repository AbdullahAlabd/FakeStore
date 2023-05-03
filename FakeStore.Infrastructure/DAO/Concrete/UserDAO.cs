using FakeStore.DataAccess.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Task AddUser(string username, string password)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
