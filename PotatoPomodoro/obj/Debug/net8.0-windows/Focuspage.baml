   M S B A M L   `   `   `  ����I  EPotatoPomodoro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PotatoPomodoroPotatoPomodoro  5   	       PotatoPomodoro.FocusPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PotatoPomodoro     5   	     N� Title$  Potato Pomodoro Timer��5   	    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ Styles.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��25 �6   .+�5   
   �� $��0��6   $��Pomodoro��6!   
�������$	�� 24(�6H   $��Center=�6W   �� 5   
   -   5        $��NotificationText��5      $
��Test��6-   $��20(�69   
�������$��Center=�6^   $��0,50,0,0q�6{   �� 5   
   -   5        $��	TimerText��5   !   $��1��6   $��25:00��62   
�������$��40(�6V   $
��Bold"�6d   $��Center=�5      $��0,15,0,0q�61   � 5   
   $��2��6   $	��300��6   $��Center=�6(    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5       $��* �6#   .+�5#      �� -   5        $��StartButton��5#      $	��▶��6(   $��0��65   $��5q�6X   �� 5$      -   5        $��PauseButton��5$      $	��⏸��6(   $��1��65   $��5q�6X   �� 5%      -   5        $��ResetButton��5%      $
��🔄��6(   $��2��66   $��5q�6Y   5&      5'      5(      