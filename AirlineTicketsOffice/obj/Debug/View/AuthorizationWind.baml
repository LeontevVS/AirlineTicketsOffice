   M S B A M L   `   `   `  ����O  KAirlineTicketsOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AirlineTicketsOffice.ViewAirlineTicketsOffice.View  5   	   1    +AirlineTicketsOffice.View.AuthorizationWind   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AirlineTicketsOffice.View     5   	   X TXceed.Wpf.Toolkit, Version=4.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  AuthorizationWind��5	   	   $	��400��6#   $	��500��60    � 
ResizeMode$ NoResize=�6<    � WindowStartupLocation$ CenterScreen=�6R    � WindowStyle$
 None=�6w   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��Авторизация��6   $��40(�6'   $��Center=�5      $��Center=�61   (  "Xceed.Wpf.Toolkit.WatermarkTextBox  5   
   -   5          Name$ tbName��5       $��1��5       $��25��5       $	��400��6,      	Watermark$ Имя��5       $��Center=�60   ,  &Xceed.Wpf.Toolkit.WatermarkPasswordBox  5   
   -   5          Name$ 
pbPassword��5   $   $��2��5   $   $��25��5   $   $	��400��60   $ Пароль��5   $   $��Center=�67   �� 5   
   -   5        	 ��Name$	 btnClose��5      $��3��6:   $��50,0,0,0q�6G   $��25��6Y   $��70��6e   $��Закрыть��6p   $
��Left=�6�   �� 5   
   -   5        $	 btnLogin��5      $��3��6:   $��0,0,50,0q�6G   $��25��6Y   $��70��6e   $��
Войти��6p   $��Right=�6�   5       5!      