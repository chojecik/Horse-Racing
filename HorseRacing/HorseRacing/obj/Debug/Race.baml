   M S B A M L   `   `   `  ����F  BHorseRacing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HorseRacingHorseRacing  5   	       HorseRacing.Race   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HorseRacing     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$
 Race��5	   	   $	��500��6   $	��640��6#   ��5
      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5      $ 	#FF58C909��6   $ 1Q�6-   5      .��5      � .+�5   
   �� -   5         ��Name$ 	theCanvas��5      .+�5      �� -   5         ��Name$ 	Rectangle��5      $��87��6+   $	��630��67   
���`���
 �� Top$	 356��6U   	 �� Left$	 2��6f   A� 5      -   5        
 A�Name$
 
theEllipse��5      $��10��6*   $��10��66   
���   �$	 356��6N   A� 5      -   5        $
 theEllipse1��5      $��10��6+   $��10��67   
���**��$	 371��6O   A� 5      -   5        $
 theEllipse2��5      $��10��6+   $��10��67   
�������$	 386��6P   A� 5      -   5        $
 theEllipse3��5      $��10��6+   $��10��67   
��� ���$	 401��6N   A� 5      -   5        $
 theEllipse4��5      $��10��6+   $��10��67   
���  ��$	 416��6M   A� 5      -   5        $
 theEllipse5��5      $��10��6+   $��10��67   
����  �$	 431��6N   �� 5      
�������$��87��6%   $	 10��61   $	 356��6B   $��5��6S   �� 5      
�������$��87��6%   $		 594��61   $	 356��6C   $��6��6T   �� 5      -	   5         ��Name$ label1��5      $	 46��6$   $ 80��65   $��30��6E   $	��101��6Q   $��14.667(�6]   �� 5      -
   5        $ label2��5      $	 46��6$   $	 100��65   $��30��6F   $	��101��6R   $��14.667(�6^   �� 5      -   5        $ label3��5      $	 46��6$   $	 120��65   $��30��6F   $	��101��6R   $��14.667(�6^   �� 5      -   5        $ label4��5      $	 46��6$   $	 140��65   $��30��6F   $	��101��6R   $��14.667(�6^   �� 5      -   5        $ label5��5      $	 46��6$   $	 160��65   $��30��6F   $	��101��6R   $��14.667(�6^   �� 5       -   5        $ label6��5       $	 46��6$   $	 180��65   $��30��6F   $	��101��6R   $��14.667(�6^   �� 5!      -   5        $ label��5!      $��	WINNING: ��6#   $		 217��67   $ 83��6I   $��30��6Y   $��96��6e   $��16(�6p   ���	#FFF7F7F46~   �� 5"      -   5        $ winning��5"      $��Label��6%   $		 313��65   $ 83��6G   $��30��6W   $	��172��6c   $��16(�6o   �� 5#      -   5        $ label7��5#      $��Selected horse: ��6$   $		 217��6?   $	 140��6Q   $	��130��6b   $��16(�6n   ���	#FFFFF7F76|   �� 5$      -   5        $ label8��5$      $		 352��6$   $	 140��66    J� RenderTransformOrigin$ -0.316,0.154&�6G   $	��102��6l   ���	#FFF7F2F2$��16(�6�   5&      5'      5(      