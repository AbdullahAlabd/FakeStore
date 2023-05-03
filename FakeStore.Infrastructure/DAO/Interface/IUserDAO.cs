using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess.DAO.Interface
{
    public interface IUserDAO 
    {
        public Task AddUser(string username, string password);
    }
}
