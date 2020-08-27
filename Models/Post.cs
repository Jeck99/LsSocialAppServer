using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LsSocialWebApplication.Models
{
    public class Post
    {
        [Key]
        public long Id { get; set; }//primary key
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }
        [Display(Name = "Update date")]
        public DateTime? updateDate { get; set; }
        public string UserId { get; set; }
        [Display(Name = "Likes")]
        public int likes { get; set; }
    }
}
