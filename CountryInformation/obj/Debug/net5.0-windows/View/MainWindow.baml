   M S B A M L   `   `   `  ����M  ICountryInformation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CountryInformation.ViewModelCountryInformation.ViewModel  5   	   A%clr-namespace:CountryInformation.ViewCountryInformation.View  5   	   #    CountryInformation.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A
ViewModels*clr-namespace:CountryInformation.ViewModel     5   	   7Views%clr-namespace:CountryInformation.View     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��515��6)    � DataContext 5      6  0CountryInformation.ViewModel.NavigationViewModel  5   
    � 	Resources 5       �� DataType>   8CountryInformation.ViewModel.CountryInformationViewModel1   +CountryInformation.View.СountryInformationC   =CountryInformation.ViewModel.AllCountriesInformationViewModel5   /CountryInformation.View.AllCountriesInformation   fie �� 
TargetType �� Property �� Value �� 
TargetType �� TextAlignment	 �� Triggers
 P� Property P� Value��%S  (��       5      *, +)(�� 2     5      *, +)&	  d     �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6$   $��15(�6E   $
��Wrap=�6S   $ Center=�6g   5      5      	 5      P� 5       
 �@J�IsMouseOver$
 True��61   . �5!      ��  � �� 5"      �� 5#      " ��6.   .R�5$   "   �� #��z��6,   $��15(�6M   $
��Wrap=�6[   $ Center=�6o   
�������6�   5%      5'      5(      5*      5+      .��5-      ]� $
��True��6   .+�5.   
   �� $��1q�6   
���   �._�5/      �� -   5         ��Name$ 
navigation��5/      $
��Left=�6-   .+�50      �� $��9q�6   $��1q�6$   
���   �._�51      �� $0��*Ввести название страны��6   #��[  52      $��70��6:   ��51   >   �� *
EmpCommand+52   :   53      �� 54      $��9q�6   $��1q�6$   
���   �._�55      �� $$��Вывод всех стран��6   #��[  56      $��70��6:   ��55   8   �� *DeptCommand+56   :   57      58      59      �� 5:   
   -   5         ��Name$ Pages��5:      $��Right=�6(   ��6?   �� *SelectedViewModel+5;      5<      