   M S B A M L   `   `   `  ����  HomeBudgetWPF    HomeBudgetWPF.ExpenseCtrl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $��493.649��5      .��5	      � $��0,0,0,10q�6   $
��Left=�6   $	��491��68   .+�5
   
   �� $
��Left=�6   $��23��6-   $��	67,52,0,0q�69     �� TextWrapping$
  Wrap=�6L   $	��Top=�6x   $	��169��6�   ��6`   �� *Income+6�   �� 5   
   $��Income:��6   $
��Left=�6"   $��	11,49,0,0q�6=   $	��Top=�6P   $��56��6h   �� 5   
   $
��Left=�6   $��23��6-   $��
355,52,0,0q�69   $
  Wrap=�6M   $	��Top=�6~   $	��120��6�   ��6a   �� *ExtraIncome+6�   �� 5   
   $��Extra income:��6   $
��Left=�6(   $��
268,49,0,0q�6C   $	��Top=�6W   $��82��6o   �� 5   
   $
��Left=�6   $��23��6-   $��	81,97,0,0q�69   $
  Wrap=�6L   $	��Top=�6�   $	��155��6�    �� 
IsReadOnly . ��6`   �� *
Expended+ �� Mode$ OneWay=�6�   �� 5   
   $��	Expended:��6   $
��Left=�6$   $��	11,94,0,0q�6?   $	��Top=�6R   $��65��6j   �� 5   
   $
��Left=�6   $��23��6-   $��
329,97,0,0q�69   $
  Wrap=�6M   $	��Top=�6�   $	��146��6�    . ��6a   �� *
Residual+$ OneWay=�6�   �� 5   
   $��Residue:��6   $
��Left=�6#   $��
268,94,0,0q�6>   $	��Top=�6R   $��56��6j   &   System.Windows.Controls.DataGrid  5   
   -   5        $��expGrid��5      $
��Left=�6"   $��
11,140,0,0q�6=   $	��Top=�6Q   $	��270��6i   $	��471��6v    � DataContext$  ��6�      AutoGenerateColumns .     
IsReadOnly .     CanUserAddRows . ��6�   ��    Columns 5   
   4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Category name��6*   	   CellTemplate	 5      �� 5      .R�5      �� ��6(   �� *ExpCategory.Name+5      
   CellEditingTemplate
 5      �� 5      .R�5      ��    
Categories#���   6'    �� DisplayMemberPath$
 Name��5   '    �� SelectedItem 5   !   �� *ExpCategory+$ TwoWay=�5   '   5       5"      0  *System.Windows.Controls.DataGridTextColumn  5#      $ Amount��6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Amount�   ClipboardContentBinding 6E   Z� 6h     5$      $ Descptiption��6m      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6�    6%   �� $ Description� 6J   Z� 6�     5%      $
 Date��6i    6%   �� $ ModDate� 6F   Z� 6i     5&      $ AddDate��6i    6%   �� $ AddDate� 6F   Z� 6i   5(      �� 5)   
   $
��Left=�6   $��	11,13,0,0q�6+   $	��Top=�6>   $	��225��6V   ��6b   �� *Mounth+5+      5,      