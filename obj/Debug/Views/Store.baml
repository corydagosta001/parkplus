   M S B A M L   `   `   `  ����E  AParkingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ParkingApp.ViewsParkingApp.Views  5      ;"clr-namespace:ParkingApp.ViewModelParkingApp.ViewModel  5      C&clr-namespace:ParkingApp.Event_ClassesParkingApp.Event_Classes  5          ParkingApp.Views.Store   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ParkingApp.Views     5      8	ViewModel"clr-namespace:ParkingApp.ViewModel     5      <	Converter&clr-namespace:ParkingApp.Event_Classes     5      $��363.5��5	      $	��576��6-     � 	Resources  5
      .   (ParkingApp.ViewModel.MainWindowViewModel   vm*   $ParkingApp.Event_Classes.MyConverter  cv'   !ParkingApp.Event_Classes.CBAssign  cba��%W   &	        &	      &	 &       5   
   6(     5   
   6      5   
   6   5      .��5      � $
��Left=�6   $	��363��6&   .+�5   
   �� -   5        $	��Off��5      $��Vehicle is turned off��6   $
��Left=�6>   $��	33,99,0,0q�6Y   $	��Top=�6l    J� RenderTransformOrigin$ 0.506,2.933&�6�   �� 5   
   -   5        $
��Park��5      $��Vehicle in park��6   $
��Left=�69   $��
33,129,0,0q�6T   $	��Top=�6h   $ 0.506,2.933&�6�   �� 5   
   -   5        $��Required��5      $L��FAll people, pets and required items have been removed from the vehicle��6#   $��33,160,80,0q�6t   $	��Top=�6�   �� 5   
   -   5        $��Brake��5      $��Parking brake is set��6    $
��Left=�6?   $��
33,192,0,0q�6Z   $	��Top=�6n   �� 5   
   $��Confirm��6   $��10,472,19,0q�6M   $	��Top=�6b   $	��334��6z   $��39��6�   ��6#   ��  �� Path$ ConfirmedStorage���5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       �� Binding 6"   �� *	IsChecked+ �� ElementName$	 Off�� �� Value	 false6Q   .a�5      ��  �� Property � y�	 �� Value$	 Hidden=�67   5      �� 5        6"   �� *	IsChecked+$
 Park��	 false6R   .a�5!      ��  � y�$	 Hidden=�6<   5"      �� 5#       6"   �� *	IsChecked+$ Required��	 false6V   .a�5$      ��  � y�$	 Hidden=�6<   5%      �� 5&       6"   �� *	IsChecked+$ Brake��	 false6S   .a�5'      ��  � y�$	 Hidden=�6<   5(      5*      
 � Triggers
 5-      :� 5.       :� RoutedEvent$ Button.Click��6   [�5/      �� 50      .��51      ��  �� 
TargetName$	 Off��6)    �� TargetProperty$ 	IsChecked�6:   .��52   "   ��  g� Duration$ 	0:0:0.001D�6A   .p�53   &   s�  �� Value .  6>   54   #   55      56      �� 57      .��58      �� $
 Park��6)   $ 	IsChecked�6;   .��59   "   �� $ 	0:0:0.001D�6A   .p�5:   &   s�  .  6>   5;   #   5<      5=      �� 5>      .��5?      �� $ Required��6)   $ 	IsChecked�6?   .��5@   "   �� $ 	0:0:0.001D�6A   .p�5A   &   s�  .  6>   5B   #   5C      5D      �� 5E      .��5F      �� $ Brake��6)   $ 	IsChecked�6<   .��5G   "   �� $ 	0:0:0.001D�6A   .p�5H   &   s�  .  6>   5I   #   5J      5K      5M      5Q      �� 5R   
   $��Cancel��6   $
��Left=�6G   $��
10,520,0,0q�6b   $	��Top=�6v   $	��334��6�   $��39��6�   $ -0.932,1.688&�6�   ��6"   �� *GotoHomeCommand+6�   5U      5V      