   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PersonalProjectPersonalProject  5   	        PersonalProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PersonalProject     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5         dataTemplateLogo �� Path��%�   &	        �� 5   
   .R�5      �� .+�5      �� $	��100��65   ��6   �� $
 Logo�65   �� 5      $��18(�67   $��20q�6E   ��6   �� $
 Name�6E   5      5      5      .��5      � .+�5   
   �� -   5         ��Name$ 
firstImage��5      $ ��images/championsLeague.jpg��6$   $��UniformToFill=�6H   $y�Visible=�6`   �� 5   
   -   5        $ secondImage��5      $��images/searchchapions.jpg��6%   $��UniformToFill=�6H   $y�Hidden=�6`   �� 5    
   -   5         ��Name$ searchPanel��5       $y�Hidden=�6*   $	��Top=�6>   $��20q�6V   .+�5!      �� -   5         ��Name$ searchTextBox��5!      $	��200��6-   $��30��69   $��16(�6E   6s   �� 5"      -   5        $��
Rechercher��5"      $	��100��6E   $��30��6Q   $��10q�6]   5#      �� 5$   
   -   5         ��Name$ searchResultsListBox��5$      $y�Hidden=�60   $��20,120,600,20q�6D   $
��Left=�6�   $��Stretch=�6�   $	��300��6�    J� Opacity$	 0.7Q�6�    �� SelectedValuePath$ Id��6�   	 �� DisplayMemberPath$
	 Name��6�   5&      �� 5)   
   -   5        $ searchResultsListBoxRight��5)      $y�Hidden=�65   $��600,120,20,20q�6I   $��Right=�6`   $��Stretch=�6|   $	��300��6�   $	 0.7Q�6�   5,      �� 5.   
   -	   5        $	 ede��5.      $��0,120,20,20q�6   $	 0.7Q�64   $y�Hidden=�6B   $��Right=�6V   $	��197��6r   
 J� RenderTransformOrigin$
 0.2,0.2&�6~   50      �� 52   
   -
   5        $ logolbx��52      $y�Hidden=�6#   $��Center=�67   $��Stretch=�6T   $	��150��6p   $	��150��6|   $	 0.7Q�6�   $��316,166,316,110q�6�   #��[  6�   55      56      