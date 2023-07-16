using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp27.Commands;
using WpfApp27.Model;

namespace WpfApp27.ViewModel
{
    public class AdminforumVM : BaseVM
    {
        private AdminforumModel curradmin;

        public AdminforumModel Curradmin
        {
            get { return curradmin; }
            set { curradmin = value; OnpropertyChanged(nameof(Curradmin)); }
        }


        private List<AdminforumModel> usrlist;

        public List<AdminforumModel> Usrlist
        {
            get { return usrlist; }
            set { usrlist = value; OnpropertyChanged(nameof(Usrlist)); }
        }

        public AdminforumVM()
        {
            buttoncommand = new AddButtonCommand(this);
            deletebutton = new deletebuttoncommand(this);

            Curradmin = new AdminforumModel();
            get();
        }

        public void add()
        {
            using (Database db = new Database())
            {
                db.admforum.Add(Curradmin);
                db.SaveChanges();
                get();
            }

        }

        public void get()
        {
            using (Database db = new Database())
            {
                Usrlist = db.admforum.ToList();
            }
        }

        public AddButtonCommand buttoncommand { get; set; }
        public deletebuttoncommand deletebutton { get; set; }
        public void delete()
        {
            using (Database db = new Database())
            {
                db.admforum.Remove(Curradmin);
                db.SaveChanges();
                get();
            }
        }
    }
}
