   M S B A M L   `   `   `  ����E  AParkingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ParkingApp.ViewsParkingApp.Views  5          ParkingApp.Views.Retrieve   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ParkingApp.Views     5      $��363.5��5      $	��576��6-   .��5	      � .+�5
   
   �� $
��Left=�6   $��80��60   $��0,66,0,0q�6<   
����  �$	��Top=�6`   $	��364��6x   .+�5      �� $
��Wrap=�6   $��	TextBlock��6,   $��0��6=   �� 5      $
��Wrap=�6   $��30(�6,   $��It'S Cold Out!!!!��6:   $��
25,20,10,0q�6S   $��41��6g     J� RenderTransformOrigin$  0.533,0.468&�6s   �� 5      $��253,20,10,0q�6    �� Orientation$ Vertical=�6.   .+�5      �� $
��Wrap=�6   $��Any City��60   $��	-22,0,0,0q�6@   5      5      �� 5   
   $
��Left=�6   $��
23,164,0,0q�6/   $
��Wrap=�6C   $��Welcome sir!��6W   $��20(�6k   $	��Top=�6y   $��33��6�   $	��307��6�   �� 5   
   $
��Left=�6   $��
23,202,0,0q�6/   $
��Wrap=�6C   $��Select your vehicle��6W   $��14(�6r   $	��Top=�6�   $	��198��6�   $��20��6�   �� 5   
   $
��Left=�6   $	��233��60   $��
23,238,0,0q�6=   $	��Top=�6Q   $	��307��6i   .+�5      �� .+�5      �� ��6   ��  �� Path$ 
MyVehicles���5      �� 5      .R�5      �� $ 
Horizontal=�6)   .+�5   "   �� $	��300��6i   $��33��6u   ��6)   �� $
 Make���6G   �� $ GotoTest� � Triggers 5   &   :� 5   *    :� RoutedEvent$ Button.Click��67   [�5   .   5   +   5!   #   5%      5&      5(      5)      5+      �� 5-   
   $��Cancel��6   $
��Left=�6G   $��
10,520,0,0q�6b   $	��Top=�6v   $	��334��6�   $��39��6�   $  -0.932,1.688&�6�   ��6"   �� *GotoHomeCommand+6�   �� 5.   
   $��Retrieve Vehicles��6   $
��Left=�6R   $��
10,471,0,0q�6m   $	��Top=�6�   $	��334��6�   $��39��6�   ��6-   �� *GotoRetrieveCars+6�   54      55      