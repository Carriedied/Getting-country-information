   M S B A M L   `   `   `  ����M  ICountryInformation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CountryInformation.ViewCountryInformation.View  5      K*clr-namespace:CountryInformation.ViewModelCountryInformation.ViewModel  6B   5    /CountryInformation.View.AllCountriesInformation   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:CountryInformation.View     5      @	viewmodel*clr-namespace:CountryInformation.ViewModel     6B     � 	Resources  5	         fie �� 
TargetType �� Property �� Value �� 
TargetType �� TextAlignment �� Triggers P� Property P� Value��%�  &	        �� 5
   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6$   $��15(�6E   $
��Wrap=�6S   $ Center=�6g   5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� 5      �� 5      " ��6.   .R�5   "   �� #��z��6,   $��15(�6M   $
��Wrap=�6[   $ Center=�6o   
�������6�   5      5      5      5      5      .��5      � .+�5    
   �� .+�5!      �� $��50��6   $	��210��6!   $��1q�6-   
���   �$��10q�6U   ._�5"      �� $_��YВывести информацию о всех странах из базы данных��6   #��[  5#      $	��210��62   ��5"   T   �� *ShowAllCountries+5#   2   5$      �� 5%      -   5        	 ��Name$
	 list��5%      $��12(�6&   ��5&      �� *	Countries+
 �� View
 5'      �� 5(      .P�5)      ��  �� Width$
 Auto��6)   $��Название��5*   )    �� DisplayMemberBinding 5+   )   �� *Name+�� 5,      $
 Auto��6)   $��Код страны��5-   )    5.   )   �� *Code+�� 5/      $
 Auto��6)   $��Столица��50   )    51   )   �� *CapitalName+�� 52      $
 Auto��6)   $��Площадь��53   )    54   )   �� *Area+�� 55      $
 Auto��6)   $��Население��56   )    57   )   �� *
Population+�� 58      $
 Auto��6)   $��Регион��59   )    5:   )   �� *
RegionName+5;      5=      5>      5?      5@      