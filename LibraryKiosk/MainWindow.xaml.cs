using Microsoft.Win32;
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

namespace LibraryKiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        // [경희대학생 로그인] 클릭 시
        private void KHU_Register_Click(object sender, RoutedEventArgs e)
        {
            // 새창 띄우기
            // Window win2 = new Window();
            // win2.Show();

            Page page = new Page();
            page.Title = "testPage";
            this.Content = page;

        }

        // [비회원으로 로그인] 클릭 시
        private void FP_Register_Click(object sender, RoutedEventArgs e)
        {
            Page page = new Page();
            page.Title = "testPage";
            this.Content = page;
        }

        /*
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";
            if( op.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }
        }
        */
    }
}
