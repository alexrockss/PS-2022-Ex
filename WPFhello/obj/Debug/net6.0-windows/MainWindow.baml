   M S B A M L   `   `   `  ����C  ?WPFhello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFhelloWPFhello  5   	       WPFhello.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFhello     5   	     � Title$D  >Студентска информационна система��5   	   $	��450��62   $	��800��6?   .��5	      � -   5         �Name$ MainGrid��5	      .+�5
   
   �� -   5         ��Name$ 	lbl_Title��5
      $��Hello, WPF!��6#   $
��Left=�69   $	��Top=�6T   $��36(�6l   $��
176,10,0,0q�6z   $
��Bold"�6�   $��Bahnschrift Condensed)�6�    J� RenderTransformOrigin$ 0.818,0.544&�6�   $	��135��6�   $��60��6�   �� 5   
   -   5        $ lblName��5      $��Име:��6!   $
��Left=�60   $��
138,89,0,0q�6K   $	��Top=�6_   $��29��6w   $��34��6�   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��
176,89,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��114��6~   $��28��6�   �� 5   
   -   5        $ lblSecondName��5      $��Име:��6'   $
��Left=�66   $��138,122,0,0q�6Q   $	��Top=�6f   $��30��6~   $��34��6�   �� 5   
   -   5        $ txtSecondName��5      $
��Left=�6)   $��176,122,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��114��6�   $��29��6�   �� 5   
   -   5        $ lblThirdName��5      $��Име:��6&   $
��Left=�65   $��138,156,0,0q�6P   $	��Top=�6e   $��29��6}   $��34��6�   �� 5   
   -   5        $ txtThirdName��5      $
��Left=�6(   $��176,156,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��114��6�   $��28��6�   �� 5   
   -	   5         ��Name$ 	btn_Hello��5      $��Здрасти!��6$   $
��Left=�67   $��176,190,0,0q�6R   $	��Top=�6g   $	��114��6�   $��22��6�   �� 5   
   -
   5         ��Name$ 
textBlock1��5      $
��Left=�6(   ���	#FF5AC4D8$
��Wrap=�6Z   $��Hello, XAML!��6n   $	��Top=�6�   �� 5   
   $��Center=�6   $��Center=�61   $$��Bahnschrift SemiBold Condensed)�6L   $��15��6x   $��84��6�   I edit XAML myself!5      �� 5   
   -   5        $	��Top=�5      $	��174��6)   ���	#FFC991BE$��	0,260,0,0q�6b   $��Bahnschrift Light)�6u   $��36(�6�   .��6�   	Click me!5      �� 5   
   -   5         ��Name$ peopleListBox��5      $	 �� IsSynchronizedWithCurrentItem$
	 TrueY�6)   $	��139��6N   $	��150��6Z   $	��Top=�6g   $��Right=�6   $��
0,60,170,0q�6�   .@�5      �� $
��Mike��6   �� 5      $
��Lisa��6   �� 5      $
��John��6   �� 5      $
��Mary��6   5      �� 5   
   -   5        $ greetingMsg��5      $��Greeting��6&   $��Right=�69   $��0,220,170,0q�6U   $	��Top=�6j   $	��139��6�   6�   5       5!      