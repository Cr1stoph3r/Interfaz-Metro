   M S B A M L   `   `   `  ����H  DInterfazMetro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:InterfazMetroInterfazMetro  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   	       InterfazMetro.Menu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:InterfazMetro     5   	   ;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   	     � Title$
  Menu��5   	   $	��450��6   $	��800��6#   
����� � � WindowStartupLocation$ CenterScreen=�6F   .��5      � .+�5   
   ,  &MahApps.Metro.Controls.MetroTabControl  -   5        $��Menuu��5   #   
����� �.@�5      �  � ColumnDefinitions 5      �� 5      $	��75* �6'   �� 5      $	��50* �6'   �� 5      $	��36* �6'   �� 5      $
��631* �6'   .+�5      !  MahApps.Metro.Controls.Tile  -   5        $��	3,-9,-3,0q�5       $
��Auto��63   $
��Auto��6A   $��4��6N   .��5      �� $��Image/OneBreaKK.png��6   $��121,26,112,281q�69   $��Center=�6Q   5        5      -   5        $��33,191,616,45q�5          Title$  Administracion de Clientes��67      TitleFontSize$ 15Q�6Z      HorizontalTitleAlignment$ Center=�6m   $
��Auto��6�   ���	#FFFF6A6A$
��Auto��6�   
���   �   VerticalTitleAlignment$	 Top=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6  $��4��6&   J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 8Q�6+   
   ShadowDepth$
 8Q�6:   z�5      V� 5      .~�5       �� �� 5!       �� AngleX$ 14.204Q�6,   �� 5"       �� Angle$
 1.13Q�6.   T� 5#       T� X$ 18.22Q�61    T� Y$ 0.359Q�6;   5$      .��5&      �� $��70��6   $	��106��6)   $��Image/Cliente.png��65   $ 0.5,0.5&�6P   $��Bottom=�6p   5'      �� 5(      $��Image/OneBreaKK.png��6   $��121,26,112,281q�65   $��Center=�6M     5+      -   5        $��45,195,447,43q�5+   !   $ Listado de clientes��68   $ 15Q�6T   $ Center=�6g   $
��Auto��6�   ���	#CC4BA674$	 Top=�6�   ���	#FF0C0000$��3��6�   $
��Auto��6  $ 0.5,0.5&�6  z�5,      V� 5-      .~�5.      �� �� 5/      $ 15.154Q�6,   �� 50      T� 51      $ 19.229Q�61   52       54        55      $
 8Q�6+   $	 8Q�6;      Color$ 	#FF914C4C��6J   .��57      �� $��Image/Clientes.png��6   $��71��68   $��69��6D   59        5;      -   5        $��218,201,274,50q�5;       $ Listado de contrato��68   $ 14Q�6T   $ Center=�6g   $
��Auto��6�   ���	#CC555E6C$	 Top=�6�   
���   �$��3��6�   $ 0.5,0.5&�6  $
��Auto��6!  z�5<      V� 5=      .~�5>      �� �� 5?      $ 18.998Q�6,   �� 5@      T� 5A      $ 24.156Q�61   5B       5D        5E      $ 	#FF914C4C��6+   $	 8Q�6=   $
 8Q�6L   .��5G      �� $��image/Contratos.png��6   $��71��69   $	��106��6E   5I        5K      -   5        $��399,206,93,45q�5K       $! Administracion de contratos��67   $ 15Q�6[   $ Center=�6n   $
��Auto��6�   $ 0.5,0.5&�6�   $
��Auto��6�   ���	#CCCDCDCD���	#FF060000$	 Top=�6�   $��3��6  z�5L      V� 5M      .~�5N      �� �� 5O      $ 21.123Q�6,   �� 5P      T� 5Q      $ 24.614Q�61   5R       5T        5U      $	 8Q�6+   $
 8Q�6:   $ 	#FF914C4C��6J   .��5W      �� $��image/Contrato.png��6   $��79��68   $��90��6D    J� OpacityMask �	#FF1B1111$ 0.573,1.068&�6g   5Y      5\      5]      5_      5`      