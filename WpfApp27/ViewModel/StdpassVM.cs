using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp27.Commands;
using WpfApp27.Model;

namespace WpfApp27.ViewModel
{
    public class StdpassVM : BaseVM
    {

        private StudentLoginDetails login;

        public StudentLoginDetails Login
        {
            get { return login; }
            set { login = value; OnpropertyChanged(nameof(Login)); }
        }

        public void addu()
        {
            using (Database database = new Database())
            {
                database.studetails.Add(login);
                database.SaveChanges();

            }
        }
        public Addstucommand addst { get; set; }
        public StdpassVM()
        {
            addst = new Addstucommand(this);
            login = new StudentLoginDetails();
        }

    }
}
