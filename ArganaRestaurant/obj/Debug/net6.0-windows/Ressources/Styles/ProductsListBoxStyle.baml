   M S B A M L   `   `   `  ����W  SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBar.Static.Background  �� Color  ScrollBar.Static.Border  ScrollBar.Static.Glyph  ScrollBar.Static.Thumb " ScrollBar.MouseOver.Background  ScrollBar.MouseOver.Border  ScrollBar.MouseOver.Glyph  ScrollBar.MouseOver.Thumb   ScrollBar.Pressed.Background 	 ScrollBar.Pressed.Border 
 ScrollBar.Pressed.Thumb  ScrollBar.Pressed.Glyph ! ScrollBar.Disabled.Background  ScrollBar.Disabled.Border  ScrollBar.Disabled.Glyph  ProductsListBoxTemplate �� 
TargetType ��Name �� Padding J� SnapsToDevicePixels  ScrollViewerStyle  ProductsListItemTemplate �� 
TargetType �� Property �� Value ��Name  CategoriesItemTemplate  SourceSansPro	 �� CornerRadius
 �� Triggers :� RoutedEvent �� TargetProperty �� From  SecondColorAsColor	 �� To g� Duration  MainColorAsColor P� Property P� Value  	MainColor  RepeatButtonTransparent  ScrollBarButton �� 
TargetName  ScrollBarThumbVertical � Cursor  ScrollBarThumbHorizontal ��Name  ScrollBarStyle �Name � RowDefinitions ��Name �� LineUpCommand J� IsMouseOver F�Name �� Stretch ]�Name ]� DecreaseRepeatButton �� PageUpCommand ]� IncreaseRepeatButton  �� PageDownCommand! ]� Thumb" �� LineDownCommand# ^� 
Conditions$ �� Binding% �� ElementName& �� Value' �� Triggers( � ColumnDefinitions) �� LineLeftCommand* �� PageLeftCommand+ �� PageRightCommand, �� LineRightCommand- ��Name. �� CanHorizontallyScroll/ �� CanVerticallyScroll0 �� CanContentScroll1 ��Name4    .System.Windows.Automation.AutomationProperties2    AutomationId3 �� ScrollableHeight4 � Maximum5 � Minimum6 �� ViewportHeight7 �� ViewportSize*8 �� #ComputedVerticalScrollBarVisibility9 � Value: �� Mode; �� RelativeSource< �� ScrollableWidth= �� Orientation> �� ViewportWidth,? �� %ComputedHorizontalScrollBarVisibility�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %80  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     &	     &		 )    &	
 J    &	 k    &	 �    &	 �    &	 �    &	 �    &	 �    &	 g    7  7  7  7  &	 �	    &	 Y    7   7  7  7  7  7 	 7  7  &	 �    7  7  7 
 &	 A    7  7  7 
 &	 f    7   7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 �)    �� 5      $  #E6DDC6��6:   �� 5      $  #C2B8A3��66   �� 5	      $  #354f52��65   �� 5
      $  #E6DDC6��65   �� 5      $  #A19882��6=   �� 5      $  #FEF7DC��69   �� 5      $  #FFFFFF��68   �� 5      $  #C2B8A3��68   �� 5      $  #FEF7DC��6;   �� 5      $  #A19882��67   �� 5      $  #A19882��66   �� 5      $  #000000��66   �� 5      $  #E6DDC6��6<   �� 5      $  #C2B8A3��68   �� 5      $  #354f52��67   �� 5      " ��66   .R�5   
   �� $ Bd��6   #��z��6   #��z��5      #��z��5      $ 1q�5      $
 true��6   ._�5      �� #���  6   $|�false��6G   #��z��6Y   .��5      �� # z 6!   5       5!      5"      �� 5&      " ��6-   .�5'   
   ��  � ��$	 220��6#   �� 5(   
    � ��$	 200��6"   �� 5*   
    � �� 5+      �� 5-      " ��6"   .R�5.      �� $ Bd��6   #��z��5/   5   #��z��50   5   #��z��51   5   # z��52   5   $
 true��6Y   ._�53      �� $ Holder��6+   #��z��6;   # z 54   C   #��z��55   C   56      58      5:      5<      �� 5?      " 	�6+   .�5@   
   ��  � ��$ 40��6#   �� 5A   
    � ��$	 120��6"   �� 5B   
    �@�Cursor$
 Hand��6#   �� 5C   
    � ��$ 14(�6%   �� 5D   
    � ��$ Regular"�6'   �� 5E   
    � ��8   6'   �� 5F   
    � ��
 ���� 6(   �� 5G   
    � ��$	 1.5q�6,   �� 5I   
    � �� 5J      �� 5L      " 	�6"   .R�5M      �� $ Bd��6   $	 20��5N      $��Center=�5O      $��Center=�5P      $	��110��5Q      $��40��5R      #��z��5S      #��z��5T      #��z��5U      # z��5V      $
 true��6A   ._�5W      �� $ Holder��6+   $��Center=�6;   # z 5X   +   $��Center=�5Y   +   5Z      
 5^      :� 5_      $ 
MouseEnter��6'   .[�5`      �� .��5a   "   �� .��5b   &   �� $ Background.Color�65    #FFFFFF6b   8  $ 0:0:0.3D�6�   �� 5c   &   $ Foreground.Color�65    #0000006b    #FFFFFF6q   $ 0:0:0.3D�6~   5d   #   5f      5h      :� 5j      $ 
MouseLeave��6'   .[�5k      �� .��5l   "   �� .��5m   &   �� $ Background.Color�65   8   #FFFFFF6�   $ 0:0:0.2D�6�   �� 5n   &   $ Foreground.Color�65    #FFFFFF6b    #0000006q   $ 0:0:0.2D�6~   5o   #   5p      5q      P� 5s       �@d�	IsChecked$
 TrueY�67   . �5t      �� 8   � ��6<   �� 5u       � �� �#FFFFFF6;   5v      5y      5|      5�      �� 5�      " ��6,   .�5�   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5�   
    � ��
 ���� 6'   �� 5�   
    � |�$ false��6&   �� 5�   
    � ��$ false��6&   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� #��z��6    #��z��5�       #��z��5�       5�      5�      5�      �� 5�      " ��6$   .�5�   
   ��  � ��$ 1q�6,   �� 5�   
    � ��$ Center=�67   �� 5�   
    � ��$ Center=�65   �� 5�   
    � ��$ 1q�6$   �� 5�   
    � |�$ false��6&   �� 5�   
    � ��$ false��6&   �� 5�   
    �@�Cursor$
 Hand��6#   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $ border��6   $	��0 2q�6-   $	 5��6:   8��  8�� $��0q�5�      $
 true��61   ._�5�      �� $ contentPresenter��6+   $|�False��6E   #��z��5�   +   #��z��5�   +   # z 5�   +   #��z��5�   +   5�      
 5�      P� 5�       �@J�IsMouseOver$
 true��69   . �5�      �� $ border��6;   8   � ��6O   �� 5�      $ border��6<   8   � ��6P   5�      P� 5�       � ��$
 true��67   . �5�      �� $ border��6;   8   � ��6O   �� 5�      $ border��6<   8   � ��6P   5�      P� 5�       � {�$ false��67   . �5�      �� $ contentPresenter��68    �@J�Opacity$
 0.56Q�6V   �� 5�      $ border��6;   8   � ��6O   �� 5�      $ border��6<   8   � ��6P   5�      5�      5�      5�      �� 5�      " n�6+   .�5�   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5�   
    � ��$ false��6&   �� 5�   
    � �� 5�      �� 5�      " n�6"   .R�5�      �� $ 	rectangle��6   $	 5��60   $
 Hand��6A   $��0q�5�      8��  #��z��5�      $
 True��6?   #��z��5�      
 5�      P� 5�       �@J�IsMouseOver$
 true��69   . �5�      �� $ 	rectangle��6;   8   � ��6R   5�      P� 5�       �@n�
IsDragging$
 true��68   . �5�      �� $ 	rectangle��6;   8   � ��6R   5�      5�      5�      5�      �� 5�      " n�6-   .�5�   
   ��  �@�OverridesDefaultStyle$
 true��62   �� 5�   
    � ��$ false��6&   �� 5�   
    � �� 5�      �� 5�      " n�6"   .R�5�      �� $ 	rectangle��6    8��  #��z��5�       $
 True��5�       #��z��5�       
 5�      P� 5�       �@J�IsMouseOver$
 true��69   . �5�      �� $ 	rectangle��65   8   � ��6L   5�      P� 5�       �@n�
IsDragging$
 true��68   . �5�      �� $ 	rectangle��65   8   � ��6L   5�      5�      5�      5�      �� 5�      " ��6#   .�5�   
   ��  �@��IsPressAndHoldEnabled$ false��69   �� 5�   
    �@��IsFlicksEnabled$ false��63   �� 5�   
    � ��8   6'   �� 5�   
    � ��8  6(   �� 5�   
    � ��# � ��6'   �� 5�   
    � ��$ 8q�6,   �� 5�   
    � ��$ 23��6"   �� 5�   
    � ��# � r�6%   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      � $ Bg��6   $
 true��6'   $	��0 5q�6B    5      �� 5     $��23��6,   �� 5     $��0.00001* �6,   �� 5     $��23��6,   .+�5     �� $��Holder��6!   8�� $	 5��5  !   $	��0 4q�62   $��1��6?   
������ #��z��5  !   �� 5	     $ PART_LineUpButton��6'   $��0��6B   #��Z 5
  '   #{�z 5  '   8�� .��5     F� $ ArrowTop��6#   �����     	= �     	= ��[ ��[ �    ��[ �g5 �%& �g5 �%& ��g5 �%& ��j ��[ ��j ��[ ���j ��[ ��j  	= ��j  	= ���j  	= �g5  � �g5  � ��g5  �  	=  	= 	8�� $��3,4,3,3q�5  #   $ Uniform=�64   5     ]� 5     $ 
PART_Track��6    $
��true��64   $	��0 4q�6P   #{�z 6]   $��1��6�    5     �� 5  "   #��Z 6/   8�� 5  /    5     �� 5  "   #��Z  6/   8�� 5  /   ! 5     n� 5  "   8�� 6(   5     �� 5     $ PART_LineDownButton��6'   $��2��6D   #��Z" 5   '   #{�z 5!  '   8�� .��5#     F� $ ArrowBottom��6#   �����    �%& �    �%&  �  � �     � �g5  	= �g5  	= ��g5  	= ��j  � ��j  � ���j  � ��j �%& ��j �%& ���j �%& �g5 ��[ �g5 ��[ ��g5 ��[ �%& �%& 	8��	 $��3,4,3,3q�5&  #   $ Uniform=�64   5'     5(     
 5)     ^� 5*     # 5+     �� 5,  "   $ 6,   �� *IsMouseOver+$% PART_LineDownButton��& true6m   �� 5-  "   $ 6,   �� *	IsPressed+$% PART_LineDownButton��& true6k   .0�5/     �� $ ArrowBottom��65   8 
  � ��6N   50     ^� 51     # 52     �� 53  "   $ 6,   �� *IsMouseOver+$% PART_LineUpButton��& true6k   �� 54  "   $ 6,   �� *	IsPressed+$% PART_LineUpButton��& true6i   .0�56     �� $ ArrowTop��65   8   � ��6K   57     ^� 58     # 59     �� 5:  "   $ 6,   �� *IsMouseOver+$% PART_LineDownButton��& true6m   �� 5;  "   $ 6,   �� *	IsPressed+$% PART_LineDownButton��	& false6k   .0�5=     �� $ ArrowBottom��65   8   � ��6N   5>     ^� 5?     # 5@     �� 5A  "   $ 6,   �� *IsMouseOver+$% PART_LineUpButton��& true6k   �� 5B  "   $ 6,   �� *	IsPressed+$% PART_LineUpButton��	& false6i   .0�5D     �� $ ArrowTop��65   8   � ��6K   5E     P� 5F      � {�$ false��67   . �5G     �� $ ArrowTop��65   8   � ��6K   �� 5H     $ ArrowBottom��65   8   � ��6N   5I     5K     5M     ' 5N  
   P� 5O      �@��Orientation$ 
Horizontal=�6-   . �5P     ��  � ��$
 Auto��6*   �� 5Q      � ��$ 0��6-   �� 5R      � ��# � ��6+   �� 5S      � ��# � ��6.   �� 5T      � ��$	 0,1q�64   �� 5U      � �� 5V     �� 5W     " ��6*   .R�5X     � $ Bg��6#   $
 true��6/   ( 5Y  "   �� 5Z  &   #��� ��67   �� 5[  &   $��0.00001* �67   �� 5\  &   #��� ��67   .+�5^  "   �� #��z��6)   #��z��6S   #��z��6   $��1��6�   �� 5_  "   $ PART_LineLeftButton��6/   #��Z) 6L   #{�z 6{   8�� .��5`  &   F� $ 	ArrowLeft��6+   �������0 ��j ���0 ��j @KL ��j @KL ��j �@KL ��j P� �g5 P� �g5 �P� �g5 @KL @KL �@KL     ��0 ��0 ���0     �g5 �g5 �    �g5 ��0 ��j ��0 ��j 	8�� $��3q�6�   $ Uniform=�6�   5a  #   ]� 5b  "   $ 
PART_Track��6(   $��1��6<   #{�z 6L    5c  &   �� 5d  *   #��Z* 67   8�� 6f    5f  &   �� 5g  *   #��Z+ 67   8�� 6g   ! 5i  &   n� 5j  *   8�� 60   5l  #   �� 5m  "   $ PART_LineRightButton��6/   #��Z, 6M   $��2��6}   #{�z 6�   8�� .��5n  &   F� $ 
ArrowRight��6+   �����P� ��j �P� ��j ��j ��j �    ��j ��0 �g5 ��0 �g5 ���0 �g5 �        P� P� �P�     @KL �g5 @KL �g5 �@KL �g5 P� ��j P� ��j 	8�� $��3q�6�   $ Uniform=�6�   5o  #   5p     
 5q     ^� 5r  "   # 5s  &   �� 5t  *   $ 64   �� *IsMouseOver+$% PART_LineRightButton��& true6v   �� 5u  *   $ 64   �� *	IsPressed+$% PART_LineRightButton��& true6t   .0�5w  &   �� $ 
ArrowRight��6=   8   � ��6U   5x  #   ^� 5y  "   # 5z  &   �� 5{  *   $ 64   �� *IsMouseOver+$% PART_LineLeftButton��& true6u   �� 5|  *   $ 64   �� *	IsPressed+$% PART_LineLeftButton��& true6s   .0�5~  &   �� $ 	ArrowLeft��6=   8   � ��6T   5  #   ^� 5�  "   # 5�  &   �� 5�  *   $ 64   �� *IsMouseOver+$% PART_LineRightButton��& true6v   �� 5�  *   $ 64   �� *	IsPressed+$% PART_LineRightButton��	& false6t   .0�5�  &   �� $ 
ArrowRight��6=   8   � ��6U   5�  #   ^� 5�  "   # 5�  &   �� 5�  *   $ 64   �� *IsMouseOver+$% PART_LineLeftButton��& true6u   �� 5�  *   $ 64   �� *	IsPressed+$% PART_LineLeftButton��	& false6s   .0�5�  &   �� $ 	ArrowLeft��6=   8   � ��6T   5�  #   P� 5�  "    � {�$ false��6?   . �5�  &   �� $ 	ArrowLeft��6=   8   � ��6T   �� 5�  &   $ 
ArrowRight��6=   8   � ��6U   5�  #   5�     5�     5�     5�     �� 5�     " ��6&   .�5�  
   ��  � �� 5�     �� 5�     " ��6"   .R�5�     � $
 Grid��6   #��z��6)   ( 5�     �� 5�     $��* �6/   �� 5�     $��30 �6/    5�     �� 5�     $��* �6,   �� 5�     $��0 �6,   .+�5�     �� $ Corner��6$   $��1��64   #��� ��6D   $��1��6�   �� 5�     $!- PART_ScrollContentPresenter��61   $. False��6V   #��z��6t   $/ False��6�   $��0��6�   #��z��6�   #0 z��6�   #��z��6.  $��0��6Q  �� 5�     $1 PART_VerticalScrollBar��6M   #���  6$   $2 VerticalScrollBar��6m   $ Arrow��6�   $��1��6�   #4 z3 6�   $5 0Q�6�   $��0��6�   #7 z6 6g  #y�z8 6�  9 6  �� *VerticalOffset+$: OneWay=�; �� *TemplatedParent+6�  �� 5�     $1 PART_HorizontalScrollBar��6$   $2 HorizontalScrollBar��6F   $ Arrow��6~   $��0��6�   #4 z< 6�   $5 0Q�6�   $= 
Horizontal=�6�   $��1��6�   #7 z> 6\  #y�z? 6�  9 6�   �� *HorizontalOffset+$: OneWay=�; �� *TemplatedParent+6�  5�     5�     5�     ' 5�  
   P� 5�      � {�$ false��6+   . �5�     ��  � ��# � ��6/   5�     5�     5�     