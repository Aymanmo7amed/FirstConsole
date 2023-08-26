using FirstConsole.Bl.ModelVm;
using FirstConsole.Dal.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Bl.Interface
{
    public interface IPostRep
    {
        List<Post> GetAllPosts();
        void CreatePost(Post post);
        Post GetPostById(int id);
        void DeletePost(int id);
        void UpdatePost(PostVm postVm);
    }
}
