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
    /// FinishedPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FinishedPage : Page
    {
        public FinishedPage()
        {
            InitializeComponent();

            TokenLabel.Content = makeToken();
        }

        // public FinishedPage(Object obj) : 생성자를 따로 정의함으로써 이전 페이지( 좌석 예약 페이지 )에서 데이터를 받아올 수 있다.

        private String makeToken()
        {
            // Do Some Logic
            return "3joJJang";
        }

        private void BackToMain(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }


    }
}
