using FirstConsole.Bl.ModelVm;
using FirstConsole.Dal.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Bl.Interface
{
    public interface IUserRep
    {
        List<User> GetAllUsers();
        void Create(User user);
        User GetUserById(int id);
        void Delete(int id);
        void Update(UserVm user);
    }
}
