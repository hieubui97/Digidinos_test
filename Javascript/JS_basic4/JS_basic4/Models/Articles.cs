using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JS_basic4.Models
{
    public class Articles
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Des { get; set; }
        public string Detail { get; set; }
        public string Category { get; set; }
        public string IsPublic { get; set; }
        public DateTime DatePublic { get; set; }
        public string Position { get; set; }
        public string Thumbs { get; set; }
    }
}