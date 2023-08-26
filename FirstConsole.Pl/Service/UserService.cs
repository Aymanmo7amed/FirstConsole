using FirstConsole.Bl.ModelVm;
using FirstConsole.Bl.repo;
using FirstConsole.Dal.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Pl.Service
{
    public class UserService
    {
        UserRep userRep = new UserRep();
        public void GetALLusers()
        {
            foreach(var User in userRep.GetAllUsers())
            {
                Console.WriteLine(User.FName+" "+User.Email);
            }
        }
        public void Delete(int id)
        {
            userRep.Delete(id);
        }
        
        public string print(UserVm userVm)
        {
            return$"Name:{userVm.FName} {userVm.LName}\nE_mail:{userVm.Email}\nPassWord:{userVm.PassWord}\nUseName:{userVm.UserName}";
        }
        public void GetUserById(int id)
        {
           User user= userRep.GetUserById(id);
            UserVm userVm = new UserVm()
            {
                FName = user.FName,
                LName = user.LName,
                Email = user.Email,
                PassWord = user.PassWord,
                UserName = user.UserName,

            };
            Console.WriteLine(print(userVm));
        }


        public void CreateData()
        {
            Console.WriteLine("Hello....");
            Console.Write("plz Enter First Name: ");
            string firstname = Console.ReadLine();
            Console.Write("plz Enter Last Name: ");
            string lastname = Console.ReadLine();
            Console.Write("plz Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("plz Enter User Name: ");
            string username = Console.ReadLine();
            Console.Write("plz Enter PssWord: ");
            string pass = Console.ReadLine();
            UserVm userVm = new UserVm()
            {
                FName = firstname,
                LName = lastname,
                Email = email,
                PassWord=pass,
                UserName=username,

            };
            Create(userVm);


        }
        public void UpdateData()
        {

            Console.WriteLine("Hello....");
            Console.Write("plz Enter ID: ");
            int id =int.Parse( Console.ReadLine());
            Console.Write("plz Enter First Name: ");
            string firstname = Console.ReadLine();
            Console.Write("plz Enter Last Name: ");
            string lastname = Console.ReadLine();
            Console.Write("plz Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("plz Enter User Name: ");
            string username = Console.ReadLine();
            Console.Write("plz Enter PssWord: ");
            string pass = Console.ReadLine();
            UserVm userVm = new UserVm()
            {
                Id = id,
                FName = firstname,
                LName = lastname,
                Email = email,
                PassWord = pass,
                UserName = username,

            };
            userRep.Update(userVm);


        }
        public void Create(UserVm uservm)
        {
            User user = new User()
            {
                FName = uservm.FName,
                LName = uservm.LName,
                Email = uservm.Email,
                UserName = uservm.UserName,
                IsDeleted = false,
                PassWord = uservm.PassWord,
            };
           userRep.Create(user);
        }
    }
}
