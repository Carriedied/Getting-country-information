   M S B A M L   `   `   `  ����M  ICountryInformation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CountryInformation.ViewCountryInformation.View  5      _4clr-namespace:CountryInformation.VisibilityConverter&CountryInformation.VisibilityConverter  5      C&clr-namespace:CountryInformation.ModelCountryInformation.Model  5      K*clr-namespace:CountryInformation.ViewModelCountryInformation.ViewModel  6D   1    +CountryInformation.View.СountryInformation   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:CountryInformation.View     5      K
Converters4clr-namespace:CountryInformation.VisibilityConverter     5      9Models&clr-namespace:CountryInformation.Model     5      @	viewmodel*clr-namespace:CountryInformation.ViewModel     6D     � 	Resources  5      I   CCountryInformation.VisibilityConverter.BooleanToVisibilityConverter   BooleanToVisibility  fie �� 
TargetType �� Property �� Value �� 
TargetType �� TextAlignment �� Triggers P� Property P� Value��%�  &	        &	        5   
   62   �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6$   $��15(�6E   $
��Wrap=�6S   $ Center=�6g   5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� 5      �� 5      " ��6.   .R�5   "   �� #��z��6,   $��15(�6M   $
��Wrap=�6[   $ Center=�6o   
�������6�   5      5      5      5!      5"      .��5#      � .+�5$   
   �� 	 �� Orientation$	 Vertical=�6   .+�5%      �� 
�������$��55��61   $	 
Horizontal=�6=   $	��Top=�6V   $��
0, 1, 0, 0q�6n   .+�5&      �� $4��.Введите название страны: ��6   $��15(�5'      $��Times new Roman)�6&   $��Center=�5(      �� 5)      $	 Vertical=�6   .+�5*      �� $��0 2 0 2q�67   ��6    �� *Error+67   �� 5+      $��15(�6   $��Times new Roman)�6,   $��Center=�5,      $
 �� HorizontalScrollBarVisibility$

 Auto=�5-      $	��140��5.      ��5/      �� *Text+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��50      �� 51      $��15q�6   $��1q�6%   
���   �._�52      �� $��Искать��6   #��[ 53      $��60��6:   ��52   .   �� *SubmitCommand+53   :   54      55      �� 56      -   5         ��Name$
 list��56      $��12(�6&   y�57      �� *MyVisibility+ �� 	Converter# [  ��58      �� *	Countries+ �� View 59      �� 5:      .P�5;      ��  �� Width$
 Auto��6)   $��Название��5<   )    �� DisplayMemberBinding 5=   )   �� *Name+�� 5>      $
 Auto��6)   $��Код страны��5?   )    5@   )   �� *Code+�� 5A      $
 Auto��6)   $��Столица��5B   )    5C   )   �� *CapitalName+�� 5D      $
 Auto��6)   $��Площадь��5E   )    5F   )   �� *Area+�� 5G      $
 Auto��6)   $��Население��5H   )    5I   )   �� *
Population+�� 5J      $
 Auto��6)   $��Регион��5K   )    5L   )   �� *
RegionName+5M      5O      �� 5P      $��15q�6   $��1q�6!   
���   �$	��120��6I   y�5Q      �� *MyVisibility+# [  ._�5R      �� $F��@Сохранить информацию в базу данных��6   #��[ 5S      $	��120��66   ��5R   F   �� *AddToDbCommand+5S   6   5T      5U      5V      5W      