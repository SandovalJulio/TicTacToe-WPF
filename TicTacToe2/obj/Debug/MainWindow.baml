   M S B A M L   `   `   `  ����F  BTic Tac Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TicTacToe2
TicTacToe2  5   	       TicTacToe2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:TicTacToe2     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ TicTacToe por Julio��5   	   $	��600��6%   $	��800��62    � WindowStyle$
 None=�6>    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6k   $	��600��6�   $	��800��6�   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��800* �6   �� 5      .+�5   
   �� -   5         ��Name$ imageBackground��5      $
��Left=�6)   $	��600��6D   $	��Top=�6Q   $	��800��6i   $��Resources/Background.png��6u   $
��Fill=�6�   $��2��6�   �� 5   
   -   5        $ titleBar��5      $
��Left=�6"   $��20��6=   $	��Top=�6I   $	��800��6a   $��Resources/TitleBar.png��6m   $��2��6�   �� 5   
   -   5        $ 
exitButton��5      $
��Left=�6$   $��20��6?   $��	780,0,0,0q�6K   $	��Top=�6^   $��20��6v   $��Resources/Exit.png��6�   $��2��6�   �� 5   
   -   5        $ minusButton��5      $
��Left=�6%   $��20��6@   $��	760,0,0,0q�6L   $	��Top=�6_   $��20��6w   $��Resources/Minus.png��6�   6�   �� 5   
   -   5        $ imageWindow0��5      $��174.5,78,174.5,78q�6&   $��Resources/Window.png��6A   �� 5   
   -   5        $ 	imageHelp��5      $��747,20,0,526q�6#   $��Resources/Signo.png��69   $
��Fill=�6V    J� Opacity$
 0.65Q�6e    � Cursor$
 Hand��6t   6�   � 5   
   -   5        	 �Name$	 gridInfo��5      $
��Left=�6!   $	��580��6<   $��0,20,0,0q�6I   $	��Top=�6[   $	��800��6s   $��2��6   {�.  $ 0Q�6�   .+�5      �� -	   5        $��661,39,0,427q�5      $��Resources/Window.png��6*   $
��Fill=�6H   $
 Hand��6W   6�   �� 5      -
   5        
 ��Name$
 textDesignedBy��5      $
��Left=�60   $��
680,58,0,0q�6K   $
��Wrap=�6_   $"��DISEÑADO Y DESARROLLADO POR��6s   $	��Top=�6�   $��
Montserrat)�6�   $��10(�6�   $
��Bold"�6�    J� OpacityMask
 �   ����	#FF464646$	��101��6  $��55��6   �� TextAlignment$ Center=�6)  $  ��6@  �� 5      -   5        $
 
textMyName��5      $
��Left=�6,   $��
684,98,0,0q�6G   $
��Wrap=�6[   $��JULIO SANDOVAL��6o   $	��Top=�6�   $��
Montserrat)�6�   $��10(�6�   $
��Bold"�6�   
 �   ����	#FF999999$ Center=�6   $
 Hand��6*  �� 5      -   5        $ 	imgGitHub��5      $��721,115,60,446q�6'   $��Resources/Sin título.png��6?   $
��Fill=�6a   $
 Hand��6�   5      � 5   
   -   5        $	 gridHelpPlaying��5      {�.  $ 0Q�6W   .+�5      �� -   5        $
 	textHelp1��5      $
��Left=�6+   $��287,196,0,0q�6F   $
��Wrap=�6[   $��1��6o   $	��Top=�6x   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   �� 5       -   5        $
 	textHelp2��5       $
��Left=�6+   $��367,196,0,0q�6F   $
��Wrap=�6[   $	��Top=�6o   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   $��2��6�   �� 5!      -   5        $
 	textHelp5��5!      $
��Left=�6+   $��367,278,0,0q�6F   $
��Wrap=�6[   $��5��6o   $	��Top=�6x   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   �� 5"      -   5        $
 	textHelp6��5"      $
��Left=�6+   $��448,278,0,0q�6F   $
��Wrap=�6[   $��6��6o   $	��Top=�6x   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   �� 5#      -   5        $
 	textHelp8��5#      $
��Left=�6+   $��367,359,0,0q�6F   $
��Wrap=�6[   $��8��6o   $	��Top=�6x   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   �� 5$      -   5        $
 	textHelp4��5$      $
��Left=�6+   $��287,278,0,0q�6F   $
��Wrap=�6[   $��4��6o   $	��Top=�6x   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   �� 5%      -   5        $
 	textHelp3��5%      $
��Left=�6+   $��448,196,0,0q�6F   $
��Wrap=�6[   $��3��6o   $	��Top=�6x   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   �� 5&      -   5        $
 	textHelp7��5&      $
��Left=�6+   $��287,359,0,0q�6F   $
��Wrap=�6[   $��7��6o   $	��Top=�6x   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   �� 5'      -   5        $
 	textHelp9��5'      $
��Left=�6+   $��448,359,0,0q�6F   $
��Wrap=�6[   $��9��6o   $	��Top=�6x   $��
Montserrat)�6�   $��50(�6�   $
��Bold"�6�   $��66��6�   $ Center=�6�   $��66��6�   $	 0.1Q�6�   5(      � 5*   
   -   5        $	 gridHome��5*      $
��Left=�6!   $	��580��6<   $��0,20,0,0q�6I   $	��Top=�6[   $	��800��6s   $��2��6   $y�Visible=�6�    5+      �� 5,      $
��311* �6#   �� 5-      $	��89* �6#   .+�5/      �� -   5        $ imageWindowHome��5/      $��165,59,165,79q�6-   $��Resources/Window.png��6D    J� RenderTransformOrigin$	 0,0&�6b   $��2��6~   �� 50      $��50��6   $	��Top=�6    $��Resources/2 JUGADORES.png��68   $ 0.387,-0.19&�6[   $��269,145,91,0q�6   $ 1Q�6�   �� 51      $
��Left=�6   $��18��6/   $	��Top=�6;   $��68��6S   $��Resources/ELIGE.png��6^   $��366,263,0,0q�6{   �� 52      -   5        $ oFrame��52      $��Resources/O frame2.png��6$   $
��Fill=�6D   $	��112��6S   $	��112��6`   $��419,302,91,166q�6�   $
 Hand��6�   
 J� Uid$ CÍRCULO��6�   �� 53      -   5        $ xFrame��53      $��Resources/X frame2.png��6$   $
��Fill=�6D   $	��112��6S   $	��112��6`   $��269,302,241,166q�6�   $
 Hand��6�   $
 CRUZ��6�   6�   � 55      -   5        $	 gridHelpHome��55      {�. $��222,110,40,110q�6:   $	��360��6R   $	��360��6^   $��Center=�6k   $��Center=�6�   $ 0Q�6�   $y�Hidden=�6�   .+�56      �� -   5         ��Name$ rectHelpHomeO��56      ���	#FFFFFFFF$
��Left=�6D   $	��112��6_   $��
47,192,0,0q�6l   $	��Top=�6�   $	��112��6�   $
 0.33Q�6�   6�   �� 57      -   5        $ rectHelpHomeX��57      ���	#FFFFFFFF$
��Left=�6D   $	��112��6_   $��197,192,0,0q�6l   $	��Top=�6�   $	��112��6�   $
 0.33Q�6�   6�   �� 58      $
��Left=�6   $��
80,241,0,0q�67   $
��Wrap=�6K   $��"CRUZ"��6_   $	��Top=�6w   $��
Montserrat)�6�   $
��Bold"�6�   ���	#FF424242$��Italic$�6�   �� 59      $
��Left=�6   $��219,242,0,0q�67   $
��Wrap=�6L   $	��Top=�6`   $��
Montserrat)�6x   $
��Bold"�6�   ���	#FF424242�� 6�   $�"��6�   �� 6�   $��Italic$�6�   $�CÍRCULO��6�   �� 6�   $�"��6�   6  5:      5;      � 5=   
   -   5        $	 gridPlaying��5=      $
��Left=�6$   $	��580��6?   $��0,20,0,0q�6L   $	��Top=�6^   $	��800��6v   $��2��6�   $y�Hidden=�6�   .+�5>      �� $��Resources/1.png��6   $
��Fill=�6-   $	��240��6<    �� Left$	 279��6I   
 �� Top$	 156��6[   $	��240��6l   $��280,170q�6x   �� 5?      -   5        $ button5��5?      $��368,257q�6%   $��Resources/Capa 5.png��66   $
��Fill=�6T   $ 0Q�6c   $ 4��6�   $
 Hand��6�   �� 5@      -    5        $ button6��5@      $��447,257,289,257q�6%   $��Resources/Capa 5.png��6>   $
��Fill=�6\   $ 0Q�6k   $ 5��6�   $
 Hand��6�   �� 5A      -!   5        $ button8��5A      $��368,338,368,176q�6%   $��Resources/Capa 5.png��6>   $
��Fill=�6\   $ 0Q�6k   $ 7��6�   $
 Hand��6�   �� 5B      -"   5        $ button4��5B      $��289,257,447,257q�6%   $��Resources/Capa 5.png��6>   $
��Fill=�6\   $ 0Q�6k   $ 3��6�   $
 Hand��6�   �� 5C      -#   5        $ button9��5C      $��447,338,289,176q�6%   $��Resources/Capa 5.png��6>   $
��Fill=�6\   $ 0Q�6k   $ 8��6�   $
 Hand��6�   �� 5D      -$   5        $ button7��5D      $��289,338,447,176q�6%   $��Resources/Capa 5.png��6>   $
��Fill=�6\   $ 0Q�6k   $ 6��6�   $
 Hand��6�   �� 5E      -%   5        $ button2��5E      $��368,176,368,338q�6%   $��Resources/Capa 5.png��6>   $
��Fill=�6\   $ 0Q�6k   $ 1��6�   $
 Hand��6�   �� 5F      -&   5        $ button3��5F      $��447,176,289,338q�6%   $��Resources/Capa 5.png��6>   $
��Fill=�6\   $ 0Q�6k   $ 2��6�   $
 Hand��6�   �� 5G      -'   5        $ button1��5G      $��289,176,447,338q�6%   $��Resources/Capa 5.png��6>   $
��Fill=�6\   $ 0Q�6k   $ 0��6�   $
 Hand��6�   �� 5H      -(   5        $ 
imageXTurn��5H      $��348,125,334,438q�6(   $��Resources/Turno de X.png��6A   $
��Fill=�6c   $ 0Q�6r   �� 5I      -)   5        $ imageXScore��5I      $��519,419,261,145q�6)   $��Resources/X__.png��6B   $
��Fill=�6]   �� 5J      -*   5        $ imageOScore��5J      $��244,418,533,145q�6)   $��Resources/O__.png��6B   $
��Fill=�6]   �� 5K      -+   5        $ 
imageOTurn��5K      $��347,125,334,438q�6(   $��Resources/Turno de O.png��6A   $
��Fill=�6c   $ 0Q�6r   �� 5L      -,   5        $ O2��5L      $��289,257,447,257q�6    $��Resources/O_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5M      --   5        $ X1��5M      $��447,257,289,257q�6    $��Resources/X_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5N      -.   5        $ O3��5N      $��289,257,447,257q�6    $��Resources/O_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5O      -/   5        $ X5��5O      $��447,257,289,257q�6    $��Resources/X_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5P      -0   5        $ O5��5P      $��289,257,447,257q�6    $��Resources/O_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5Q      -1   5        $ X4��5Q      $��447,257,289,257q�6    $��Resources/X_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5R      -2   5        $ O1��5R      $��289,257,447,257q�6    $��Resources/O_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5S      -3   5        $ X2��5S      $��447,257,289,257q�6    $��Resources/X_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5T      -4   5        $ O4��5T      $��289,257,447,257q�6    $��Resources/O_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5U      -5   5        $ X3��5U      $��447,257,289,257q�6    $��Resources/X_Figure.png��69   $
��Fill=�6Y   $y�Hidden=�6h   $ 0Q�6|   �� 5V      -6   5        $
 
textOScore��5V      $
��Left=�6,   $��272,415,0,0q�6G   $
��Wrap=�6\   $��0��6p   $	��Top=�6y   $��
Montserrat)�6�   $��20(�6�   $
��Bold"�6�   ���	#FF3030306�   �� 5W      -7   5        $
 
textXScore��5W      $
��Left=�6,   $��544,415,0,0q�6G   $
��Wrap=�6\   $��0��6p   $	��Top=�6y   $��
Montserrat)�6�   $��20(�6�   $
��Bold"�6�   ���	#FF3030306�   �� 5X      -8   5        $ 	textOWins��5X      $��293,125,292,428q�6'   $ ��Resources/¡GANADOR O!.png��6@   $
��Fill=�6c   $ 0Q�6r   �� 5Y      -9   5        $ 	textXWins��5Y      $��295,125,294,428q�6'   $ ��Resources/¡GANADOR X!.png��6@   $
��Fill=�6c   $ 0Q�6r   �� 5Z      -:   5        $ textDraw��5Z      $��328,126,327,427q�6&   $��Resources/¡EMPATE!.png��6?   $
��Fill=�6_   $ 0Q�6n   5[      � 5]   
   -;   5        $	 
gridWinner��5]      $y�Hidden=�6#   $
 Hand��6T   .+�5^      �� -<   5        $ imageWinner��5^      $��178,78,177,78q�6)   $��Resources/Window.png��6@   $
��Fill=�6^   $ 0Q�6m   6y   � 5`      -=   5        $	 gridHelpWinner��5`      .+�5a      �� ->   5        $ imageWindowHelpWinner��5a      $��179,76,177,75q�67   $��Resources/Window.png��6N   $	 0,0&�6l   $	 0.5Q�6�   6�   �� 5b      -?   5        $
 textHelpWinner��5b      $��336,288,333,288q�64   $
��Wrap=�6M   $��
Montserrat)�6a   $��20(�6y   $
��Bold"�6�   ���	#FF3E3E3E$��"SIGUIENTE"��6�   5c      5d      �� 5f   
   -@   5        $ imageSpeechOn��5f      $
��Left=�6'   $��581,480,0,0q�6B   $	��Top=�6W   $)��#Resources/Red_microphone_button.png��6o   $
��None=�6�   {�.  $ 0Q�6�   $
 Hand��6    J� Effect 5g      3  -System.Windows.Media.Effects.DropShadowEffect  5h         	Direction$ 0Q�6#      
BlurRadius$ 30Q�61      ShadowDepth$ 0Q�6A      Opacity$	 0.3Q�6Q   5j      �� 5k   
   -A   5        $ imageSpeechOff��5k      $
��Left=�6(   $��581,480,0,0q�6C   $	��Top=�6X   $*��$Resources/Gray_microphone_button.png��6p   $
��None=�6�   $
 Hand��6�   � 5m   
   -B   5        $	 	gridDebug��5m      $��	0,527,0,0q�6"   {�.  $��2��6G   $y�Visible=�6[   .+�5n      �� -C   5        $
 
textSpeech��5n      $
��Left=�6,   $��	10,45,0,0q�6G   $
��Wrap=�6Z   $��Voice:��6n   $	��Top=�6|   $��Consolas)�6�   $��15(�6�   5o      5q      5s      