﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp27
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var db = new Database()) ;
        }

        private void student_Click(object sender, RoutedEventArgs e)
        {
            var Window1 = new StudentLoginWindow();
            Window1.Show();
        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {
            var Window2 = new AdminLoginWindow();
            Window2.Show();
        }
    }
}
