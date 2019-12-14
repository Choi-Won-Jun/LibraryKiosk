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
    /// SeatReservationPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SeatReservationPage : Page
    {
        // 테이블 2개, 각각 좌석이 10개씩이라고 가정
        private static bool[,] seatsReserved = new bool[2, 10];
        // 추후, DB와의 연동/파일입출력을 통한 초기화 작업 ( 아래의 SetSeatColor() 함수로 프로토타입을 구현하였음. )

        private static int prevSeatNum;    // 한 번에 하나의 의자만 선택하기 위해 추가한 변수 ( Reserve_Seat() 함수에서 사용 )


        private void SetSeatColor()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // DB 로직 추가 할 것, 파일을 불러와서 그 내용에 맞게 seatsReserved 값들이 초기화되어야할 것임.
                    Button button = (Button)FindName("SEAT_" + (10 * i + j + 1).ToString());    // SEAT_1 ~ SEAT_20, FindByName 
                    if ( seatsReserved[i, j] == true )
                        button.Background = Brushes.Red;
                    else
                        button.Background = Brushes.Green;
                }
            }
        }

        public SeatReservationPage()
        {
            InitializeComponent();
            SetSeatColor();
            prevSeatNum = -1;
        }
        // public SeatReservationPage(UserInfo userInfo)
        // 페이지 생성 시, 생성자를 여러 개 두어서 페이지간의 데이터 이동을 가능하게 할 수 있음.
        // 상황에 맞게 페이지를 로드할 수 있음. ( 1. 경희대 사용자 로그인 후, 좌석 예약 페이지로 이동한 상황  / 2. 지문인식 사용자 로그인 후, 좌석 예약 페이지로 이동한 상황 )        
        // UserInfo는 사용자 정의 클래스, 어떤 데이터가 올 지 몰라 따로 정의하지 않았음. 


        private void BackToMain(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        private void Reserve_Seat(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            String seatNumber = (String)clickedButton.CommandParameter;  // 파일 입출력할 때 ( or DB ), 사용할 것 ( 의자 좌석 번호 )

            if (prevSeatNum < 0)    // 처음 버튼 클릭할 때
            {
                prevSeatNum = int.Parse(seatNumber);
                clickedButton.Background = Brushes.Red;
                Submitbtn.Visibility = Visibility.Visible;
            }
            else        
            {                      // 지속적인 버튼 클릭할 때
                Button prevButton = (Button)FindName("SEAT_" + prevSeatNum.ToString());
                prevButton.Background = Brushes.Green;
                clickedButton.Background = Brushes.Red;
                prevSeatNum = int.Parse(seatNumber);
            }
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("FinishedPage.xaml", UriKind.Relative));
        }
    }
}
