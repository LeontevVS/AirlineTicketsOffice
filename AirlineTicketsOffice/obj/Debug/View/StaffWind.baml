   M S B A M L   `   `   `  ����O  KAirlineTicketsOffice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AirlineTicketsOffice.ViewAirlineTicketsOffice.View  5   	   )    #AirlineTicketsOffice.View.StaffWind   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:AirlineTicketsOffice.View     5   	   -   5          � Title$  	StaffWind��5   	   $	��400��6   $	��750��6(    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6r    � 
ResizeMode$ NoResize=�6�    � Topmost . .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   �� $��0��6   $��2��6!   $��Сотрудник��65   $��40(�6F   $��Center=�6T   $��Center=�6q   �� 5   
   $��1��6   $��0��6!   $��ФИО��61   $��Center=�6<   $��Right=�6W   �� 5   
   $��2��6   $��0��6!   $��Должность��61   $��Center=�6B   $��Right=�6]   �� 5   
   $��3��6   $��0��6!   $��Экипаж��61   $��Center=�6?   $��Right=�6Z   �� 5   
   -   5         ��Name$ tbName��5      $��20��5      $��1��5      $��1��6    �� 	MaxLength$ 50��5      $	��500��5      ��5      �� *Name+5      �� 5   
   -   5        	 ��Name$	 cbPost��5   1   $��1��6A   $��2��6Q   $��25��6^   $	��500��6j   
 �� SelectedItem
 6   �� *Post+6j   �� 5    
   -   5        $	 cbCrew��5    1   $��1��6A   $��3��6Q   $��25��6^   $	��500��6j   
 6   �� *Crew+��5!      �� 5"      .R�5#      �� ��5$      `� 5%       �� StringFormat$	 {0}��6+   .1�5&   "   ��  �� Path$
 Name�6*   5'      5)      5*      5,      �� 5-   
   $��4��6   $��30��5.      $��4��5/       �� Orientation$ 
Horizontal=�50      $��Center=�51      .+�52      �� -   5         ��Name$ BtnSave��55      $��Сохранить��52      $	��100��53      $��30��54      $��0,0,5,0q�57      �� 58      -   5        $ BtnClose��5;      $��Закрыть��58      $	��100��59      $��30��5:      $��5,0,5,0q�5=      �� 5>      -   5        $ BtnSaveAndClose��5A      $*��$Сохранить и закрыть��5>      $	��130��5?      $��30��5@      $��5,0,0,0q�5C      5D      5E      5F      