using System;
using System.Collections.Generic;
using System.Text;
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
    /// MainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // [경희대학생 로그인] 클릭 시
        private void KHU_Register_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("MemberLoginPage.xaml", UriKind.Relative));
        }

        // [비회원으로 로그인] 클릭 시
        private void FP_Register_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("FPLoginPage.xaml", UriKind.Relative));
        }


    }
}
