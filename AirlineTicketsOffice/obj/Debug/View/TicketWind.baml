   M S B A M L   `   `   `  ����O  KAirlineTicketsOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AirlineTicketsOffice.ViewAirlineTicketsOffice.View  5   	   *    $AirlineTicketsOffice.View.TicketWind   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AirlineTicketsOffice.View     5   	   X TXceed.Wpf.Toolkit, Version=4.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  
TicketWind��5	   	   $	��450��6   $	��900��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6s    � 
ResizeMode$ NoResize=�6�    � Topmost . .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��170 �6   �� 5      �� 5      $	��170 �6   �� 5      .+�5   
   �� $��0,0,10,0q�6   $��Рейс��6&   $��0��62   $��0��6B   $��Center=�6O   $��Center=�6l   �� 5   
   $��0,0,10,0q�6   $��ФИО Пассажира��6&   $��0��6;   $��1��6K   $��Center=�6X   $��Center=�6u   �� 5   
   $��0,0,10,0q�6   $*��$Дата покупки билета��6&   $��0��6A   $��2��6Q   $��Center=�6^   $��Center=�6{   �� 5   
   $��0,0,10,0q�6   $/��)Серия и номер паспорта��6&   $��0��6D   $��3��6T   $��Center=�6a   $��Center=�6~   �� 5   
   $��0,0,10,0q�6   $,��&Дата выдачи паспорта��6&   $��0��6B   $��4��6R   $��Center=�6_   $��Center=�6|   �� 5   
   $��0,0,10,0q�6   $��Цена��6&   $��0��62   $��5��6B   $��Center=�6O   $��Center=�6l   �� 5    
   $��0,0,10,0q�6   $��Номер билета��6&   $��2��6:   $��1��6J   $��Right=�6W   $��Center=�6s   �� 5!   
   $��0,0,10,0q�6   $��
Место��6&   $��2��63   $��2��6C   $��Right=�6P   $��Center=�6l   �� 5"   
   $��0,0,10,0q�6   $,��&Номер билетной кассы��6&   $��2��6B   $��4��6R   $��Right=�6_   $��Center=�6{   �� 5#   
   $��0,0,10,0q�6   $��Кассир��6&   $��2��64   $��5��6D   $��Right=�6Q   $��Center=�6m   �� 5$   
   -   5         ��Name$ 	CBPassage��5$   q   $��25��64   $��0��6@   $��1��6M   $��3��6]    �� SelectedItem 6   �� *	Passage+��5%      �� 5&      .R�5'      �� ��5(      `� 5)      	 �� StringFormat$Q	 K№{0} {1} - Отпр. {2}.{3}.{4} {5}:{6}  Приб. {7}.{8}.{9} {10}:{11}��6+   .1�5*   "   �� 
 �� Path$
 PassageNumber�6*   �� 5+   "   $
 Title�6*   �� 5,   "   $
 Date.Day�6*   �� 5-   "   $
 
Date.Month�6*   �� 5.   "   $
 	Date.Year�6*   �� 5/   "   $
 	Date.Hour�6*   �� 50   "   $
 Date.Minute�6*   �� 51   "   $
 Arrival.Day�6*   �� 52   "   $
 Arrival.Month�6*   �� 53   "   $
 Arrival.Year�6*   �� 54   "   $
 Arrival.Hour�6*   �� 55   "   $
 Arrival.Minute�6*   56      58      59      5;      �� 5<   
   -   5         ��Name$ tbName��5<      $��20��5>      $��1��5?      $��1��6    �� 	MaxLength$ 50��5@      ��5=      �� *PassangerName+5@      &   Xceed.Wpf.Toolkit.DateTimePicker  5A   
   -   5          Name$ DPDate��5A      $��2��5B      $��1��6+   $��Center=�5C      ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   TextAlignment$
 Left=�5D      �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5E      �� *Date+%  Xceed.Wpf.Toolkit.MaskedTextBox  5F   
   -   5          Name$ 
tbPassport��5F      $��20��5H      $��3��5I      $��1��6*   $ 11��5J         Mask$ 0000 000000��5K      ��5G      �� *
Passport+5K        5L   
   -   5        $ DPPassportDate��5L      $��4��5M      $��1��6"   $��Center=�5N      &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ 	ShortDate=�5O   4   $
 Left=�6G      TimePickerAllowSpin .  "   TimePickerShowButtonSpinner .     TimePickerVisibility$ Hidden=�6�      ShowButtonSpinner .     
TimeFormat$ 	ShortDate=�6�      CalendarDisplayMode$ Decade=�6�   5  /Xceed.Wpf.Toolkit.Primitives.DateTimePickerBase   ShowDropDownButton .   6   �� *PassportDate+6  %  Xceed.Wpf.Toolkit.DecimalUpDown  5U   
   -   5          Name$ dudPrice��5U      $��5��6/   $��1��6<   �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   FormatString$ F2��5V   5   $��20��5W      �	  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] 	  ShowButtonSpinner .     	MaxLength$ 12��6C    	  Minimum$ 0X�6R   $
 Left=�6^    	  UpdateValueOnEnterKey .   	  Value  5V      �� *Price+5W   s   �� 5X   
   -   5        $ tbTicket��5X      $��20��5Z      $��1��5[      $��3��6   ��5Y      �� *TicketNumber+5[      �� 5f   
   -	   5        ! ��Name$! tbSeat��5f      $��Не выбрано��6$   $��3��66   $��2��6F   $��Center=�6S   $��Center=�6p   $��15(�6�   �� 5g   
   -
   5        " ��Name$" btnChooseSeat��5g      $��2��6(   $��3��68   $��2��6E   $��Выбор места��6Y   $��25��6o   $	��100��6{   6�   �� 5h   
   -   5        $ tbTill��5h      $��20��5j      $��4��5k      $��3��6   $ 3��5l      ��5i      �� *Till+5l      �� 5m   
   -   5        $ tbUser��5m      $��20��5o      $��5��5p      $��3��6   {�.  ��5n      �� *	User.Name+5p   /   �� 5q   
   $��6��6   $��30��5r      $��4��5s      # �� Orientation$# 
Horizontal=�5t      $��Center=�5u      .+�5v      �� -   5        $" BtnSave��5y      $��Сохранить��5v      $	��100��5w      $��30��5x      $��0,0,5,0q�5{      �� 5|      -   5        $" BtnClose��5      $��Закрыть��5|      $	��100��5}      $��30��5~      $��5,0,5,0q�5�      �� 5�      -   5        $" BtnSaveAndClose��5�      $*��$Сохранить и закрыть��5�      $	��130��5�      $��30��5�      $��5,0,0,0q�5�      5�      5�      5�      