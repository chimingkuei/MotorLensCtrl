   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   H DMotorLensCtrl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MotorLensCtrlMotorLensCtrl 5   	      MotorLensCtrl.MainWindow   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   Iwf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms  5   	   'localclr-namespace:MotorLensCtrl  5   	   -   5          � 
ResizeMode$  CanMinimize=�5   	    � Title$ MotorLensCtrl��5   	   $	��700��6   $
��1200��6,   ���	#FF3E6FB3 � WindowStartupLocation$ CenterScreen=�6P   .��5      � .+�5   
   �� -   5         ��Name$	 Log��5      $
��Left=�6"   $	��172��6=   $��	5,485,0,0q�6J   $	��Top=�6]   $	��972��6u   ���	#FFE6F0FF � 	Resources 5       �� 
TargetType �� Property �� Value��%d  '��       'J� �     �� 5      " ��6   .�5      �� # �@��VerticalScrollBarVisibility$
 Auto=�6D   �� 5       � ��$ 0q�6/   �� 5       �@��
IsReadOnly . 63   �� 5       � ��$ Bottom=�67   5      �� 5      " J�6   .�5      ��  �@��Margin$ 0q�6/   �� 5       � ��$ 16(�61   5      5      .@�5      �� $��一般��6      BaseTabcontrol#��[  6"   .��5      �� -   5         ��Name$ richTextBoxGeneral��5      ���	#FF43B5BF6:   5      �� 5      $��警告��6   #��[  6"   .��5      �� -   5        $ richTextBoxWarning��5      ���	#FF43AABF6:   5       �� 5!      $��錯誤��6   #��[  6"   .��5"      �� -   5        $ richTextBoxError��5"      ���	#FF43A0BF68   5#      �� 5$      $��除錯��6   #��[  6"   .��5%      �� -   5        $ richTextBoxDebug��5%      ���	#FF4396BF68   5&      5'      �� 5(   
   $
��Left=�6   $��5,3,0,0q�60   $	��Top=�6A   $	��478��6Y   $
��1183��6f   ���	#FFE6F0FF.@�5)      �� $��	主畫面��6   #��[  6#   .��5*      � .+�5+      �� -   5        	 ��Name$	 
Parameter1��5+        BaseTextBox#��[ 62   

 � Tag$
 請輸入內容...��6W   $��902,392,157,13q�6f   �� 5,      -   5        $	 
Parameter2��5,      #��[ 62   $
 請輸入內容...��6W   $��1030,392,29,11q�6f   7  1System.Windows.Forms.Integration.WindowsFormsHost  5-      $��16,18,437,15q�6(      Child. 5.      %   System.Windows.Forms.PictureBox  -	   5        Display_Windows��   BorderStyle$ FixedSingle=�5.   A   5/      �� 50      -
   5         ��Name$ Connet��50        CircleButton#��[ 6-   $��766,88,304,250q�6S   $��Connet��6k   $��18(�6|   6�   �� 51      -   5        $ MotorLensInit��51      #��[ 64   $��766,242,304,97q�6Z   $�� MotorLens
Initialization��6r   $��18(�6�   6�   � 52       � Orientation$ Vertical=�6    $��882,26,19,37q�67   .+�53      ��  �� Orientation$ Vertical=�6%   $
��Left=�6<   $��4,36,0,0q�6W   $	��268��6i   .+�54      �� $
��ZOOM��6(   $��16(�64   $
��Bold"�6B   $��Center=�6T   $��Center=�6q   $��5q�6�   �� 55      -   5        $��Zoom_Slider��55   %     
BaseSlider#��[ 68    �� TickPlacement$ BottomRight=�6\   6x   � 56      $	��200��6#   $��Center=�6/   $��Center=�6L    � ColumnDefinitions 57   "   �� 58   &   $
��Auto �67   �� 59   &   $��* �67   �� 5:   &   $
��Auto �67   .+�5<   "   �� -   5        $��Zoom_Slider_Min��5<   ,   $��0��6C   $
��Left=�6S   $��Center=�6n   �� 5=   "   $��1��6a   $��Center=�6q   $��Center=�6�   ��6,   ��  �� ElementName$ Zoom_Slider�� �� Path$ Value�6�   �� 5>   "   -   5        $��Zoom_Slider_Max��5>   ,   $��2��6C   $��Right=�6S   $��Center=�6o   5?      5@      �� 5A      $ Vertical=�6%   $
��Left=�6<   $��4,36,0,0q�6W   $	��268��6i   .+�5B      �� $��Focus��6(   $��16(�65   $
��Bold"�6C   $��Center=�6U   $��Center=�6r   $��5q�6�   �� 5C      -   5        $��Focus_Slider��5C   %   #��[ 69   $ BottomRight=�6]   6y   � 5D      $	��200��6#   $��Center=�6/   $��Center=�6L    5E   "   �� 5F   &   $
��Auto �67   �� 5G   &   $��* �67   �� 5H   &   $
��Auto �67   .+�5J   "   �� -   5        $��Focus_Slider_Min��5J   ,   $��0��6D   $
��Left=�6T   $��Center=�6o   �� 5K   "   $��1��6b   $��Center=�6r   $��Center=�6�   ��6,   �� $ Focus_Slider��$ Value�6�   �� 5L   "   -   5        $��Focus_Slider_Max��5L   ,   $��2��6D   $��Right=�6T   $��Center=�6p   5M      5N      �� 5O      $ Vertical=�6%   $
��Left=�6<   $��4,36,0,0q�6W   $	��268��6i   .+�5P      �� $
��Iris��6(   $��16(�64   $
��Bold"�6B   $��Center=�6T   $��Center=�6q   $��5q�6�   �� 5Q      -   5        $��Iris_Slider��5Q   %   #��[ 68   $ BottomRight=�6\   6x   � 5R      $	��200��6#   $��Center=�6/   $��Center=�6L    5S   "   �� 5T   &   $
��Auto �67   �� 5U   &   $��* �67   �� 5V   &   $
��Auto �67   .+�5X   "   �� -   5        $��Iris_Slider_Min��5X   ,   $��0��6C   $
��Left=�6S   $��Center=�6n   �� 5Y   "   $��1��6a   $��Center=�6q   $��Center=�6�   ��6,   �� $ Iris_Slider��$ Value�6�   �� 5Z   "   -   5        $��Iris_Slider_Max��5Z   ,   $��2��6C   $��Right=�6S   $��Center=�6o   5[      5\      5]      5^      5_      5`      5a      5b      