﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AvtobuskaStanica.Models
{
    public class Customer 
    {
        public int id { get; set; }
        [Required]
        public long serialNumber { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public long cardNumber { get; set; }

        //public int relationId { get; set; }

        public  Relation Relation { get; set; }
    }
}