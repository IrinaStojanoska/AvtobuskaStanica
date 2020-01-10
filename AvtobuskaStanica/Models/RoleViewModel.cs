using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvtobuskaStanica.Models
{
    public class RoleViewModel
    {
        public RoleViewModel() { }
        public RoleViewModel(ApplicationRole role)
        {
            id = role.Id;
            name = role.Name;
          //  roles = new List<string>();
        }

        public string id { get; set; }
        public string  name { get; set; }
      //  public List<string> roles { get; set; }

    }
}