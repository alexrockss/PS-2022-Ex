   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5   	       ExpenseIt.ExpenseReport   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ExpenseIt     5   	     � Title$  ExpenseIt - View Expense��5   	   $	��450��6*   $	��800��67   .��5	      � ��5
   
   �� 5       �� ImageSource$ /watermark.png��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��0��6   $��36(�6!   $
��Bold"�6/   ���	#FFE008BA$!��Bahnschrift Light Condensed)�6X   
������ .��6�   Expense Report For:6�   �� 5      $��1��6   $
��Bold"�6!   .��63   Name:6:   �� 5      $��1��6   $
��Left=�6?   $��40,0,0,0q�6Z   $
��Bold"�6l   ��6!   ��  �� Path$
 Name�6�   �� 5      $��2��6   $
��Bold"�6!   .��63   Department:6@   �� 5      $��2��6   $
��Left=�6E   $��75,0,0,0q�6`   $
��Bold"�6r   ��6!   �� $ 
Department�6�   � 5      $��3��6    5      �� 5      $
��Auto �6$   �� 5       $��* �6$    5"      �� 5#      $��* �6'   �� 5$      $��* �6'   .+�5&      &   System.Windows.Controls.DataGrid  $��1��6      AutoGenerateColumns$ False��6(      RowHeaderWidth$ 0Q�6D   $��2��6}   $��	0,0,163,0q�6�   ��6W   �� $ Expenses�   Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6-   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6B   �� $ ExpenseType�  5)      $ Amount��6-   	 6=   �� $ ExpenseAmount�5+      5,      5-      5.      5/      