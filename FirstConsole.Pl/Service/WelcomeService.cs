using FirstConsole.Dal.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FirstConsole.Pl.Service
{
    public class WelcomeService
    {
        public void Welcome()
        {
            string num;
            do
            {
                Console.WriteLine($"Hey......\nIf you want do something with the Users plz Enter:1\nIf you want do something with the Posts plz Enter:2\nIf you want to Exit plz Enter:3");
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.Clear();
                        UserData();
                        break;
                    case "2":
                        PostData();
                        break;
                    default:
                        break;
                }
            } while (num!="4");
        }
        public void UserData()
        {
            Console.Clear();
            UserService userService = new UserService();
            string click;
            do
            {
                Console.WriteLine($"Dear......\nIf you want to Add User plz Enter:1\nIf you want to Delete User plz Enter:2\nIf you want to Search for User plz Enter:3\nIf you want to update User plz Enter:4\nIf you want to View all Users plz Enter:5\nIf you want to Exit plz Enter:6\n");

             
                click = Console.ReadLine();
                switch (click)
                {

                    case "1":
                        Console.Clear();
                        userService.CreateData();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Plz Enter the User Id you want Delete it : ");
                        int id = int.Parse(Console.ReadLine());
                        userService.Delete(id);
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Plz Enter the User Id you want Search for it : ");
                        int UserId = int.Parse(Console.ReadLine());
                        userService.GetUserById(UserId);
                        break;

                    case "4":
                        Console.Clear();
                        userService.UpdateData();
                        break;

                    case "5":
                        Console.Clear();
                        userService.GetALLusers();
                        break;
                    default:
                        break;
                }
            } while (click != "6");
        }


        public void PostData()
        {
            Console.Clear();
            PostService postService = new PostService();
            string click;
            do
            {
                Console.WriteLine($"Dear......\nIf you want to Add Post plz Enter:1\nIf you want to Delete Post plz Enter:2\nIf you want to Search for Post plz Enter:3\nIf you want to Update Post plz Enter:4\nIf you want to View all Posts User plz Enter:5\nIf you want to Exit plz Enter:6\n");

             
                click = Console.ReadLine();
                switch (click)
                {

                    case "1":
                        Console.Clear();
                        postService.CreateData();
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Plz Enter the Post Id you want Delete it : ");
                        int id = int.Parse(Console.ReadLine());
                        postService.DeletePost(id);
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Plz Enter the User Id you want Search for it : ");
                        int PostId = int.Parse(Console.ReadLine());
                        postService.GetPostById(PostId);
                        break;

                    case "4":
                        Console.Clear();
                        postService.UpdateData();
                        break;

                    case "5":
                        Console.Clear();
                        postService.GetALLPosts();
                        break;
                    default:
                        break;
                }
            } while (click != "6");
        }

    }
}
