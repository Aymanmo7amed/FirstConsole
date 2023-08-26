using FirstConsole.Bl.ModelVm;
using FirstConsole.Bl.repo;
using FirstConsole.Dal.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Pl.Service
{
    public class PostService
    {
        PostRep postRep = new PostRep();
        public void GetALLPosts()
        {
            foreach (var Post in postRep.GetAllPosts())
            {
                Console.WriteLine(Post.User.FName+Post.User.LName);
                Console.WriteLine(Post.puplishingDate);
                Console.WriteLine(Post.Body);
            }
        }
        public void DeletePost(int id)
        {
            postRep.DeletePost(id);
        }

        public string print(PostVm post)
        {
            return $"{post.User.FName} {post.User.LName}\n{post.puplishingDate}\n{post.Body} ";
        }
        public void GetPostById(int id)
        {
            Post post = postRep.GetPostById(id);
            PostVm postVm = new PostVm()
            {
              Body = post.Body,
              puplishingDate = post.puplishingDate,
              User = post.User,
              UserId =post.UserId

            };
            Console.WriteLine(print(postVm));
        }


        public void CreateData()
        {
            Console.WriteLine("Hello....");
            Console.Write("plz Enter Body: ");
            string Body = Console.ReadLine();
            Console.Write("plz Enter ID of this User: ");
            int ID =int.Parse( Console.ReadLine());
            PostVm postVm = new PostVm()
            {
                Body = Body,
                UserId = ID


            };
            Create(postVm);


        }
        public void Create(PostVm postVm)
        {
            Post post = new Post()
            {
               Body=postVm.Body,
               UserId=postVm.UserId,
            };
            postRep.CreatePost(post);
        }

        public void UpdateData()
        {

            Console.WriteLine("Hello....");
            Console.Write("plz Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("plz Enter New Body: ");
            string NBody = Console.ReadLine();
           
            PostVm postVm = new PostVm()
            {
                Id = id,
                Body=NBody

            };
            postRep.UpdatePost(postVm);


        }

    }
}
