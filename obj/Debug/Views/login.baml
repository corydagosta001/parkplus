   M S B A M L   `   `   `  ����E  AParkingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ParkingApp.ViewsParkingApp.Views  5      ;"clr-namespace:ParkingApp.ViewModelParkingApp.ViewModel  5          ParkingApp.Views.login   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ParkingApp.Views     5      8	ViewModel"clr-namespace:ParkingApp.ViewModel     5      $��363.5��5      $	��576��6-   .��5      � .+�5   
   �� $
��Left=�6   $��39��6.   $��	37,91,0,0q�6:     �� TextWrapping$
  Wrap=�6M   $	��Top=�6�   $	��293��6�   ��6a   ��  �� Path$ UserName� �� Mode$ TwoWay=�.��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value 6-   �� $ UserName� �� Triggers 5      P� 5       P� Property � {� P� Value .  . �5      ��  � �� 65   Z� 5      5      .��5      5      �� 5   
   $
��Left=�6   $��39��6-   $��
37,147,0,0q�69   $
  Wrap=�6M   $	��Top=�6�   $	��293��6�   ��6b   �� $ UserPassword�$ TwoWay=�6�   �� 5   
   $��Login��6   $
��Left=�6L   $��
37,206,0,0q�6g   $	��Top=�6{   $	��293��6�   $��39��6�   ��6!   �� *GotoDestinationCommand+6�   �� 5    
   $
��Home��6   $
��Left=�6E   $��
10,520,0,0q�6`   $	��Top=�6t   $	��334��6�   $��39��6�   ��6!   �� *GotoHomeCommand+6�   5"      5#      