   M S B A M L   `   `   `  ����M  I学生管理系统, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:学生管理系统学生管理系统  5   	       学生管理系统.index   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:学生管理系统     5   	     � Title$  学生信息管理��5   	   $	��450��6   $	��800��6%   .��5	      � $��0,0,0,-5q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   $��33��6*   �� 5      .+�5   
   �� -   5         ��Name$ txtId��5      $��0��6!   $��139,5,561,5q�6.   ��6C   �� *SelectedStudent.Id+ �� Mode$ TwoWay=��� 5   
   -   5        $ txtName��5      $��1��6#   $��139,5,561,5q�60   ��6E   �� *SelectedStudent.Name+$ TwoWay=��� 5   
   -   5        $ txtAge��5      $��2��6"   $��139,5,561,5q�6/   ��6D   �� *SelectedStudent.Age+$ TwoWay=��� 5   
   -   5        $ txtGrade��5      $��3��6$   $��139,5,561,5q�61   ��6F   �� *SelectedStudent.Grade+$ TwoWay=��� 5   
   -   5        $ txtSex��5      $��4��6"   $��139,3,561,5q�6/   ��6D   �� *SelectedStudent.Sex+$ TwoWay=��� 5   
   -   5         ��Name$ btnAdd��5      $��0��6!   $��350,5,350,5q�6.   $��添加��6C   6P   �� 5   
   -   5        $ 	btnDelete��5      $��1��6$   $��350,5,350,5q�61   $��删除��6F   6S   �� 5   
   -   5        $ 	btnUpdate��5      $��2��6$   $��350,5,350,5q�61   $��更新��6F   6S   �� 5   
   -	   5        $ 	btnSearch��5      $��3��6$   $��350,5,350,5q�61   $��查询��6F   6S   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ dataGrid��5      $��5��6%   $��0,2,0,75q�62      AutoGenerateColumns .  ��6`   �� *
Students+ �� SelectedItem 6�   �� *SelectedStudent+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+  5      $
	 Name��6%   
 63   �� *Name+  5      $		 Age��6%   
 62   �� *Age+  5       $	 Grade��6%   
 64   �� *Grade+  5!      $		 sex��6%   
 62   �� *Sex+5#      �� 5$   
   $	��Id:��6   $
��Left=�6   $��79,0,0,0q�69   $	��Top=�6K   $��25��6c   $��24��6o   �� 5%   
   $
��Name��6   $
��Left=�6   $��	79,29,0,0q�6:   $	��Top=�6M   $��2��6e   $��25��6v   $��44��6�   �� 5&   
   $
��Age:��6   $
��Left=�6   $��	79,29,0,0q�6:   $��1��6M   $	��Top=�6Z   $��26��6r   $��2��6~   $��36��6�   �� 5'   
   $��Grade��6   $
��Left=�6    $��79,0,0,0q�6;   $��3��6M   $	��Top=�6Z   $��25��6r   $��45��6~   �� 5(   
   $��sex：
��6   $
��Left=�6)   $��81,0,0,0q�6D   $��4��6V   $��Center=�6c   $��27��6~   $��40��6�   5)      5+      