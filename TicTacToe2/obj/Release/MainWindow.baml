   M S B A M L   `   `   `  ���� F  BTic Tac Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TicTacToe2
TicTacToe2      TicTacToe2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:TicTacToe2     -     �Name$  
mainWindow�� � Title$ TicTacToe por Julio��$	��600��$	��800�� � WindowStyle$
 None=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�$	��600��$	��800��.���  � ColumnDefinitions �� $
��800* ��� .+��� -    ��Name$ imageBackground��$
��Left=�$	��600��$	��Top=�$	��800��$��Resources/Background.png��$
��Fill=�$��2���� -   $ titleBar��$
��Left=�$��20��$	��Top=�$	��800��$��Resources/TitleBar.png��$��2���� -   $ 
exitButton��$
��Left=�$��20��$��	780,0,0,0q�$	��Top=�$��20��$��Resources/Exit.png��$��2���� -   $ minusButton��$
��Left=�$��20��$��	760,0,0,0q�$	��Top=�$��20��$��Resources/Minus.png���� -   $ imageWindow0��$��174.5,78,174.5,78q�$��Resources/Window.png���� -   $ 	imageHelp��$��747,20,0,526q�$��	Signo.png��$
��Fill=� J� Opacity$
 0.65Q� � Cursor$
 Hand��� -   	 �Name$	 gridInfo��$
��Left=�$	��580��$��0,20,0,0q�$	��Top=�$	��800��$��2��{�.  $ 0Q�.+��� -	   $��661,39,0,427q�$��
Window.png��$
��Fill=�$
 Hand���� -
   
 ��Name$
 textDesignedBy��$
��Left=�$��
680,58,0,0q�$
��Wrap=�$"��DISEÑADO Y DESARROLLADO POR��$	��Top=�$��
Montserrat)�$��10(�$
��Bold"� J� OpacityMask
 �   ����	#FF464646$	��101��$��55�� �� TextAlignment$ Center=�$  ���� -   $
 
textMyName��$
��Left=�$��
684,98,0,0q�$
��Wrap=�$��JULIO SANDOVAL��$	��Top=�$��
Montserrat)�$��10(�$
��Bold"�
 �   ����	#FF999999$ Center=�$
 Hand���� -   $ 	imgGitHub��$��721,115,60,446q�$��Sin título.png��$
��Fill=�$
 Hand��� -   $	 gridHome��$
��Left=�$	��580��$��0,20,0,0q�$	��Top=�$	��800��$��2��$y�Visible=�.+��� $��50��$	��Top=�$��Resources/2 JUGADORES.png�� J� RenderTransformOrigin$ 0.387,-0.19&� �� Left$	 269��
 �� Top$	 150��$��269,145,269,0q��� $
��Left=�$��18��$	��Top=�$��68��$��Resources/ELIGE.png��$	 366��$	 265��$��366,263,0,0q��� -   $ oFrame��$��O frame2.png��$
��Fill=�$	��112��$	 419��$	 296��$	��112��$��419,302,269,166q�$
 Hand���� -   $ xFrame��$��X frame2.png��$
��Fill=�$	��112��$	 269��$	 296��$	��112��$��269,302,419,166q�$
 Hand��� -   $	 gridPlaying��$
��Left=�$	��580��$��0,20,0,0q�$	��Top=�$	��800��$��2��$y�Hidden=�.+��� $��1.png��$
��Fill=�$	��240��$	 279��$	 156��$	��240��$��280,170q��� -   $ button5��$��368,257q�$��
Capa 5.png��$
��Fill=�$ 0Q�
 J� Uid$ 4��$
 Hand���� -   $ button6��$��447,257,289,257q�$��
Capa 5.png��$
��Fill=�$ 0Q�$ 5��$
 Hand���� -   $ button8��$��368,338,368,176q�$��
Capa 5.png��$
��Fill=�$ 0Q�$ 7��$
 Hand���� -   $ button4��$��289,257,447,257q�$��
Capa 5.png��$
��Fill=�$ 0Q�$ 3��$
 Hand���� -   $ button9��$��447,338,289,176q�$��
Capa 5.png��$
��Fill=�$ 0Q�$ 8��$
 Hand���� -   $ button7��$��289,338,447,176q�$��
Capa 5.png��$
��Fill=�$ 0Q�$ 6��$
 Hand���� -   $ button2��$��368,176,368,338q�$��
Capa 5.png��$
��Fill=�$ 0Q�$ 1��$
 Hand���� -   $ button3��$��447,176,289,338q�$��
Capa 5.png��$
��Fill=�$ 0Q�$ 2��$
 Hand���� -   $ button1��$��289,176,447,338q�$��
Capa 5.png��$
��Fill=�$ 0Q�$ 0��$
 Hand���� -   $ 
imageXTurn��$��348,125,334,438q�$��Turno de X.png��$
��Fill=�$ 0Q��� -   $ imageXScore��$��519,419,261,145q�$��X__.png��$
��Fill=��� -   $ imageOScore��$��244,418,533,145q�$��O__.png��$
��Fill=��� -   $ 
imageOTurn��$��347,125,334,438q�$��Turno de O.png��$
��Fill=�$ 0Q��� -   $ O2��$��289,257,447,257q�$��O_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -   $ X1��$��447,257,289,257q�$��X_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -    $ O3��$��289,257,447,257q�$��O_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -!   $ X5��$��447,257,289,257q�$��X_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -"   $ O5��$��289,257,447,257q�$��O_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -#   $ X4��$��447,257,289,257q�$��X_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -$   $ O1��$��289,257,447,257q�$��O_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -%   $ X2��$��447,257,289,257q�$��X_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -&   $ O4��$��289,257,447,257q�$��O_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -'   $ X3��$��447,257,289,257q�$��X_Figure.png��$
��Fill=�$y�Hidden=�$ 0Q��� -(   $
 
textOScore��$
��Left=�$��272,415,0,0q�$
��Wrap=�$��0��$	��Top=�$��
Montserrat)�$��20(�$
��Bold"����	#FF303030�� -)   $
 
textXScore��$
��Left=�$��544,415,0,0q�$
��Wrap=�$��0��$	��Top=�$��
Montserrat)�$��20(�$
��Bold"����	#FF303030�� -*   $ 	textOWins��$��293,125,292,428q�$��¡GANADOR O!.png��$
��Fill=�$ 0Q��� -+   $ 	textXWins��$��295,125,294,428q�$��¡GANADOR X!.png��$
��Fill=�$ 0Q��� -,   $ textDraw��$��328,126,327,427q�$��¡EMPATE!.png��$
��Fill=�$ 0Q�� --   $	 
gridWinner��$y�Hidden=�$
 Hand��.+��� $��178,78,177,78q�$��
Window.png��$
��Fill=�