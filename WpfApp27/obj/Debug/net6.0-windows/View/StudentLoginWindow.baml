   M S B A M L   `   `   `  ����C  ?WpfApp27, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp27WpfApp27  5   	   !    WpfApp27.StudentLoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp27     5   	     � Title$  StudentLoginWindow��5   	   $	��550��6$   $	��800��61   .��5	      ��  �� CornerRadius$ 30��6   
���  ��._�5
      � .+�5   
   �� ��5      �� 5       �� ImageSource$2 ,/View/desktop-wallpaper-login-page-login.jpg��6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .+�5      �� $��Student Login Window��6   $��Center=�63   $��30(�6P   ���	#FFF1F9F0��6^   Z� 6�   �� 5      $��30q�6    �� Orientation$ 
Horizontal=�6%   .+�5      �� $��Italic$�6   $��140 10q�6+   $��20(�6;   $��	User Name��6I   6_   �� 5      -   5         ��Name$ usrname��5   `   $��Center=�6   $��Center=�6>   $	��200��6t   $��50��6�   $��Center=�6�   .��6�   ��5      �� 5       j� 
AlignmentX$
 Left=�6%    j� Stretch$ Uniform=�67   $i c/View/illustration-of-human-icon-user-symbol-icon-modern-design-on-blank-background-free-vector.jpg��6I   .��5   *   5      5      �� 5      $��30q�6   $ 
Horizontal=�6%   .+�5      �� $��Italic$�6   $��150 10 q�6+   $��20(�6<   $��Password��6J   6_   G� 5      -   5         G�Name$ Password��5   j   $��Center=�6#   $��Center=�6H   $	��200��6}   $��50��6�   $��Center=�6�   ��5       �� 5!      $
 Left=�6%   $: 4/View/pngtree-vector-lock-icon-png-image_1028350.jpg��67   $ Uniform=�6z   5#      5$      �� 5)      -   5        	 ��Name$	 submit��5)   '   $��20(�6   $��50q�67   $��submit��6D   $	��200��6U   $��50��6a   $��center=�6m   
������� 5*        5+      ��5-      �� 5.      
 �� 
TargetType"
 ��6    .�5/      ��  �� Property � �� �� Value 50   "   �� 51   &    �� 
TargetType" ��66   .R�52   *   �� ���	#FFA2BDCC$ 20��6J   ._�53   .   �� $��Center=�6?   $��Center=�6\   54   +   55   '   57      �� 58       � ��
 ��ح�6;    �� Triggers 59      P� 5:   "    P� Property �@J�IsMouseOver P� Value$
 True��6A   . �5;   &   ��  � ��
 ��� �6C   �� 5<   &    � �� 5=   *   �� 5>   .   " ��6>   .R�5?   2   �� 
���   �$ 20��6L   ._�5@   6   �� $��Center=�6G   $��Center=�6d   5A   3   5B   /   5D   '   5E   #   P� 5F   "    � ��$
 True��6?   . �5G   &   ��  � ��
 �   �6C   5H   #   5J      5L      �� 5M      -   5        $��20(�5M      $	��200��6#   $��50��6/   ���	#FFF2F1F4 5N        5O      ��5Q      �� 5R      "
 ��6    .�5S      ��  � �� 5T   "   �� 5U   &   " ��66   .R�5V   *   �� ���	#FFA2BDCC$ 20��6J   ._�5W   .   �� $��Center=�6?   $��Center=�6\   5X   +   5Y   '   5[      �� 5\       � ��
 ��ح�6;    5]      P� 5^   "    �@J�IsMouseOver$
 True��6A   . �5_   &   ��  � ��
 ��� �6C   �� 5`   &    � �� 5a   *   �� 5b   .   " ��6>   .R�5c   2   �� 
���   �$ 20��6L   ._�5d   6   �� $��Center=�6G   $��Center=�6d   5e   3   5f   /   5h   '   5i   #   P� 5j   "    � ��$
 True��6?   . �5k   &   ��  � ��
 �   �6C   5l   #   5n      .��5o   $   
Register5p      5r      5s      5t      5v      