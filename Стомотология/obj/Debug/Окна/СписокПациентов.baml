   M S B A M L   `   `   `  ����S  OСтомотология, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:СтомотологияСтомотология  5      U/clr-namespace:Стомотология.Commands!Стомотология.Commands  5      c6clr-namespace:Стомотология.ValidationRules(Стомотология.ValidationRules  5      =    7Стомотология.СписокПациентов   5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Стомотология     5      Ccommand/clr-namespace:Стомотология.Commands     5      Grule6clr-namespace:Стомотология.ValidationRules     5      -   5          � Title$   ��5      $	��750��6   $	��380��6    � Icon$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\hospital-4_icon-icons.com_66060.png��6)    � WindowStyle$ 
ToolWindow=�6�    � WindowStartupLocation$ CenterScreen=�6�   
�����F� J� OpacityMask
 ���F���5      �� 5   
    �� ImageSource$� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .��5      �� $��3q�6    J� RenderTransformOrigin$ 0.493,0.824&�6   .+�5   
   o� ��5      �� 5      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   .@�5      m� $��Italic$�6   $
��Bold"�6*   $��Действие��6<   
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
�����F�!Список пациентов6|   &   System.Windows.Controls.DataGrid  5!   
   -   5        
  Name$
 DataGridBol��5!         AutoGenerateColumns .  $
��Left=�5$         RowBackground
 ���F�   AlternatingRowBackground �	#FFA1D2FA
�����F�$��3q�5(      $
��Bold"�5)         	RowHeight$ 25Q�5*         
IsReadOnly .  � Cursor$
 Hand��5,      $	��203��6   ���	#FFA1D2FA��5"      ��    Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$  НомерМедКарты��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5/      �� *НомерМедКарты+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  50      $ Фамилия��6%    51      �� *Фамилия+$ TwoWay=�$ PropertyChanged=�  52      $ Имя��6%    53      �� *Имя+$ TwoWay=�$ PropertyChanged=�  54      $ Отчество��6%    55      �� *Отчество+$ TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridTemplateColumn  56      $+ %ДатаПриема рождения��6)      DateTemplate   CellTemplate# [  57        EditingDateTemplate   CellEditingTemplate# [ 6B     58      $ Пол��6%    59      �� *Пол+$ TwoWay=�$ PropertyChanged=�  5:      $ 
Почта��6%     	EmailRule   EditingElementStyle# [ 64    5;      �� 5<       �� Path$ 
Почта�6"   $ TwoWay=�6/   $ PropertyChanged=�6=    �� ValidatesOnExceptions .  �� ValidationRules 5=      8   2Стомотология.ValidationRules.EmailRule  5>   "   5@      5B      4  .System.Windows.Controls.DataGridComboBoxColumn  5C      -   5        Poo��$' !Место регистрации��5C   6      DisplayMemberPath$&  МестоРегистрации��5D         SelectedValuePath$&  МестоРегистрации��6�      
IsReadOnly .     SelectedValueBinding 6:   �� $&  МестоРегистрации�$ TwoWay=�$ PropertyChanged=�6�   !    RowValidationErrorTemplate  5F      �� 5G      .R�5H      � $��	0,-2,0,-2q�6   ! � ToolTip! 6.   �� " �� RelativeSource" �� *FindAncestor+# �� AncestorType)	  #System.Windows.Controls.DataGridRow"# 	 $) #(Validation.Errors)[0].ErrorContent�.+�5I      A� $��0��6"   
���  ��#��z��6A   #��z��6d   �� 5J      $��!��6$   #��z��6-   $
��Bold"�6S   
�������$��Center=�6x   5K      5L      5N       � 5O   
   -   5        $  �Name$$ 
BorderFind��5O      $��617,-160,9.4,-300q�6%   $y�Hidden=�6@   $	��130��6T   ��5P      �� 5Q      % �� EndPoint$% 0.5,1&�6&   & �� 
StartPoint$& 0.5,0&�67   .��5R      � ' � Color$' #B82E1F��6#   ( � Offset$( 0Q�63   5S      ��5U      � 5V      -   5        ) �Name$) gridFind��5V      $��
0,10,0,-10q�6)   * � RowDefinitions* 5W      �� 5X      $	��0.6 �6(   �� 5Y      $
��Auto �6(   �� 5Z      $��40 �6(   �� 5[      $��40 �6(   + � ColumnDefinitions+ 5]      �� 5^      $��0 �6+   �� 5_      $	��23* �6+   �� 5`      $	��91* �6+   �� 5a      $��70 �6+   .+�5c      �� -   5        , ��Name$, TextBlockSearch��5c   >   $��2��6!   $��0��61   $��
Поиск��6W   $
��Left=�6d   $
��Bold"�6   $��79.8,0,0,1.6q�6�   $ 0.033,0.506&�6�   $��36��5d       $��2��6+   �� 5e      -   5        $, TextBlockSurname��5e   =   $��1��6    $��2��60   $��Фамилия��6W   $
��Left=�6f   $��Bottom=�6�   $��5,0,0,10q�6�   $��2��6�   �� 5f      -   5        $, TextBlockGender��5f   =   $��1��6    $��3��60   $
��Left=�6V   $��Bottom=�6q   $��	0,0,0,9.8q�6�   $��2��5g       $��31��64   $��68��6@   �� 6L   $�   Место ��6P   �� 6c   �� 6o   $�регистрации��6s   6�   �� 5h      -	   5        - ��Name$- TextBoxSurname��5h   ;   $��2��6   $��2��6.   $��30.6,14.8,10.6,0q�6|   �� 5i      -
   5        . ��Name$. ComboBoxTitle��5i      / �� DisplayMemberPath$&/  МестоРегистрации��67   $��30.6,7,10.6,9.8q�6�   $��3��6�   $��2��6�   �� 5j      -   5        0 ��Name$0 ButtonFindSurname��5j   :   $��3��6   $��2��6-   $$! Поиск по фамилии��6U   {�.  $��10.4,14.8,17,0q�6�   .��5k      �� $8��2/Фотографии/free-icon-search-4197908.png��6    $��20��6R   $��21��6]   5l      �� 5m      -   5        $0 ButtonFindTitle��5m      $9! 3Поиск по месту регистрациии��66   {�.  $��10.4,7,17,9.8q�6�   $��3��6�   $��3��6�   .��5n      �� $8��2/Фотографии/free-icon-search-4197908.png��6    $��20��6R   $��21��6]   5o      5p      5r      �� 5s   
   -   5        $��
Назад��5s      $��150,-190,-400,-300q�6!   $	��163��6=   $��40��6I   $  ��6U   ��5t      �� 5u      $� �C:\Users\murza\OneDrive\Рабочий стол\новый дизайн\Стомотология\Resources\winter-background-for-invitations-cards-journals-planners-weddings_199112-302.jpg��6   1 j� Stretch$
1 None=�6�   5w      5y      2 J� CommandBindings2 5z      )
  #System.Windows.Input.CommandBinding
  5{   
   -   5        3 
  Command$
3 Undo��5{      6O   
  5|   
   -   5        $	3 New��5|      6M   
  5}   
   -   5        $
3 Save��5}      6O   
  5~   
   -   5        $
3 Find��5~      6O   
  5   
   -   5        #3 Z	 5      6s   
  5�   
   -   5        #3 Z 5�      6o   
  5�   
   -   5        $3 Refresh��5�      6+   4 � 	Resources4 5�        DataTemplate5 �� StringFormat  EditingDataTemplate(  "System.Windows.Controls.DatePicker6   SelectedDate��%#  &	       &	 �     �� 5�   
   .R�5�      �� $��Center=�6`   $��Center=�6{   ��6   �� *ДатаРождения+$5 {0:dd.}{0:MM.}{0:yyyy}��6{   5�      �� 5�   
   .R�5�        6 6   �� *ДатаРождения+$ TwoWay=�$ PropertyChanged=�5�      5�      5�      