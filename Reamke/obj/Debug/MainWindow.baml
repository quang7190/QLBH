   M S B A M L   `   `   `  ����A  =Reamke, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ReamkeReamke  5   	   =#clr-namespace:Reamke.UserControl_THReamke.UserControl_TH  5
   	       Reamke.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Reamke     5   	   2uc#clr-namespace:Reamke.UserControl_TH     5
   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  6R   -   5        $��
mainWindow��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    
 MainVM � DataContext# [ 5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase	   Actions.	 5      6  0System.Windows.Interactivity.InvokeCommandAction  
   Command
 6$   �� *LoadedWindow+   CommandParameter 5   $   ��  �� ElementName$ 
mainWindow��5      .��5      �  � RowDefinitions 5!   
   �� 5"      $
��auto �6   6,   �� 5#      6   .+�5%   
   � $��0��6   .+�5&      (   "Reamke.UserControl_TH.ControlBarUC  
 � Tag 6   �� *Title+$ 
mainWindow��6N   5'      � 5)   
   $��1��6    5*      �� 5+      6"   �� 5,      6"   .+�5.      � $��0��6   .+�5/      ��  $  MaterialDesignRaisedAccentButton#��[ 6   $	��200��50      $	��100��51       � ToolTip$5 /Resource name: MaterialDesignRaisedAccentButton��53      ��52      �� *OrderWindow+.��54      �  55      �� 56      6.   �� 57      6.   .+�59      � $��0��6   .+�5:      �� $��24(�6(   $��
Bán hàng��66   $��Center=�6F   6c   5;      � 5<      $��1��6   .+�5=      '  !MaterialDesignThemes.Wpf.PackIcon  $��30��66   $��30��6A   $��Center=�6M      Kind$
 Cart=�6j   5>      5?      5@      5A      � 5B      $��1��6   .+�5C      �� #��[ 6   $	��200��5D      $	��100��5E      $5 /Resource name: MaterialDesignRaisedAccentButton��5G      ��5F      �� *CheckWindow+.��5H      �  5I      �� 5J      6.   �� 5K      6.   .+�5M      � $��0��6   .+�5N      �� $��23(�6(   $��Tra cứu hóa đơn��66   $��Center=�6M   6j   5O      � 5P      $��1��6   .+�5Q        $��30��66   $��30��6A   $��Center=�6M   $ 	FileCheck=�6j   5R      5S      5T      5U      5V      5W      5X      