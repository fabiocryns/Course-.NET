   M S B A M L   `   `   `  ����B  >VBChess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:VBChessVBChess  5   	       VBChess.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:VBChess     5   	     � Title$  VB.NET Chess��5   	    � WindowState$ 	Maximized=�5	   	    � 	Resources 5
         VBChess.SelectedConverter   selectedConverter   VBChess.EnabledConverter  enabledConverter#   VBChess.PawnToStringConverter  textConverter��%W   &	        &	      &	 &       5   
   6"     5   
   6!     5   
   6&   5      ��5      �� 5   
    �� ImageSource$! ../Resources/background.png��6    j� TileMode$
 Tile=�6?    j� Stretch$
 None=�6O    j� Viewport$ 0,0,438,212�6^    j� ViewportUnits$ Absolute=�6u   .��5      (� $��0.5cmq�6   .��5   
   �� .+�5      �� ��6   �� *Game.Value.Board.Value.Rows+��5      �� 5      $ ../Resources/board.jpg��6!   ��5      �� 5      .R�5      �� ��6'   �� *	Squares+��5      �� 5   "   .R�5   &   �� $��44��6-   $��44��68   ��6D   �� *Click+��5   *   �� 5   .   .R�5    2   ��  ��Name$ squareBorder��69   ��6O   �� *	IsEnabled+	 �� RelativeSource	 �� *Self+
 �� 	Converter#
 [ ._�5!   6      VBChess.OutlinedTextBlock    Name$ 	textBlock��6N      TextAlignment$ Center=�6a   $��Center=�6x      
FontFamily$ Verdana)�6�      TextDecorations$ 	Underline{�6�      
FontWeight$ 	ExtraBold"�6�      FontSize$ 35(�6�      StrokeThickness$ 1Q�6T     Stroke 6�   �� *Selected.Value+#
 [   �� ConverterParameter$ Stroke��   Text. 6h   5"   :   `� 5#   >    `� 	Converter# [ 6K   .1�5$   B   ��  �� Path$ Content.Value.PawnType�6J   �� 5%   B   $% Content.Value.Owner.Orientation�6J   5&   ?   . 5'   X    J� Effect 5(   :   3  -System.Windows.Media.Effects.DropShadowEffect  5)   >      
BlurRadius$ 10Q�6O      Color$
 Gold��6_      ShadowDepth$ 0Q�6m      RenderingBias$ Quality=�6�      Opacity 6}   �� *Selected.Value+#
 [  $ Opacity��6�   . 5*   Z   ��5+   :   �� 5,   >    �� 
TargetType"  6D   .�5-   B   ��  �� Property �@ Fill �� Value
 �   �6Y     �� Triggers  5.   B   �� 5/   F   ! �� Binding! 6R   �� " �� ElementName$" squareBorder��$ IsMouseOver�# �� Value# True6�   .a�50   J   ��  �@ Fill
 �  ��6a   51   G   53   ?   . 54   Y   55   7   56   3   57   /   59   '   5:   #   ��5<      �� 5=   "   .R�5>   &   �� $ �� Orientation$$ 
Horizontal=�61   5?   #   5A      5B      ��5D      �� 5E      .R�5F      �� $$ Vertical=�6%   $��25q�6<   $	��352��6H   $	��352��6T   5G      5I      �� 5J      $��0,10,0,0q�63   ��6   �� *	PlayAgain+.��6E   
Play again6Q   5K      5L      5M      