using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp27.View;

namespace WpfApp27
{
    /// <summary>
    /// Interaction logic for StudentLoginWindow.xaml
    /// </summary>
    public partial class StudentLoginWindow : Window
    {
        public StudentLoginWindow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            var uname = usrname.Text;
            var pw = Password.Password;

            using(Database db = new Database())
            {
                bool results = db.studetails.Any(user => user.Username == uname && user.Password == pw);

                if(results)
                {
                    access();
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        }

        public void access()
        {

            StudentAcceptView std = new StudentAcceptView();
            std.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentRegister studentRegister = new StudentRegister();
            studentRegister.Show();
        }
    }
}
