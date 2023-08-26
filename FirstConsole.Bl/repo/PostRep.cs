using FirstConsole.Bl.Interface;
using FirstConsole.Bl.ModelVm;
using FirstConsole.Dal.Database;
using FirstConsole.Dal.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Bl.repo
{
    public class PostRep : IPostRep
    {
        #region field
        ApplicationDbContext Db = new ApplicationDbContext();
        #endregion

        #region Handle Function
        public void CreatePost(Post post)
        {
            try
            {
                post.puplishingDate = DateTime.Now;
                Db.posts.Add(post);
                Db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeletePost(int id)
        {
            if (id != null && id != 0)
            {
                var post = Db.posts.Where(a => a.Id == id).FirstOrDefault();

                if (post != null)
                {
                    post.IsDeleted = true;
                    Db.SaveChanges();

                }
            }


        }

        public List<Post> GetAllPosts()
        {
            var posts = Db.posts.Where(a => a.IsDeleted != true).Include(a=>a.User).ToList();
            return posts;
        }

        public Post GetPostById(int id)
        {
            if (id != null && id != 0)
            {
                var post = Db.posts.Where(a => a.Id == id).Include(a=>a.User).FirstOrDefault();
                return post;
            }
            return null;

        }



        public void UpdatePost(PostVm post)
        {
            if (post.Id != null && post.Id != 0)
            {
                var OldPost = Db.posts.Where(a => a.Id == post.Id).FirstOrDefault();

                if (OldPost != null)
                {
                    OldPost.Body = post.Body;
                    Db.SaveChanges();
                }
            }
        }
        #endregion
    }
}
