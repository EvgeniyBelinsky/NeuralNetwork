   M S B A M L   `   `   `  ����|  xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5   	    NeuroNet   NeuroNet.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   	     � Title$  
MainWindow��5   	   $	��432��6   $	��714��6)    � AllowsTransparency .  � WindowStyle$
 None=�6O      VS2012Style#��[  6b   .��5      �� $��1q�6   ���	#FFD89D1D���	#FFACACAC$��6q�6P    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5	         Color$ 	#FFFFC500��6      	Direction$	 318Q�61      ShadowDepth$ 0Q�6A      
BlurRadius$ 11Q�6Q   ._�5   
   � $��0q�6    � ColumnDefinitions 5      �� 5      $	��60* �6#   �� 5      $
��477* �6#   �� 5      $
��163* �6#   	 � RowDefinitions	 5      �� 5      -   5        
 ��Name$
 	titleBar1��5       $	��29* �63   �� 5      $
��123* �6    �� 5      $
��266* �6    .+�5      ]� $��0q�6   $��Bottom=�6#   $��2��6>   $��22��6K   $��3��6W   .+�5      �� .@�5      �� 
���   ��� 64   $�Ready��68   6H   5      5      �� 5      -   5         ��Name$ MaximizeButton��5        WinStyleTitleBarButton#���  6-   $��35��6^   $��Right=�6i   $��0,2,36,0q�6�   ���#888$	��Top=�6�   $��26��6�   $��2��6  ��6�   Z� .��5      F� $��2��6    �� EdgeMode$ Aliased=�6+   X����        � z     � z  z �     z �        �    @B � z @B �    �� � z �� 	
���   �$��0q�6�    �� Stretch$
 Fill=�6�   $��10��6�   $��10��6�   $��Center=�6�   $��Center=�6�   5      �� 5      -   5        $ CloseButton��5      #���  6*   $��0,2,0,0q�6[   ���	#FF0A0606$��Right=�6�   $	��Top=�6�   $��26��6�   $��35��6�   $��2��6�   ��6l   Z� .��5       � $
��Left=�6   $��26��62   $	��Top=�6>   $��35��6V   .+�5!      F� $ Aliased=�6   ����o��YUU	@�<R�K��%& 	
�������$
��Left=�6t   $��10��6�   $��12.5,6.75,0,0q�6�   $
 Fill=�6�   
���   �$	��Top=�6�   $��10��6�   $��2��6�   F� 5"      $ Aliased=�6   ����o��YUU	@�<R�K��%& 	���	#FFF4F4F5$
��Left=�6x   $��10��6�   $��12.5,6.75,0,0q�6�   $
 Fill=�6�   
���   �$	��Top=�6�   $��10��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��2��6  z�5#      V� 5$      .~�5%   "   �� �� 5&   "   �� 5'   "    �� Angle$ -90.196Q�62   T� 5(   "   5)      5+      5,      5-      �� 5.      -   5        $ MinimizeButton��5.      #���  6-   $��35��6^   $��Right=�6i   $��0,2,73,0q�6�   ���#888$	��Top=�6�   $��26��6�   $��2��6  ��6�   Z� .��5/      F� $ Aliased=�6   ���аzH yѐ�4y	$��Center=�6X   $
��3.25��6u   $��0,9,0,0q�6�   $
 Fill=�6�   
���   �$��2��6�   $��Center=�6�   $��12��6�   50      �� 51      -   5         ��Name$ titleBar��51      &   System.Windows.Media.TextOptions   TextRenderingMode$ 	ClearType=�6*      TextFormattingMode$ Display=�6T   $��NoWrap=�6   $!��Нейронные сети��6�   $��16(�6�   $��Segoe UI)�6�   $��1��6  $��23��6  $	��Top=�6  $��0q�66  �� 52      -   5         ��Name$ FunctionGroupBox��52      $��Исходная��61   $
��Left=�6C   $��	10,32,0,0q�6^   $��1��6q   $	��Top=�6~   $��2��6�   $��91��6�   $	��210��6�   .��53      �  54      �� 55      $��5* �6+   �� 56      $��4* �6+   .+�58      �� -   5        $ goButton��58      $��go��6/   $
��Left=�6<   $��45��6W   
���   �$
��Bold"�6�   $��	33,24,0,8q�6�   $��Center=�6�   $��1��6�   $��29��6�   �� 59      -   5         ��Name$ FunctionBox��59      $
��Left=�63   $��22��6N   $��8,31,0,0q�6Z    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��120��6�   $��sin(x)��6�   $��2��6�   �� 5:      -	   5         ��Name$ Label_1��5:      $%��Введите функцию :��6-   $
��Left=�6I   $��	10,10,0,0q�6d   $	��Top=�6w   $	��120��6�   $��2��6�   5;      5<      �� 5=      $��Button��6   $��1��6&   $
��Left=�66   $��	10,55,0,0q�6Q   $��2��6d   $	��Top=�6q   $��75��6�   >   8System.Windows.Controls.DataVisualization.Charting.Chart  5>      -
   5          Name$ chart��5>   $   $��1��63   $
��Left=�6C   $��
165,32,0,0q�6^   $��1��6r      Title$ Chart Title��6   $	��Top=�6�   $��2��6�   $	��266��6�   $��2��6�   $	��424��6�    � DataContext 5?      (�5@      0 0'�6+      Series. 5B      C   =System.Windows.Controls.DataVisualization.Charting.LineSeries  H   BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries   DependentValuePath$ X��6-      IndependentValuePath$ Y��6D      ItemsSource 6]   �� 5C      5E      5F      5G      