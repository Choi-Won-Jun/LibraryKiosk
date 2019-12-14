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
    /// FPLoginPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FPLoginPage : Page
    {

        private bool FPButtonActivated;

        public FPLoginPage()
        {
            InitializeComponent();
            FPButtonActivated = false;  // 지문 버튼을 클릭해서 좌석예약 페이지로 가는 것을 막아놓음. ( 지문 인식 후, true로 바뀜 )
        }

        private void BackToMain(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        /*
         *  [지문 인식]
         *  - 지문 인식 성공 시, 페이지 상의 지문 버튼을 클릭하여 좌석 예약 페이지로 이동하게 한다.
         *  - DB 
         *  - CheckFP() : 아두이노의 지문인식 모듈과 연동되어야 할 함수
         *  - GotoSRP_Click() : 지문버튼 클릭 시 수행되는 이벤트 리스너, 페이지가 초기화될 때, FPButtonActivated값이 false로, 아두이노 연동 함수인 CheckFP()를 호출한 뒤
         *  버튼이 활성화되도록 하였음.
         */
         
        private void CheckFP()  // Check FingerPrint : 아두이노 연동 함수
        {
            bool FPinserted = false;
            // DB Logic ( Insert FP into DB )
            // FPinserted = (아두이노 모듈 연동 함수) :
            FPinserted = true;

            if(FPinserted)  // 지문 등록이 성공하면
            {
                FPText.Text = "    지문등록 성공!";   // 공백은 View의 자연스러움을 위해 추가한 것
                FPButtonActivated = true;
            }
        }
        
        private void GotoSRP_Click(object sender, RoutedEventArgs e)
        {
            if (FPButtonActivated == true)
                NavigationService.Navigate(new Uri("SeatReservationPage.xaml", UriKind.Relative));
        }




    }
}
