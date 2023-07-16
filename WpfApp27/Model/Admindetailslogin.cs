using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp27.Model
{
    public class Admindetailslogin
    {
        [Key]

        public string aUsername { get; set; }

        public string aPassword { get; set; }
    }
}
