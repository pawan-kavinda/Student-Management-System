using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp27.Model;
namespace WpfApp27
{
    /// <summary>
    /// Interaction logic for Studentpass.xaml
    /// </summary>
    public partial class Studentpass : Window
    {
        public Studentpass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (Database db = new Database())
            {
                var uname = username.Text;
                var passwordd = psword.Text;

                Admindetailslogin admindetailslogin = new Admindetailslogin();
                {
                    admindetailslogin.aPassword = passwordd;
                    admindetailslogin.aUsername = uname;
                }

                db.loginadmin.Add(admindetailslogin);
                db.SaveChanges();
                Close();
            }
        }

             
    }
}
