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
   
    public partial class StudentAcceptView : Window
    {
        private List<AdminforumModel> stdlist;

        public StudentAcceptView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(Database db = new Database())
            {
                stdlist = db.admforum.ToList();
                list.ItemsSource = stdlist;
            }
        }
    }
}
