   M S B A M L   `   `   `  ����O  KAirlineTicketsOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AirlineTicketsOffice.ViewAirlineTicketsOffice.View  5   	   )    #AirlineTicketsOffice.View.LinerWind   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AirlineTicketsOffice.View     5   	   X TXceed.Wpf.Toolkit, Version=4.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  	LinerWind��5	   	   $	��300��6   $	��900��6(    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6r    � 
ResizeMode$ NoResize=�6�    � Topmost . .��5
      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      �� 5      �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      �� 5      $	��150 �6   �� 5      .+�5   
   �� $��0��6   $��4��6!   $��Самолёт��65   $��40(�6D   $��Center=�6R   $��Center=�6o   �� 5   
   $��1��6   $��0��6!   $��Center=�61   $��Center=�6N   $��Наименование��6i   �� 5   
   $��2��6   $��0��6!   $��Center=�61   $��Center=�6N   $#��Количество мест��6i   �� 5   
   $��1��6   $��2��6!   $��Center=�61   $��Center=�6N   $'��!Дата изготовления��6i   �� 5   
   $��2��6   $��2��6!   $��Center=�61   $��
Места��6N   $��Center=�6[   �� 5   
   -   5         ��Name$ tbAirlinerName��5      $��1��6*   $��1��6:   $��20��6G   $	��250��6S    �� TextAlignment$
 Left=�6_   	 �� 	MaxLength$	 50��6t   ��6�   �� *AirlinerName+%  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -   5        
  Name$
 iudPassengerCapacity��5      $��1��6;   $��2��6K   $��20��6X   $	��250��6d   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   TextAlignment$
 Left=�6p   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 0X�6�      Value 6�   �� *PassengerCapacity+6�   &   Xceed.Wpf.Toolkit.DateTimePicker  5   
   -   5          Name$ dpProductionDate��5      $��3��6Y   $��1��6i   $��25��6v   $	��250��6�   $��Center=�6�      
TimeFormat$ 	ShortDate=�6�   $
 Left=�6�   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ 	ShortDate=�6�      TimePickerAllowSpin .  "   TimePickerShowButtonSpinner .  �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 68   �� *ProductionDate+6  �� 5    
   -   5         ��Name$ btnCreateSeats��5       $��2��6F   $��3��6S   $��Создать��6c   $��30��6u   $	��150��6�   �� 5!   
   $��4��6   $��30��5"      $��4��5#       �� Orientation$ 
Horizontal=�5$      $��Center=�5%      .+�5&      �� -   5        $ BtnSave��5)      $��Сохранить��5&      $	��100��5'      $��30��5(      $��0,0,5,0q�5+      �� 5,      -   5        $ BtnClose��5/      $��Закрыть��5,      $	��100��5-      $��30��5.      $��5,0,5,0q�51      �� 52      -   5        $ BtnSaveAndClose��55      $*��$Сохранить и закрыть��52      $	��130��53      $��30��54      $��5,0,0,0q�57      58      59      5:      