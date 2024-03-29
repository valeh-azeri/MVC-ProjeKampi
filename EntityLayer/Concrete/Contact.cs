﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(500)]
        public string UserEmail { get; set; }
        [StringLength(1000)]
        public string ContactSubject { get; set; }
        [StringLength(1000)]
        public string ContactMessage { get; set; }
    }
}
