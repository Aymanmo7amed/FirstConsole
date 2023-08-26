using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Dal.Entites
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required ]
        [MaxLength(30,ErrorMessage ="Max Length = 30 ! ")]
        public string FName { get; set; }
        public string? LName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool IsDeleted { get; set; }
        public List<Post> posts { get; set; }
        public List<Comment>comments { get; set; }



    }
}
