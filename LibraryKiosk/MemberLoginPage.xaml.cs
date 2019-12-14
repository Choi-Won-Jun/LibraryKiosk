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
    /// MemberLoginPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MemberLoginPage : Page
    {
        public MemberLoginPage()
        {
            InitializeComponent();
        }

        private void BackToMain(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        private void Submit(object sender, RoutedEventArgs e)
        {

            // 로그인 성공 여부를 담는 변수
            bool InfoValid = false;

            // If Login Failed.
            // Back-End 로직 필요 ( DB 접근 or 파일 입출력 )
            

            if (!InfoValid)
                NavigationService.Navigate(new Uri("SeatReservationPage.xaml", UriKind.Relative));  // 좌석 예약 페이지로 이동
            else
                LoginFailedLabel.Visibility = Visibility.Visible;   // 로그인 실패 메시지 띄움.
        }
    }
}
