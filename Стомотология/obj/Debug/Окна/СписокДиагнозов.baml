   M S B A M L   `   `   `  ����S  OСтомотология, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:СтомотологияСтомотология  5      U/clr-namespace:Стомотология.Commands!Стомотология.Commands  5      c6clr-namespace:Стомотология.ValidationRules(Стомотология.ValidationRules  5      =    7Стомотология.СписокДиагнозов   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Стомотология     5      Ccommand/clr-namespace:Стомотология.Commands     5      Grule6clr-namespace:Стомотология.ValidationRules     5      -   5          � Title$   ��5      $	��350��6   $	��295��6    � Icon$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\hospital-4_icon-icons.com_66060.png��6)    � WindowStyle$ 
ToolWindow=�6�    � WindowStartupLocation$ CenterScreen=�6�   
�����F� J� OpacityMask
 ���F���5      �� 5   
    �� ImageSource$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .��5      �� $��3q�6    J� RenderTransformOrigin$ 0.493,0.824&�6   .+�5   
   o� ��5      �� 5      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .@�5      m� $��15(�6   $��Italic$�6%   $
��Bold"�68   $��Действие��6J   
�����F�.@�5      m� $��15(�6   $��Italic$�6)   $
��Bold"�6<   $��Отменить��6N    m� Command$
 Undo��6`   6r   �� 5      6   m� 5      $��15(�6   $��Italic$�6)   $
��Bold"�6<   $��Создать��6N   $	 New��6_   6p   m� 5      $��15(�6   $��Italic$�6)   $
��Bold"�6<   $ ��Редактировать��6N   4   .Стомотология.Commands.DataCommands   Edit# Z 6e   6�   m� 5      $��15(�6   $��Italic$�6)   $
��Bold"�6<   $��Сохранить��6N   $
 Save��6a   6r   m� 5      $��15(�6   $��Italic$�6)   $
��Bold"�6<   $��
Найти��6N   $
 Find��6]   �� 5      6   m� 5      $��15(�6   $��Italic$�6)   $
��Bold"�6<   $��Удалить��6N   	   Delete# Z	 6_   6�   m� 5      $��15(�6   $��Italic$�6)   $
��Bold"�6<   $��Обновить��6N   $ Refresh��6`   5      5      �� 5    
   $
��Bold"�6   $��Italic$�6&   $��20(�69   $��5q�6G   
�����F�!Список диагнозов6|   &   System.Windows.Controls.DataGrid  5"   
   -   5        
  Name$
 DataGridBol��5"         AutoGenerateColumns .  $
��Left=�5%         RowBackground
 ���F�   AlternatingRowBackground �	#FFA1D2FA
�����F�$
��Bold"�5)      $��3q�5*         	RowHeight$ 25Q�5+         
IsReadOnly .   � Cursor$
 Hand��5-      $	��150��6   ���	#FFA1D2FA��5#      ��    Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ КодДиагноза��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 50      �� *КодДиагноза+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  51      $ Наименование��6%    52      �� *Наименование+$ TwoWay=�$ PropertyChanged=�54       � 55   
   -   5          �Name$ 
BorderFind��55      $��617,-160,9.4,-300q�6%   $y�Hidden=�6@   $	��130��6T   ��56      �� 57       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��58      �  � Color$ #7FFF00��6#    � Offset$ 0Q�63   � 59      $ #00FFFF��6#   $	 0.7Q�63   5:      ��5<      � 5=      -   5         �Name$ gridFind��5=      $��
0,10,0,-10q�6)    � RowDefinitions 5>      �� 5?      $	��0.6 �6(   �� 5@      $
��Auto �6(   �� 5A      $��40 �6(   �� 5B      $��40 �6(    � ColumnDefinitions 5D      �� 5E      $��0 �6+   �� 5F      $	��23* �6+   �� 5G      $	��91* �6+   �� 5H      $��70 �6+   .+�5J      �� -   5         ��Name$ TextBlockSearch��5J   =   $��2��6    $��0��60   $��
Поиск��6V   $
��Left=�6c   $
��Bold"�6~   $��79.8,0,0,1.6q�6�   $ 0.033,0.506&�6�   $��36��5K       $��2��6+   �� 5L      -   5        $ TextBlockSurname��5L   =   $��1��6    $��2��60   $��Наименование��6W   $
��Left=�6k   $��Bottom=�6�   $��5,0,0,10q�6�   $��2��6�   �� 5M      -   5         ��Name$ TextBoxSurname��5M   ;   $��2��6   $��2��6.   $��30.6,14.8,10.6,0q�6|   �� 5N      -   5          ��Name$  ButtonFindSurname��5N   :   $��3��6   $��2��6-   ! � ToolTip$.! (Поиск по Наименованию��6U   {�.  $��10.4,14.8,17,0q�6�   5P      5R      5T      �� 5U   
   -	   5        $��
Назад��5U      $��-180,-250,-400,-300q�6!   $	��101��6>   $��40��6J   $  ��6V   ��5V      �� 5W      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   " j� Stretch$
" None=�6�   5Y      5Z      # J� CommandBindings# 5[      )  #System.Windows.Input.CommandBinding  5\   
   -
   5        $   Command$
$ Undo��5\      6O     5]   
   -   5        $	$ New��5]      6M     5^   
   -   5        $
$ Save��5^      6O     5_   
   -   5        $
$ Find��5_      6O     5`   
   -   5        #$ Z	 5`      6s     5a   
   -   5        #$ Z 5a      6o     5b   
   -   5        $$ Refresh��5b      6+   5d      