using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AvtobuskaStanica.Models
{
    public class AddToRoleModel
    {
        [Key]
        public int id { get; set; }
        public string Email { get; set; }
        public string selectedRole { get; set; }
        public List<string>roles { get; set; }
        public AddToRoleModel()
        {
            roles = new List<string>();
        }
    }
}