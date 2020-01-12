using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace AvtobuskaStanica.Models
{
    public class Relation
    {
        public int id { get; set; }
        [Required]
        public string fromDestination { get; set; }
        [Required]
        public  string toDestination { get; set; }
        [Required]
        public int priceOneWay { get; set; }
        [Required]
        public int priceRoundTrip { get; set; }
        [Required]
        public  int capacity { get; set; }
        [Required]
        public string time { get; set; }
        [Required]
        public string company { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}