   M S B A M L   `   `   `  ����I  EPotatoPomodoro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PotatoPomodoroPotatoPomodoro  5   	       PotatoPomodoro.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PotatoPomodoro     5   	     � Title$  Potato Pomodoro Timer��5   	   $	��300��5	   	   $	��375��6    � 
ResizeMode$ NoResize=�5
   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � Icon$ PomodoroIcon.ico��5   	   .��5      ��  �� CornerRadius$ 15��6   ���#1d1e20._�5   
   �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5      �� -   5        $��0��5      ���#1d1e20$ 15��67   ._�5      �  � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $
��Auto �6+   .+�5      �� $�� ��6    $��Center=�6(   $��5,0,0,0q�6C   
�������6T   �� 5      $��1��6!    �� Orientation$ 
Horizontal=�61   .+�5       �� -   5        	 ��Name$	 	PinButton��5    !   $
��📌��64   $��30��6A   $��30��6L   
 � ToolTip$
 
Toggle Pin��6p   
�������
������ 
������ 6�   �� 5!      $ 15��6!   $��5,0,0,0q�64   ._�5"      �� -   5        $	 CloseButton��5"   %   $��X��6:   $��30��6F   $��30��6Q   
�������
������ 
������ 6�   5#      5$      5%      5&       � 5'      -   5          �Name$ 	MainFrame��5'   !   $��1��6     � NavigationUIVisibility$ Hidden=�64   5(      5)      5*      