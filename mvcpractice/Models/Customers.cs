using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcpractice.Models
{
    public class Customers
    {
        [Key]
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }

    }
}