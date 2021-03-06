﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcpractice.Models
{
    public class VirtualPet
    {
        [Key]
        public int VirtualPetID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Hunger { get; set; }
        [DisplayName("Type of Pet")] // this "decorates" the prop below
        public string Type { get; set; }
        public int Thirst { get; set; }
    }
}