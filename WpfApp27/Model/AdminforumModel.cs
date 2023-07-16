using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp27.Model
{
    public class AdminforumModel : BaseVM
    {
       
        public int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnpropertyChanged(nameof(Id)); }
        }


        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnpropertyChanged(nameof(Name)); }
        }

        private int regno;

        public int Regno
        {
            get { return regno; }
            set { regno = value; OnpropertyChanged(nameof(Regno)); }
        }


    }
}
