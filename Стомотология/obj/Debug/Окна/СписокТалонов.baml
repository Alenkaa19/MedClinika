   M S B A M L   `   `   `  ����S  OСтомотология, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:СтомотологияСтомотология  5      U/clr-namespace:Стомотология.Commands!Стомотология.Commands  5      c6clr-namespace:Стомотология.ValidationRules(Стомотология.ValidationRules  5      9    3Стомотология.СписокТалонов   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Стомотология     5      Ccommand/clr-namespace:Стомотология.Commands     5      Grule6clr-namespace:Стомотология.ValidationRules     5      -   5          � Title$   ��5
      $	��650��6   $	��295��6    � Icon$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\hospital-4_icon-icons.com_66060.png��6)    � WindowStyle$ 
ToolWindow=�6�    � WindowStartupLocation$ CenterScreen=�6�   ��5      �� 5   
    �� ImageSource$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .��5      �� $��3,3,3,55q�6    J� RenderTransformOrigin$ 0.493,0.824&�6$   .+�5   
   o� ��5      �� 5      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6!   .@�5      m� $��Italic$�6   $
��Bold"�6*   $��Действие��6<   
�����F�.@�5      m� $��Italic$�6   $
��Bold"�6.   $��Отменить��6@    m� Command$
 Undo��6R   6d   �� 5      6   m� 5      $��Italic$�6   $
��Bold"�6.   $��Создать��6@   $	 New��6Q   6b   m� 5      $��Italic$�6   $
��Bold"�6.   $ ��Редактировать��6@   4   .Стомотология.Commands.DataCommands   Edit# Z 6W   6�   m� 5      $��Italic$�6   $
��Bold"�6.   $��Сохранить��6@   $
 Save��6S   6d   m� 5      $��Italic$�6   $
��Bold"�6.   $��
Найти��6@   $
 Find��6O   �� 5      6   m� 5      $��Italic$�6   $
��Bold"�6.   $��Удалить��6A      Delete# Z 6R   6�   m� 5      $��Italic$�6   $
��Bold"�6.   $��Обновить��6@   $ Refresh��6R   5      5      &   System.Windows.Controls.DataGrid  5!   
   -   5        	  Name$	 DataGridBol��5!      
   AutoGenerateColumns
 .  $
��Left=�5$         RowBackground
 ���F�   AlternatingRowBackground �	#FFA1D2FA
�����F�$��3q�5(      $
��Bold"�5)         	RowHeight$ 25Q�5*         
IsReadOnly .   � Cursor$
 Hand��5,      $	��150��6   ���	#FFA1D2FA��5"      ��    Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ НомерТалона��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5/      �� *КодТалона+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  50      $ ДатаПриема��6%    51      �� *
Дата+$ TwoWay=�$ PropertyChanged=�  52      $ 
Время��6%    53      �� *
Время+$ TwoWay=�$ PropertyChanged=�  54      $# Категория врача��6%    55      �� *КодВрача+$ TwoWay=�$ PropertyChanged=�  56      $ Номер полиса��6%    57      �� *НомерМедКарты+$ TwoWay=�$ PropertyChanged=�59       � 5:   
   -   5          �Name$ 
BorderFind��5:      $��617,-160,9.4,-300q�6%   $y�Hidden=�6@   $	��130��6T   ��5;      �� 5<       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5=      �  � Color$ #7FFF00��6#    � Offset$ 0Q�63   � 5>      $ #00FFFF��6#   $	 0.7Q�63   5?      ��5A      � 5B      -   5         �Name$ gridFind��5B      $��
0,10,0,-10q�6)    � RowDefinitions 5C      �� 5D      $	��0.6 �6(   �� 5E      $
��Auto �6(   �� 5F      $��40 �6(   �� 5G      $��40 �6(    � ColumnDefinitions 5I      �� 5J      $��0 �6+   �� 5K      $	��23* �6+   �� 5L      $	��91* �6+   �� 5M      $��70 �6+   .+�5O      �� -   5         ��Name$ TextBlockSearch��5O   =   $��2��6    $��0��60   $��
Поиск��6V   $
��Left=�6c   $
��Bold"�6~   $��79.8,0,0,1.6q�6�   $ 0.033,0.506&�6�   $��36��5P       $��2��6+   �� 5Q      -   5        $ TextBlockSurname��5Q   =   $��1��6    $��2��60   $��Фамилия��6W   $
��Left=�6f   $��Bottom=�6�   $��5,0,0,10q�6�   $��2��6�   �� 5R      -   5        $ TextBlockGender��5R   =   $��1��6    $��3��60   $
��Left=�6V   $��Bottom=�6q   $��	0,0,0,9.8q�6�   $��2��5S       $��31��64   $��68��6@   �� 6L   $ �Специальность��6P   6h   �� 5T      -   5         ��Name$ TextBoxSurname��5T   ;   $��2��6   $��2��6.   $��30.6,14.8,10.6,0q�6|   �� 5U      -	   5         ��Name$ ComboBoxTitle��5U        �� DisplayMemberPath$   Специальность��67   $��30.6,7,10.6,9.8q�6�   $��3��6�   $��2��6�   �� 5V      -
   5        ! ��Name$! ButtonFindSurname��5V   :   $��3��6   $��2��6-   " � ToolTip$$" Поиск по фамилии��6U   {�.  $��10.4,14.8,17,0q�6�   5X      �� 5Y      -   5        $! ButtonFindTitle��5Y      $0" *Поиск по специальности��66   {�.  $��10.4,7,17,9.8q�6�   $��3��6�   $��3��6�   5[      5\      5^      �� 5_   
   -   5        $-��'Сменить пользователя��5_      $��17,-190,-400,-300q�60   $	��163��6K   $��40��6W   $  ��6c   ��5`      �� 5a      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   # j� Stretch$
# None=�6�   5c      5e      $ J� CommandBindings$ 5f      )  #System.Windows.Input.CommandBinding  5g   
   -   5        %   Command$
% Undo��5g      6O     5h   
   -   5        $	% New��5h      6M     5i   
   -   5        $
% Save��5i      6O     5j   
   -   5        $
% Find��5j      6O     5k   
   -   5        #% Z 5k      6s     5l   
   -   5        #% Z 5l      6o     5m   
   -   5        $% Refresh��5m      6+   5o      