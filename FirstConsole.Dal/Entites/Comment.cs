using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole.Dal.Entites
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Min Length = 2 !")]
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime puplishingDate { get; set; }
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post post { get; set; }
    }
}
