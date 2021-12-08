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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VPnote01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //if ( (note01_border.Visibility == Visibility.Visible) || (note02_border.Visibility == Visibility.Visible) || 
            //    (note03_border.Visibility == Visibility.Visible) || (note04_border.Visibility == Visibility.Visible) || 
            //    (note05_border.Visibility == Visibility.Visible) || (note06_border.Visibility == Visibility.Visible))
            //{
            //    txt_nofav.Visibility = Visibility.Collapsed;
            //    txt_nosave.Visibility = Visibility.Collapsed;
            //}
            //else
            //{

            //    txt_nofav.Visibility = Visibility.Visible;
            //    txt_nosave.Visibility = Visibility.Visible;
            //}
            

        }




        private void btn_save_Click(object sender, RoutedEventArgs e)
        {

            if (txt_title.Text == savednote01T.Text)
            {
                savednote01.Text = txt_notepad.Text;
                savednoteFav01.Text = txt_notepad.Text;
            }
            else if (txt_title.Text == savednote02T.Text)
            {
                savednote02.Text = txt_notepad.Text;
                savednoteFav02.Text = txt_notepad.Text;
            }
            else if (txt_title.Text == savednote03T.Text)
            {
                savednote03.Text = txt_notepad.Text;
                savednoteFav03.Text = txt_notepad.Text;
            }
            else if (txt_title.Text == savednote04T.Text)
            {
                savednote04.Text = txt_notepad.Text;
                savednoteFav04.Text = txt_notepad.Text;
            }
            else if (txt_title.Text == savednote05T.Text)
            {
                savednote05.Text = txt_notepad.Text;
                savednoteFav05.Text = txt_notepad.Text;
            }
            else if (txt_title.Text == savednote06T.Text)
            {
                savednote06.Text = txt_notepad.Text;
                savednoteFav06.Text = txt_notepad.Text;
            }
            else
            {



                if (note01_border.Visibility == Visibility.Collapsed)
                {
                    note01_border.Visibility = Visibility.Visible;
                    savednote01.Text = txt_notepad.Text;
                    savednoteFav01.Text = txt_notepad.Text;
                    savednote01T.Text = txt_title.Text;
                    savednoteFav01T.Text = txt_title.Text;
                }
                else if (note02_border.Visibility == Visibility.Collapsed)
                {
                    note02_border.Visibility = Visibility.Visible;
                    savednote02.Text = txt_notepad.Text;
                    savednoteFav02.Text = txt_notepad.Text;
                    savednote02T.Text = txt_title.Text;
                    savednoteFav02T.Text = txt_title.Text;
                }
                else if (note03_border.Visibility == Visibility.Collapsed)
                {
                    note03_border.Visibility = Visibility.Visible;
                    savednote03.Text = txt_notepad.Text;
                    savednoteFav03.Text = txt_notepad.Text;
                    savednote03T.Text = txt_title.Text;
                    savednoteFav03T.Text = txt_title.Text;
                }
                else if (note04_border.Visibility == Visibility.Collapsed)
                {
                    note04_border.Visibility = Visibility.Visible;
                    savednote04.Text = txt_notepad.Text;
                    savednoteFav04.Text = txt_notepad.Text;
                    savednote04T.Text = txt_title.Text;
                    savednoteFav04T.Text = txt_title.Text;
                }
                else if (note05_border.Visibility == Visibility.Collapsed)
                {
                    note05_border.Visibility = Visibility.Visible;
                    savednote05.Text = txt_notepad.Text;
                    savednoteFav05.Text = txt_notepad.Text;
                    savednote05T.Text = txt_title.Text;
                    savednoteFav05T.Text = txt_title.Text;
                }
                else if (note06_border.Visibility == Visibility.Collapsed)
                {
                    note06_border.Visibility = Visibility.Visible;
                    savednote06.Text = txt_notepad.Text;
                    savednoteFav06.Text = txt_notepad.Text;
                    savednote06T.Text = txt_title.Text;
                    savednoteFav06T.Text = txt_title.Text;
                }

            }
            //MessageBox.Show("Note saved");
            tabcontrol.SelectedIndex = 2;
            txt_notepad.Text = "";
            txt_title.Text = "";

            if ((note01_border.Visibility == Visibility.Visible) || (note02_border.Visibility == Visibility.Visible) ||
                (note03_border.Visibility == Visibility.Visible) || (note04_border.Visibility == Visibility.Visible) ||
                (note05_border.Visibility == Visibility.Visible) || (note06_border.Visibility == Visibility.Visible))
                txt_nosave.Visibility = Visibility.Collapsed;
            else
                txt_nosave.Visibility = Visibility.Visible;


            

        }

        private void note01T_clicked(object sender, MouseButtonEventArgs e)
        {
            txt_notepad.Text = savednote01.Text;
            txt_title.Text = savednote01T.Text;
            tabcontrol.SelectedIndex = 1;
        }

        private void note02T_clicked(object sender, MouseButtonEventArgs e)
        {
            txt_notepad.Text = savednote02.Text;
            txt_title.Text = savednote02T.Text;
            tabcontrol.SelectedIndex = 1;
        }

        private void note03T_clicked(object sender, MouseButtonEventArgs e)
        {
            txt_notepad.Text = savednote03.Text;
            txt_title.Text = savednote03.Text;
            tabcontrol.SelectedIndex = 1;
        }

        private void note04T_clicked(object sender, MouseButtonEventArgs e)
        {
            txt_notepad.Text = savednote04.Text;
            txt_title.Text = savednote04T.Text;
            tabcontrol.SelectedIndex = 1;
        }

        private void note05T_clicked(object sender, MouseButtonEventArgs e)
        {
            txt_notepad.Text = savednote05.Text;
            txt_title.Text = savednote05T.Text;
            tabcontrol.SelectedIndex = 1;
        }

        private void note06T_clicked(object sender, MouseButtonEventArgs e)
        {
            txt_notepad.Text = savednote06.Text;
            txt_title.Text = savednote06T.Text;
            tabcontrol.SelectedIndex = 1;
        }

        private void note01B_clicked(object sender, MouseButtonEventArgs e)
        {
            //txt_notepad.Text = savednote01.Text;
            //txt_title.Text = savednote01T.Text;
            //tabcontrol.SelectedIndex = 1;
        }

        private void note02B_clicked(object sender, MouseButtonEventArgs e)
        {
            //txt_notepad.Text = savednote02.Text;
            //txt_title.Text = savednote02T.Text;
            //tabcontrol.SelectedIndex = 1;
        }
        private void note03B_clicked(object sender, MouseButtonEventArgs e)
        {
            //txt_notepad.Text = savednote03.Text;
            //txt_title.Text = savednote03.Text;
            //tabcontrol.SelectedIndex = 1;
        }
        private void note04B_clicked(object sender, MouseButtonEventArgs e)
        {
            //txt_notepad.Text = savednote04.Text;
            //txt_title.Text = savednote04T.Text;
            //tabcontrol.SelectedIndex = 1;
        }
        private void note05B_clicked(object sender, MouseButtonEventArgs e)
        {
            //txt_notepad.Text = savednote05.Text;
            //txt_title.Text = savednote05T.Text;
            //tabcontrol.SelectedIndex = 1;
        }
        private void note06B_clicked(object sender, MouseButtonEventArgs e)
        {
            //txt_notepad.Text = savednote06.Text;
            //txt_title.Text = savednote06T.Text;
            //tabcontrol.SelectedIndex = 1;
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {

            if (txt_title.Text == savednote01T.Text)
            {
                note01_border.Visibility = Visibility.Collapsed;
                noteFav01_border.Visibility = Visibility.Collapsed;
                chk_note01.IsChecked = false;
            }

            else if (txt_title.Text == savednote02T.Text)
            {
                note02_border.Visibility = Visibility.Collapsed;
                noteFav02_border.Visibility = Visibility.Visible;
                chk_note02.IsChecked = false;
            }
            
            else if (txt_title.Text == savednote03T.Text)
            {
                note03_border.Visibility = Visibility.Collapsed;
                noteFav03_border.Visibility = Visibility.Collapsed;
                chk_note03.IsChecked = false;
            }
            else if (txt_title.Text == savednote04T.Text)
            {
                note04_border.Visibility = Visibility.Collapsed;
                noteFav04_border.Visibility = Visibility.Collapsed;
                chk_note04.IsChecked = false;
            }
            else if (txt_title.Text == savednote05T.Text)
            {
                note05_border.Visibility = Visibility.Collapsed;
                noteFav05_border.Visibility = Visibility.Collapsed;
                chk_note05.IsChecked = false;
            }
            else if (txt_title.Text == savednote06T.Text)
            {
                note06_border.Visibility = Visibility.Collapsed;
                noteFav06_border.Visibility = Visibility.Collapsed;
                chk_note06.IsChecked = false;
            }
            //MessageBox.Show("Note deleted");
            tabcontrol.SelectedIndex = 2;

            if ((note01_border.Visibility == Visibility.Visible) || (note02_border.Visibility == Visibility.Visible) ||
                (note03_border.Visibility == Visibility.Visible) || (note04_border.Visibility == Visibility.Visible) ||
                (note05_border.Visibility == Visibility.Visible) || (note06_border.Visibility == Visibility.Visible))
                txt_nosave.Visibility = Visibility.Collapsed;
            else
                txt_nosave.Visibility = Visibility.Visible;


            

        }
        private void ReFav_Click(object sender, RoutedEventArgs e)
        {
            if (chk_note01.IsChecked == true)
            {
                noteFav01_border.Visibility = Visibility.Visible;
            }
            else
            {
                noteFav01_border.Visibility = Visibility.Collapsed;
            }
            if(chk_note02.IsChecked == true)
            {
                noteFav02_border.Visibility = Visibility.Visible;
            }
            else
            {
                noteFav02_border.Visibility = Visibility.Collapsed;
            }
            if (chk_note03.IsChecked == true)
            {
                noteFav03_border.Visibility = Visibility.Visible;
            }
            else
            {
                noteFav03_border.Visibility = Visibility.Collapsed;
            }
            if (chk_note04.IsChecked == true)
            {
                noteFav04_border.Visibility = Visibility.Visible;
            }
            else
            {
                noteFav04_border.Visibility = Visibility.Collapsed;
            }
            if (chk_note05.IsChecked == true)
            {
                noteFav05_border.Visibility = Visibility.Visible;
            }
            else
            {
                noteFav05_border.Visibility = Visibility.Collapsed;
            }
            if (chk_note06.IsChecked == true)
            {
                noteFav06_border.Visibility = Visibility.Visible;
            }
            else
            {
                noteFav06_border.Visibility = Visibility.Collapsed;
            }

            if ((noteFav01_border.Visibility == Visibility.Visible) || (noteFav02_border.Visibility == Visibility.Visible) ||
                (noteFav03_border.Visibility == Visibility.Visible) || (noteFav04_border.Visibility == Visibility.Visible) ||
                (noteFav05_border.Visibility == Visibility.Visible) || (noteFav06_border.Visibility == Visibility.Visible))
                txt_nofav.Visibility = Visibility.Collapsed;
            else
                txt_nofav.Visibility = Visibility.Visible;

            //else if (chk_note02.IsChecked == true)
            //{

            //    if (noteFav02_border.Visibility == Visibility.Visible)
            //        noteFav02_border.Visibility = Visibility.Collapsed;
            //}


            //else if (chk_note03.IsChecked == true)
            //{

            //    if (noteFav03_border.Visibility == Visibility.Visible)
            //        noteFav03_border.Visibility = Visibility.Collapsed;
            //}
            //else if (chk_note04.IsChecked == true)
            //{

            //    if (noteFav04_border.Visibility == Visibility.Visible)
            //        noteFav04_border.Visibility = Visibility.Collapsed;
            //}
            //else if (chk_note05.IsChecked == true)
            //{

            //    if (noteFav05_border.Visibility == Visibility.Visible)
            //        noteFav05_border.Visibility = Visibility.Collapsed;
            //}
            //else if (chk_note06.IsChecked == true)
            //{

            //    if (noteFav06_border.Visibility == Visibility.Visible)
            //        noteFav06_border.Visibility = Visibility.Collapsed;
            //}

            //if (chk_note02.IsChecked == true)
            //    noteFav02_border.Visibility = Visibility.Visible;
            //else
            //    noteFav02_border.Visibility = Visibility.Collapsed;

            //if (chk_note03.IsChecked == true)
            //    noteFav03_border.Visibility = Visibility.Visible;
            //else
            //    noteFav03_border.Visibility = Visibility.Collapsed;

            //if (chk_note04.IsChecked == true)
            //    noteFav04_border.Visibility = Visibility.Visible;
            //else
            //    noteFav04_border.Visibility = Visibility.Collapsed;

            //if (chk_note05.IsChecked == true)
            //    noteFav05_border.Visibility = Visibility.Visible;
            //else
            //    noteFav05_border.Visibility = Visibility.Collapsed;

            //if (chk_note06.IsChecked == true)
            //    noteFav06_border.Visibility = Visibility.Visible;
            //else
            //    noteFav06_border.Visibility = Visibility.Collapsed;
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txt_notepad.Text = "";
            txt_title.Text = "";
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_Executed_2(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void chk_TitleBar_Checked(object sender, RoutedEventArgs e)
        {  
            this.WindowStyle = WindowStyle.SingleBorderWindow;
        }

        private void chk_TitleBar_unChecked(object sender, RoutedEventArgs e)
        {
            this.WindowStyle = WindowStyle.None;
        }

        private void btn_signout_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            win1.Show();
            this.Close();
        }
    }
}
