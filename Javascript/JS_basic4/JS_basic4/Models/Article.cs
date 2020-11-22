using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JS_basic4.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "pls enter title")]
        [MinLength(4, ErrorMessage = "Name should be more than to four characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "pls enter des")]
        public string Des { get; set; }
        [Required(ErrorMessage = "pls enter detail")]
        public string Detail { get; set; }

        public int CategoryId { get; set; }
        [Required(ErrorMessage = "pls choose status")]
        public bool IsPublic { get; set; }
        [Required(ErrorMessage = "pls enter date")]
        public DateTime DatePublic { get; set; }
        [Required(ErrorMessage = "pls choose position")]
        public List<int> Position { get; set; }
        [Required(ErrorMessage = "pls choose thumbs")]
        public string Thumbs { get; set; }
    }
}