   M S B A M L   `   `   `  ����C  ?WpfApp27, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp27WpfApp27  5   	       WpfApp27.AdminLoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp27     5   	     � Title$  AdminLoginWindow��5   	   $	��550��6"   $	��800��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��55* �6   �� 5      $	��31* �6   �� 5      $	��74* �6   .+�5   
   �� $��3��6   ��5      �� 5       �� ImageSource$ /View/new login.jpg��6   .+�5      �� $��Admin Login Window��6   $��Center=�61   $��30(�6N   ���	#FF7FEDF16u   �� 5      $��30q�6    �� Orientation$ 
Horizontal=�6%   .+�5      �� $��Oblique$�6   $��140 10q�6-   $��20(�6=   $��	User Name��6K   
���������6_   Z� 6�   �� 5      -   5         ��Name$ aUsrname��5   �   
�������$
��Bold"�6-   $��20(�6?   $��Center=�6M   $��Center=�6q   $	��200��6�   $��50��6�   $��Center=�6�   .��6�   ��5      �� 5       j� 
AlignmentX$
 Left=�6%   $i c/View/illustration-of-human-icon-user-symbol-icon-modern-design-on-blank-background-free-vector.jpg��67    j� Stretch$ Uniform=�6�   .��5   *   5      5      �� 5      $��30q�6   $ 
Horizontal=�6%   .+�5      �� $��Oblique$�6   $��150 10 q�6,   $��20(�6=   $��Password��6K   ���	#FFF3F7F46w   G� 5       -   5         G�Name$ aPasswrd��5    �   $
��Bold"�6   $��20(�60   $��Center=�6>   $��Center=�6b   
�������$	��200��6�   $��50��6�   $��Center=�6�   ��5!      �� 5"      $
 Left=�6%   $: 4/View/pngtree-vector-lock-icon-png-image_1028350.jpg��67   $ Uniform=�6z   5$      5%      �� 5(      -   5         ��Name$ asubmit��5(   #   $��20(�6   $��50q�65   $��submit��6B   $	��200��6S   $��50��6_   $��center=�6k   $��1,1,1,1q�6�   ���	#FFF7F3F3���	#FFC8E6F0	 J� Effect	 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*      ��5,      �� 5-      
 �� 
TargetType"
 ��6   .�5.      ��  �� Property � �� �� Value 5/      �� 50   "    �� 
TargetType" ��62   .R�51   &   �� ���	#FF1D922F �� CornerRadius$ 20��6F   ._�52   *   �� $��Center=�6;   $��Center=�6X   53   '   54   #   56      �� 57       � ��
 ��ح�67    �� Triggers 58      P� 59       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5:   "   ��  � ��
 ��� �6?   �� 5;   "    � �� 5<   &   �� 5=   *   " ��6:   .R�5>   .   �� 
���   �$ 20��6H   ._�5?   2   �� $��Center=�6C   $��Center=�6`   5@   /   5A   +   5C   #   5D      P� 5E       � ��$
 True��6;   . �5F   "   ��  � ��
 �   �6?   5G      5I      5K      �� 5N      -   5        $��20(�5N      $��Register��6#   $	��200��67   $��50��6C   ���	#FFFCFCFC	 5O        5P      ��5R      �� 5S      "
 ��6   .�5T      ��  � �� 5U      �� 5V   "   " ��62   .R�5W   &   �� ���	#FF309740$ 20��6F   ._�5X   *   �� $��Center=�6;   $��Center=�6X   5Y   '   5Z   #   5\      �� 5]       � ��
 ��ح�67    5^      P� 5_       �@J�IsMouseOver$
 True��6=   . �5`   "   ��  � ��
 ��� �6?   �� 5a   "    � �� 5b   &   �� 5c   *   " ��6:   .R�5d   .   �� 
���   �$ 20��6H   ._�5e   2   �� $��Center=�6C   $��Center=�6`   5f   /   5g   +   5i   #   5j      P� 5k       � ��$
 True��6;   . �5l   "   ��  � ��
 �   �6?   5m      5o      5q      5s      5v      5w      