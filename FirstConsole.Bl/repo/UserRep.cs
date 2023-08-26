using FirstConsole.Bl.Interface;
using FirstConsole.Bl.ModelVm;
using FirstConsole.Dal.Database;
using FirstConsole.Dal.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Bl.repo
{
    public class UserRep : IUserRep
    {
        #region field
        ApplicationDbContext Db =new ApplicationDbContext();
        #endregion

        #region Handle Function
        public void Create(User user)
        {
            try
            {
                Db.Users.Add(user);
                Db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            if (id != null && id!=0)
            {
                var user = Db.Users.Where(a => a.Id == id).FirstOrDefault();
                
                if (user!=null)
                {
                    user.IsDeleted= true;
                    Db.SaveChanges() ;  

                }
            }
            

        }

        public List<User> GetAllUsers()
        {
            var users = Db.Users.Where(a=>a.IsDeleted!=true).ToList();
            return users;
        }

        public User GetUserById(int id)
        {
            if (id!=null && id !=0)
            {
                var user = Db.Users.Where(a => a.Id == id).FirstOrDefault();
                return user;
            }
            return null;
          
        }

        

        public void Update(UserVm user)
        {
            if (user.Id != null && user.Id != 0)
            {
                var OldUser = Db.Users.Where(a => a.Id == user.Id).FirstOrDefault();

                if (OldUser != null)
                {
                    OldUser.FName = user.FName;
                    OldUser.LName = user.LName;
                    OldUser.UserName = user.UserName;
                    OldUser.PassWord=user.PassWord;
                    OldUser.Email = user.Email;
                    Db.SaveChanges();

                }
            }
        }
        #endregion

    }
}
