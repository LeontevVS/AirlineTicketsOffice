   M S B A M L   `   `   `  ����O  KAirlineTicketsOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AirlineTicketsOffice.ViewAirlineTicketsOffice.View  5   	   +    %AirlineTicketsOffice.View.PassageWind   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AirlineTicketsOffice.View     5   	   X TXceed.Wpf.Toolkit, Version=4.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  PassageWind��5	   	   $	��450��6   $	��900��6*    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$
 None=�6u    � 
ResizeMode$ NoResize=�6�    � Topmost . .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $��80 �6   �� 5      $��80 �6   �� 5      $��80 �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      �� 5      $	��120 �6   �� 5      .+�5   
   �� $��Center=�6   $��Center=�61   $��4��6L   $��0��6`   $��Рейс��6m   $��40(�6y   �� 5   
   $��Center=�6   $��Center=�61   $��0��6L   $��1��6\   $!��Название рейса��6i   �� 5   
   $��Center=�6   $��Center=�61   $��0��6L   $��2��6\   $��Номер рейса��6i   �� 5   
   $��Center=�6   $��Center=�61   $��0��6L   $��3��6\   $��Самолет��6i   �� 5   
   $��Center=�6   $��Center=�61   $��2��6L   $��1��6\   $%��Дата отправления��6i   �� 5   
   $��Center=�6   $��Center=�61   $��2��6L   $��2��6\   $��Дата прибытия��6i   �� 5   
   $��Center=�6   $��Center=�61   $��2��6L   $��3��6\   $��Экипаж��6i   �� 5   
   -   5         ��Name$ tbTitle��5      $��1��6#   $��1��63   $��20��6@    �� TextAlignment$
 Left=�6L   	 �� 	MaxLength$	 50��6a   ��6p   �� *Title+%  Xceed.Wpf.Toolkit.IntegerUpDown  5    
   -   5        
  Name$
 iudPassageNumber��5       $��1��67   $��2��6G   $��20��6T   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   TextAlignment$
 Left=�6`   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 0X�6u      Value 6�   �� *PassageNumber+�� 5!   
   -   5         ��Name$ cbLiner��5!      $��1��6$   $��3��64   $��20��6A   $
��Left=�6M    �� SelectedItem 6o   �� *Liner+��5"      �� 5#      .R�5$      �� ��5%      `� 5&       �� StringFormat$C ={0} - Вместимость: {1} - Произведен: {2}��6+   .1�5'   "   ��  �� Path$ AirlinerName�6*   �� 5(   "   $ PassengerCapacity�6*   �� 5)   "   $ ProductionDate�6*   5*      5,      5-      5/      &   Xceed.Wpf.Toolkit.DateTimePicker  50   
   -   5          Name$ dpDate��50      $��3��6.   $��1��6>   $��20��6K   $
 Left=�6W   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�6�      FormatString$ dd.MM.yyyy HH:mm��6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 6l   �� *Date+6�     51   
   -   5        $ 	dpArrival��51      $��3��61   $��2��6A   $��20��6N   $
 Left=�6Z   $ Custom=�6�   $ dd.MM.yyyy HH:mm��6�    6o   �� *	Arrival+6�   �� 52   
   -   5        $ cbCrew��52      $��3��6#   $��3��63   $��20��6@   $
��Left=�6L    6n   �� *Crew+��53      �� 54      .R�55      �� ��56      `� 57      $	 {0}��6+   .1�58   "   �� $
 Name�6*   59      5;      5<      5>      �� 5?   
   $��5��6   $��30��5@      $��4��5A       �� Orientation$ 
Horizontal=�5B      $��Center=�5C      .+�5D      �� -   5         ��Name$ BtnSave��5G      $��Сохранить��5D      $	��100��5E      $��30��5F      $��0,0,5,0q�5I      �� 5J      -	   5        $ BtnClose��5M      $��Закрыть��5J      $	��100��5K      $��30��5L      $��5,0,5,0q�5O      �� 5P      -
   5        $ BtnSaveAndClose��5S      $*��$Сохранить и закрыть��5P      $	��130��5Q      $��30��5R      $��5,0,0,0q�5U      5V      5W      5X      