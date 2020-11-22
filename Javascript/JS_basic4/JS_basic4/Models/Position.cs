using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JS_basic4.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}