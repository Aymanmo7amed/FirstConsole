using FirstConsole.Pl.Service;
using System;
namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeService welcomeService = new WelcomeService();
            welcomeService.Welcome();
            //UserService userService = new UserService();
            ////userService.CreateData();
            ////userService.GetALLusers();
            ////userService.GetUserById(1);
            ////userService.Delete(2);
            ////userService.UpdateData();
            //PostService postService = new PostService();
            ////postService.DeletePost(2);
            ////postService.GetALLPosts();
            ////postService.CreateData();
            ////postService.GetPostById(1);
            ////postService.UpdateData();


        }
    }
}