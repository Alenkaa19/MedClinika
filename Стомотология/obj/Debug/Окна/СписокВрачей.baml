   M S B A M L   `   `   `  ����S  OСтомотология, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:СтомотологияСтомотология  5      U/clr-namespace:Стомотология.Commands!Стомотология.Commands  5      c6clr-namespace:Стомотология.ValidationRules(Стомотология.ValidationRules  5      7    1Стомотология.СписокВрачей   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Стомотология     5      Ccommand/clr-namespace:Стомотология.Commands     5      Grule6clr-namespace:Стомотология.ValidationRules     5      -   5          � Title$   ��5      $	��650��6   $	��333��6    � Icon$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\hospital-4_icon-icons.com_66060.png��6)    � WindowStyle$ 
ToolWindow=�6�    � WindowStartupLocation$ CenterScreen=�6�   
�����F� J� OpacityMask
 ���F���5      �� 5   
    �� ImageSource$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .��5      �� $��3q�6    J� RenderTransformOrigin$ 0.493,0.824&�6   .+�5   
   o� ��5      �� 5      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .@�5      m� $��15(�6   $��Italic$�6%   $
��Bold"�68   $��Действие��6J   
�����F�.@�5      m� $��Italic$�6   $
��Bold"�6.   $��Отменить��6@    m� Command$
 Undo��6R   6d   �� 5      6   m� 5      $��Italic$�6   $
��Bold"�6.   $��Создать��6@   $	 New��6Q   6b   m� 5      $��Italic$�6   $
��Bold"�6.   $ ��Редактировать��6@   4   .Стомотология.Commands.DataCommands   Edit# Z 6W   6�   m� 5      $��Italic$�6   $
��Bold"�6.   $��Сохранить��6@   $
 Save��6S   6d   m� 5      $��Italic$�6   $
��Bold"�6.   $��
Найти��6@   $
 Find��6O   �� 5      6   m� 5      $��Italic$�6   $
��Bold"�6.   $��Удалить��6@   	   Delete# Z	 6Q   6�   m� 5      $��Italic$�6   $
��Bold"�6.   $��Обновить��6@   $ Refresh��6R   5      5      �� 5    
   $
��Bold"�6   $��Italic$�6&   $��20(�69   $��5q�6G   
�����F�Список врачей6y   &   System.Windows.Controls.DataGrid  5"   
   -   5        
  Name$
 DataGridBol��5"         AutoGenerateColumns .  $
��Left=�5%         RowBackground
 ���F�   AlternatingRowBackground �	#FFA1D2FA
�����F�$��3q�5)      $
��Bold"�5*         	RowHeight$ 25Q�5+         
IsReadOnly .   � Cursor$
 Hand��5-      $	��150��6   $	��607��6(   ���	#FFA1D2FA��5#      ��    Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 50      �� *Фамилия+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  51      $ Имя��6%    52      �� *Имя+$ TwoWay=�$ PropertyChanged=�  53      $ Отчество��6%    54      �� *Отчество+$ TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  55      -   5        Po��$ Категория��55   5      DisplayMemberPath$ Категория��56         SelectedValuePath$ Категория��6�      
IsReadOnly .     SelectedValueBinding 63   ��  �� Path$ Категория�$ TwoWay=�$ PropertyChanged=�6�     57      -   5        Poo��$  Специальность��57   6   $  Специальность��58      $  Специальность��6�    .   67   �� $  Специальность�$ TwoWay=�$ PropertyChanged=�6�     59      $ Расписание��6%    5:      �� *Расписание+$ TwoWay=�$ PropertyChanged=�5<       � 5=   
   -   5          �Name$ 
BorderFind��5=      $��617,-160,9.4,-300q�6%   $y�Hidden=�6@   $	��130��6T   ��5>      �� 5?       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5@      �  � Color$ #7FFF00��6#    � Offset$ 0Q�63   � 5A      $ #00FFFF��6#   $	 0.7Q�63   5B      ��5D      � 5E      -   5          �Name$  gridFind��5E      $��
0,10,0,-10q�6)   ! � RowDefinitions! 5F      �� 5G      $	��0.6 �6(   �� 5H      $
��Auto �6(   �� 5I      $��40 �6(   �� 5J      $��40 �6(   " � ColumnDefinitions" 5L      �� 5M      $��0 �6+   �� 5N      $	��23* �6+   �� 5O      $	��91* �6+   �� 5P      $��70 �6+   .+�5R      �� -   5        # ��Name$# TextBlockSearch��5R   =   $��2��6    $��0��60   $��
Поиск��6V   $
��Left=�6c   $
��Bold"�6~   $��79.8,0,0,1.6q�6�   $ 0.033,0.506&�6�   $��36��5S       $��2��6+   �� 5T      -   5        $# TextBlockSurname��5T   =   $��1��6    $��2��60   $��Фамилия��6W   $
��Left=�6f   $��Bottom=�6�   $��5,0,0,10q�6�   $��2��6�   �� 5U      -	   5        $# TextBlockGender��5U   =   $��1��6    $��3��60   $
��Left=�6V   $��Bottom=�6q   $��	0,0,0,9.8q�6�   $��2��5V       $��31��64   $��68��6@   �� 6L   $ �Специальность��6P   6h   �� 5W      -
   5        $ ��Name$$ TextBoxSurname��5W   ;   $��2��6   $��2��6.   $��30.6,14.8,10.6,0q�6|   �� 5X      -   5        % ��Name$% ComboBoxTitle��5X      & �� DisplayMemberPath$ & Специальность��67   $��30.6,7,10.6,9.8q�6�   $��3��6�   $��2��6�   �� 5Y      -   5        ' ��Name$' ButtonFindSurname��5Y   :   $��3��6   $��2��6-   ( � ToolTip$$( Поиск по фамилии��6U   {�.  $��10.4,14.8,17,0q�6�   .��5Z      �� $8��2/Фотографии/free-icon-search-4197908.png��6    $��20��6R   $��21��6]   5[      �� 5\      -   5        $' ButtonFindTitle��5\      $0( *Поиск по специальности��66   {�.  $��10.4,7,17,9.8q�6�   $��3��6�   $��3��6�   .��5]      �� $8��2/Фотографии/free-icon-search-4197908.png��6    $��20��6R   $��21��6]   5^      5_      5a      �� 5b   
   -   5        $��
Назад��5b      $��17,-230,-400,-300q�6!   $	��163��6<   $��40��6H   $  ��6T   ��5c      �� 5d      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   ) j� Stretch$
) None=�6�   5f      5g      * J� CommandBindings* 5h      )  #System.Windows.Input.CommandBinding  5i   
   -   5        +   Command$
+ Undo��5i      6O     5j   
   -   5        $	+ New��5j      6M     5k   
   -   5        $
+ Save��5k      6O     5l   
   -   5        $
+ Find��5l      6O     5m   
   -   5        #+ Z	 5m      6s     5n   
   -   5        #+ Z 5n      6o     5o   
   -   5        $+ Refresh��5o      6+   5q      