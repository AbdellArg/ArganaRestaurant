   M S B A M L   `   `   `  ����K  GArganaRestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ArganaRestaurantArganaRestaurant  5      m;clr-namespace:ArganaRestaurant.Ressources.Styles.Components-ArganaRestaurant.Ressources.Styles.Components  5      I)clr-namespace:ArganaRestaurant.ViewModelsArganaRestaurant.ViewModels  5      ,    &ArganaRestaurant.Views.ProductsBoxView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ArganaRestaurant     5      R
components;clr-namespace:ArganaRestaurant.Ressources.Styles.Components     5      9VMs)clr-namespace:ArganaRestaurant.ViewModels     5      -   5          N� Title$  ProductsBoxView��5
      .��5      �� ._�5   
   �� $��5q�6   
������ .+�5      �� $��20q�6    �� Orientation$ 
Horizontal=�6%   
������ .+�5      �� $	��120��6   $��Vegan��6%      NavBarButton#��[  6\   $��5q�6�   ��65   �� *LoadVeganProducts+6�   �� 5      $	��120��6   $	��All��6%   #��[  6U   $��5q�6|   ��63   �� *LoadProducts+6|   �� 5      ��6   �� *
Categories+��5      �� 5      .R�5      	� -   5         	� 	GroupName$ 
Categories��5   *     CategoriesItemTemplate#��[ 5   &   ��5   &   �� *Name+5   &   5      ��5"      �� 5#      .R�5$      �  � Orientation$ 
Horizontal=�6(   $
��True��6A   5%      5'      5)      �� 5+      -   5         ��Name$ ProductsList��5+      $��Disabled=�6,   $��False��5,        ProductsListBoxTemplate#���  5-        ProductsListItemTemplate#���  5.      $	��600��5/      
������ $��0q�51      ��52      �� *
Products+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� 
GroupStyle 54      (  "System.Windows.Controls.GroupStyle  55      ��58      �� 59      .R�5;      ?   9ArganaRestaurant.Ressources.Styles.Components.ProductCard    Name$ ProductCards��62   	 � DataContext	 6H   �� 5=      ��5@      �� 5A      .R�5B      � 
 K� IsItemsHost$

 True��6$   $
��Auto��67   $
��1100��6D   $ 
Horizontal=�6T   $��Center=�6m   5C      5E      5J      5L      5M      