   M S B A M L   `   `   `  ����O  KAirlineTicketsOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AirlineTicketsOffice.ViewAirlineTicketsOffice.View  5   	   )    #AirlineTicketsOffice.View.UsersWind   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AirlineTicketsOffice.View     5   	   -   5          � Title$  	UsersWind��5   	   $	��400��6   $	��750��6(    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6r    � 
ResizeMode$ NoResize=�6�    � Topmost . .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   �� $��0��6   $��2��6!   $��Пользователь��65   $��40(�6I   $��Center=�6W   $��Center=�6t   �� 5   
   $��1��6   $��0��6!   $��ФИО��61   $��Center=�6<   $��Right=�6W   �� 5   
   $��2��6   $��0��6!   $��Пароль��61   $��Center=�6?   $��Right=�6Z   �� 5   
   $��3��6   $��0��6!   $��Роль��61   $��Center=�6=   $��Right=�6X   �� 5   
   -   5         ��Name$ tbName��5      $��20��5      $��1��5      $��1��6    �� 	MaxLength$ 50��5      $	��500��5      ��5      �� *Name+5      �� 5   
   -   5        $ 
tbPassword��5      $��20��5!      $��2��5"      $��1��6   $ 50��5#      $	��500��5$      ��5       �� *
Password+5$      �� 5%   
   -   5        	 ��Name$	 cbRoles��5%   1   $��1��6B   $��3��6R   $��25��6_   $	��500��6k   
 �� SelectedItem
 6   �� *Role+6k   �� 5&   
   $��4��6   $��30��5'      $��4��5(       �� Orientation$ 
Horizontal=�5)      $��Center=�5*      .+�5+      �� -   5         ��Name$ BtnSave��5.      $��Сохранить��5+      $	��100��5,      $��30��5-      $��0,0,5,0q�50      �� 51      -   5        $ BtnClose��54      $��Закрыть��51      $	��100��52      $��30��53      $��5,0,5,0q�56      �� 57      -   5        $ BtnSaveAndClose��5:      $*��$Сохранить и закрыть��57      $	��130��58      $��30��59      $��5,0,0,0q�5<      5=      5>      5?      