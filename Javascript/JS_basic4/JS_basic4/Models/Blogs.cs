using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JS_basic4.Models
{
    public class Blogs
    {
        public List<Article> blogs { get; set; }
    }
    public class Article
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string des { get; set; }
        public string detail { get; set; }
        public string category { get; set; }
        public bool publlic { get; set; }
        public DateTime data_pubblic { get; set; }
        public List<int> position { get; set; }
        public string thumbs { get; set; }
    }
}