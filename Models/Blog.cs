using BlogManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BlogManagementSystem.Models
{
public class Blog
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [Display(Name = "Title")]

        public string Heading { get; set; }
        [Required]
        [Display(Name = "Body")]

        public string Description { get; set; }
        [Required]
        [Display(Name = "Posted By")]

        public string Author { get; set; }
        public Guid Store { get; set; }

        public bool IsEnabled { get; set; }
        public virtual User Users { get; set; }
        
    }
}