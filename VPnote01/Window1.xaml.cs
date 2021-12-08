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

namespace VPnote01
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if ((tbx_username.Text == "shayan" && tbx_password.Text == "shayan12")|| (tbx_username.Text == "hassan" && tbx_password.Text == "hassan12"))
            {
                //Window1 win1 = new Window1();
                //win1.Close();
                MainWindow mwin = new MainWindow();
                mwin.Show();
                this.Close();
            }
            else
                MessageBox.Show("Incorrect Username/Password");
        }

        private void btn_exitlogin_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
