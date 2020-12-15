using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models
{
    /// <summary>
    /// Post Model class
    /// </summary>
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public string Keywords { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Active { get; set; }

        public Category Category { get; set; }
    }
}
