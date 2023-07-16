using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp27.Model
{
    public class StudentLoginDetails
    {
        [Key]
        public string Username { get; set; }

        public string Password { get; set; }

    }
}
