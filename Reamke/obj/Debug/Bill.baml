   M S B A M L   `   `   `  ����A  =Reamke, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ReamkeReamke  5   	   =#clr-namespace:Reamke.UserControl_THReamke.UserControl_TH  5	   	       Reamke.Bill   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Reamke     5   	   2uc#clr-namespace:Reamke.UserControl_TH     5	   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  6R      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStartupLocation$ CenterScreen=�5   	    
 BillVM � DataContext# [ 5   	    � Title$ Kiểm tra đơn��5   	   $	��450��6   $	��800��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      (   "Reamke.UserControl_TH.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 loginWindow��5       #  MaterialDesignThemes.Wpf.Card  5!   
   $��1��6   $
��auto��6+   $	��800��69   $��Center=�6E   $��Center=�6`   .��5"      � 
 � ColumnDefinitions
 5#      �� 5$      $
��auto �6'   66   �� 5%      6)   �� 5&      6*   �� 5'      6*   .+�5)      (  "System.Windows.Controls.DatePicker  $��0��6   $	��200��5*      $
��Left=�5,      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ngày��5-       ( $MaterialDesignFloatingHintDatePicker#��[ 5.         SelectedDate 5+      �� *Date+5.      �� 5/      $��1��6    $  MaterialDesignRaisedAccentButton#��[ 50      $	��100��51      $
��Left=�52       � ToolTip$5 /Resource name: MaterialDesignRaisedAccentButton��53      $��Lọc��54      55      �� 56      $��2��6   $��Right=�6,   $��Số đơn hàng:��6H   $��15q�6\    $  MaterialDesignHeadline6TextBlock#��[ 6h   58        59      
��� ��� ! PrimaryHueDarkForegroundBrush#���  5:   &   $��0q�5;   &   $	��200��5<   &   $��Right=�5=   &   $��3��5>   &   .��5?      � .+�5@      �� $��15q�5A   $   #��[ 5C   $   ��5B   $   ��  �� Source# [  �� Path$ Count� �� Mode$ OneWay=�.  (System.Windows.Interactivity.Interaction   Triggers 5D      /  )System.Windows.Interactivity.EventTrigger  5E         	EventName$ PasswordChanged��6-   .  (System.Windows.Interactivity.TriggerBase   Actions. 5F   "   6	  0System.Windows.Interactivity.InvokeCommandAction	   	  Command 68   �� *PasswordChanged+ 	  CommandParameter 5G   $   �� $	 FloatingPasswordBox��5H      5J      5K      5L      5M      5N        5O   
   $��2��6   $
��auto��6+   $	��800��69   $	��Top=�6E   $��Center=�6]   .��5P      � .+�5Q      �� ��6   �� *ListHD+ �� SelectedItem 6:   �� *
SelectDate+ �� View 5R      �� 5S      .P�5T      �� $��Mã hóa đơn��5U   -    �� DisplayMemberBinding 5T   -   �� *
IDHoaDon+5U   -   �� 5V      $��Tổng số lượng��5W   -    5V   -   �� *TongSoLuong+5W   -   �� 5X      $��Tổng tiền��5Y   -    5X   -   �� *
TongTien+5Y   -   �� 5Z      $��Thời gian��5[   -    5Z   -   �� *	NgayLap+5[   -   5\      5^      5_      5`      5a      5b      