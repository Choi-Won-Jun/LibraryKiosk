   M S B A M L   `   `   `  ����G  CLibraryKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LibraryKioskLibraryKiosk  5          LibraryKiosk.MainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:LibraryKiosk     5      $	��450��5      $	��800��6     N� Title$  MainPage��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��13* �6   �� 5      $	��30* �6   �� 5      $	��13* �6   �� 5      $	��30* �6   �� 5      $	��13* �6    � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��80* �6   .+�5   
   �� -   5        $��Intro��5      $	��Top=�6!   $
��Left=�69   $��50��6T   $
��Auto��6`   $6��0경희대학교 도서관 좌석예약 시스템��6m   $��20(�6�      verDena#��[  6�   $��	121,0,0,0q�6�   $��1��6�   $��3��6�   $��1��6�   �� 5   
   -   5        $��btn_KHU_Register��5   �   $��1��6   $��1��6"   $
��Left=�6/   $��Center=�6J   
������ $��0q�6~   .��5       �� .��5!      ��  �� Orientation$ Vertical=�6   $
��Auto��64   $
��Left=�6A   .+�5"      �� $2��,pack://application:,,,/Resource/KyungHee.png��6   $	��200��6R   $	��150��6^   �� 5#      $!��[경희대학생 로그인]��6    $��Center=�63   $��Center=�6N   $��50��6k   $
��Auto��6w   $��25(�6�   #��[  6�   5$      5%      5&      �� 5*   
   -   5        $��btn_FP_Register��5*   �   $��3��6   $��1��6!   $
��Left=�6.   $��Center=�6I   
������ $��0q�6}   .��5+      �� .��5,      �� $ Vertical=�6   $
��Auto��64   $
��Left=�6A   .+�5-      �� $5��/pack://application:,,,/Resource/fingerprint.png��6   $	��200��6U   $	��150��6a   �� 5.      $!��[비회원으로 로그인]��6    $��Center=�63   $��Center=�6N   $��50��6k   $
��Auto��6w   $��25(�6�   #��[  6�   5/      50      51      52      53      