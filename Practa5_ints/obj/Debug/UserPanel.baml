   M S B A M L   `   `   `  ����G  CPracta5_ints, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Practa5_intsPracta5_ints  5          Practa5_ints.UserPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Practa5_ints     5        N� Title$  	UserPanel��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��51* �6   �� 5      $	��46* �6   �� 5      $	��42* �6   �� 5      $
��205* �6   �� 5      $	��51* �6   �� 5      $	��55* �6    � ColumnDefinitions 5   
   �� 5      $
��145* �6   �� 5      $	��27* �6   �� 5      $	��28* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ list__��5       $��1��6   $��4��61      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
name_wer+  5      $ Описание��6%    67   �� *Description+  5      $ Размер��6%    65   �� *Size+  5      $ Цена��6%    63   �� *Price+5"      �� 5#   
   $*��$Доставка: Бесплатно��6   $��1��6.   $��1��6;   $��2��6K   �� 5$   
   $��Позиции��6   $��2��6#   $��1��60   �� 5%   
   -   5        $��position��5%      $�� ��6   $��2��6+   $��2��6;     5&   
   -   5        $��selected��5&      $��1��6$   $��3��64   $��2��6B    5'        5(      $ Название��6%    67   �� *
name_wer+  5)      $ Описание��6%    67   �� *Description+  5*      $ Размер��6%    65   �� *Size+  5+      $ Цена��6%    63   �� *Price+5.      �� 5/   
   $��Cумма заказа:��6   $��4��6(   $��1��65   �� 50   
   -   5        $��couunt��50      $��4��6   $��2��6+   �� 51   
   -   5        $	��end��51      $#��Завершить заказ��6   $��1��66   $��5��6F   $��2��6S   6g   53      54      