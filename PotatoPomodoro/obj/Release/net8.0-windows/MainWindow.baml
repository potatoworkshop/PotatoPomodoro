   M S B A M L   `   `   `  ���� I  EPotatoPomodoro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PotatoPomodoroPotatoPomodoro      PotatoPomodoro.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:PotatoPomodoro       � Title$  Potato Pomodoro Timer��$	��300��$	��375�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=�
������  � AllowsTransparency$
 True�� � Icon$ PomodoroIcon.ico��.����  �� CornerRadius$ 15�����#1d1e20._��  � RowDefinitions �� $��30 ��� $��* �.+��� -   $��0�����#1d1e20$ 15��._��  � ColumnDefinitions �� $��* ��� $
��Auto �.+��� $�� ��$��Center=�$��5,0,0,0q�
��������� $��1�� �� Orientation$ 
Horizontal=�.+��� -   	 ��Name$	 	PinButton��$
��📌��$��30��$��30��
 � ToolTip$
 
Toggle Pin��
�������
������ 
������ �� $ 15��$��5,0,0,0q�._��� -   $	 CloseButton��$��X��$��30��$��30��
�������
������ 
������  � -     �Name$ 	MainFrame��$��1��  � NavigationUIVisibility$ Hidden=�