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

namespace WpfApp27
{
    /// <summary>
    /// Interaction logic for AdminLoginWindow.xaml
    /// </summary>
    public partial class AdminLoginWindow : Window
    {
        public AdminLoginWindow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            var Un = aUsrname.Text;
            var Pw = aPasswrd.Password;

            using (Database db = new Database())
            {

                bool result = db.loginadmin.Any(user => user.aUsername == Un && user.aPassword == Pw);

                if (result)
                {
                    grantaccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }


            }


        }
        public void grantaccess()
        {
            AdminView adminView = new AdminView();
            adminView.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Studentpass stdpass = new Studentpass();
            stdpass.Show();
        }
    }
}
