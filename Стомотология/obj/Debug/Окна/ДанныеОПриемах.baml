   M S B A M L   `   `   `  ����S  OСтомотология, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:СтомотологияСтомотология  5      U/clr-namespace:Стомотология.Commands!Стомотология.Commands  5      c6clr-namespace:Стомотология.ValidationRules(Стомотология.ValidationRules  5      ;    5Стомотология.ДанныеОПриемах   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Стомотология     5      Ccommand/clr-namespace:Стомотология.Commands     5      Grule6clr-namespace:Стомотология.ValidationRules     5      -   5          � Title$   ��5      $	��515��6   $	��315��6    � Icon$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\hospital-4_icon-icons.com_66060.png��6)    � WindowStyle$ 
ToolWindow=�6�    � WindowStartupLocation$ CenterScreen=�6�   
�����F� J� OpacityMask
 ���F���5      �� 5   
    �� ImageSource$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .��5      �� $��3q�6    J� RenderTransformOrigin$ 0.493,0.824&�6   $	��515��6A   $	��315��6M   .+�5   
   o� ��5      �� 5      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .@�5      m� $��15(�6   $��Italic$�6%   $
��Bold"�68   $��Действие��6J   
�����F�.@�5      m� $��Отменить��6    m� Command$
 Undo��6-   6?   �� 5      6   m� 5      $��15(�6   $��Italic$�6)   $
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
��Bold"�6   $��20(�6&   $��Italic$�64   $��5q�6G   
�����F� Данные о приёмах6|   &   System.Windows.Controls.DataGrid  5!   
   -   5        
  Name$
 DataGridBol��5!         AutoGenerateColumns .  $
��Left=�5$         RowBackground
 ���F�   AlternatingRowBackground �	#FFA1D2FA
�����F�$
��Bold"�5(      $��3q�5)         	RowHeight$ 25Q�5*         
IsReadOnly .   � Cursor$
 Hand��5,      $	��147��6   ���	#FFA1D2FA$	��362��6?   ��5"      ��    Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ ДатаПриема��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5/      �� *ДатаПриема+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  50      -   5        Po��$ Причина��50   5      DisplayMemberPath$ Прием1��51         SelectedValuePath$ Причина��6�      
IsReadOnly .     SelectedValueBinding 60   ��  �� Path$ Причина�$ TwoWay=�$ PropertyChanged=�6�     52      $ Стоимость��6%    53      �� *Стоимость+$ TwoWay=�$ PropertyChanged=�55       � 56   
   -   5          �Name$ 
BorderFind��56      $��617,-160,9.4,-300q�6%   $y�Hidden=�6@   $	��130��6T   ��57      �� 58       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��59      �  � Color$ #7FFF00��6#    � Offset$ 0Q�63   � 5:      $ #00FFFF��6#   $	 0.7Q�63   5;      ��5=      � 5>      -   5          �Name$  gridFind��5>      $��
0,10,0,-10q�6)   ! � RowDefinitions! 5?      �� 5@      $	��0.6 �6(   �� 5A      $
��Auto �6(   �� 5B      $��40 �6(   �� 5C      $��40 �6(   " � ColumnDefinitions" 5E      �� 5F      $��0 �6+   �� 5G      $	��23* �6+   �� 5H      $	��91* �6+   �� 5I      $��70 �6+   .+�5K      �� -   5        # ��Name$# TextBlockSearch��5K   =   $��2��6    $��0��60   $��
Поиск��6V   $
��Left=�6c   $
��Bold"�6~   $��79.8,0,0,1.6q�6�   $ 0.033,0.506&�6�   $��36��5L       $��2��6+   �� 5M      -   5        $# TextBlockSurname��5M   =   $��1��6    $��2��60   $��Фамилия��6W   $
��Left=�6f   $��Bottom=�6�   $��5,0,0,10q�6�   $��2��6�   �� 5N      -   5        $# TextBlockGender��5N   =   $��1��6    $��3��60   $
��Left=�6V   $��Bottom=�6q   $��	0,0,0,9.8q�6�   $��2��5O       $��31��64   $��68��6@   �� 6L   $ �Специальность��6P   6h   �� 5P      -	   5        $ ��Name$$ TextBoxSurname��5P   ;   $��2��6   $��2��6.   $��30.6,14.8,10.6,0q�6|   �� 5Q      -
   5        % ��Name$% ComboBoxTitle��5Q      & �� DisplayMemberPath$ & Специальность��67   $��30.6,7,10.6,9.8q�6�   $��3��6�   $��2��6�   �� 5R      -   5        ' ��Name$' ButtonFindSurname��5R   :   $��3��6   $��2��6-   ( � ToolTip$$( Поиск по фамилии��6U   {�.  $��10.4,14.8,17,0q�6�   .��5S      �� $8��2/Фотографии/free-icon-search-4197908.png��6    $��20��6R   $��21��6]   5T      5V      5X      �� 5Y   
   -   5        $��
Назад��5Y      $��17,-210,-250,-300q�6!   $	��115��6<   $��40��6H   $  ��6T   ��5Z      �� 5[      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   ) j� Stretch$
) None=�6�   5]      5_      * J� CommandBindings* 5`      )  #System.Windows.Input.CommandBinding  5a   
   -   5        +   Command$
+ Undo��5a      6O     5b   
   -   5        $	+ New��5b      6M     5c   
   -   5        $
+ Save��5c      6O     5d   
   -   5        $
+ Find��5d      6O     5e   
   -   5        #+ Z	 5e      6s     5f   
   -   5        #+ Z 5f      6o     5g   
   -   5        $+ Refresh��5g      6+   5i      