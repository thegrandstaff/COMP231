   M S B A M L   `   `   `  ����	  Login    Login.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          � Title$  
MainWindow��5   	   $	��300��6    � WindowStartupLocation$ CenterScreen=�6)   $	��400��6N    � 
ResizeMode$ NoResize=�6Z    � WindowStyle$
 None=�6p   ��5      �� 5   
    �� ImageSource$) #/Login;component/Images/capsule.jpg��6    j� Stretch$
 None=�6G    j� TileMode$
 Tile=�6V    j� Viewport$ 0,0,128,128�6f    j� ViewportUnits$ Absolute=�6}   .��5	      � -   5        	 �Name$	 grid1��5	      $	��224��6   $	��230��6'   
 � RowDefinitions
 5
   
   �� 5      $	��33* �6   �� 5      $	��28* �6   �� 5      $	��32* �6   �� 5      $	��28* �6   �� 5      $	��52* �6   �� 5      $	��54* �6    � ColumnDefinitions 5   
   �� 5      $	��38* �6   �� 5      $	��63* �6   �� 5      $	��99* �6   �� 5      $	��30* �6   .+�5   
   �� -   5         ��Name$ buttonClose��5   U   $��X��6   $��3��6   $��23��6-   $��Right=�69   $	��Top=�6j   $��24��6�   
�������
���  ��
�������$��0q�6�   $
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ textBlockLogin��5   &   $��14,0,0,0q�6   $
��User��6>   $��1��6J   $��14(�6Z   $
��Left=�6h   $
��Bold"�6�   $��21��6�   $��Bottom=�6�   �� 5   
   -   5         ��Name$ textBoxLogin��5   J   $��1��6   $��1��6"   $
��Left=�6/   $��Center=�6`   $	��141��6{   $	��0,4q�6�    �� MaxLines$ 16��6�   $��2��6�   �� 5   
   -   5        $ textBlockPass��5   '   $��	14,12,0,0q�6   $��Password��6>   $��1��6N   $��2��6^   $��14(�6k   $
��Left=�6y   $
��Bold"�6�   $��2��6�   G� 5   
   -   5         G�Name$ passwordBoxPass��5   ^   $��1��6   $��3��6&    G� 	MaxLength$ 16��64   $
��Left=�6C   $��Center=�6w   $	��141��6�   $	��0,5q�6�   $��2��6�   �� 5   
   -   5        $ buttonEnter��5   s   $��1��6-   $��4��6=   $��44��6J   $��Center=�6V   $��Center=�6�   $	��120��6�   $��18(�6�   $
��Bold"�6�    �� 	IsDefault . $��2��6�   $
��21,3q�6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Images/login.jpg��6   $
��Fill=�62   $��30��6A   $��30��6M   $
��Left=�6X   �� 5       $��Login��6   5!      5"      �� 5#   
   -	   5        $ buttonRegistration��5#   e   $��Sign Up��6*   $��1��6<   $��5��6L   $��23��6Y   $��Center=�6�   
�������$��2��6�   $��
21,20,0,10q�6�   $
��Left=�6�   $��64��6�   5%      5&      