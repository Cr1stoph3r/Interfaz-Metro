   M S B A M L   `   `   `  ����H  DInterfazMetro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:InterfazMetroInterfazMetro  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5	   	       InterfazMetro.Registro   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:InterfazMetro     5   	   ;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5	   	     � Title$  Registro��5   	   $	��350��6   $	��628��6'   ���#00AAE4 � WindowStartupLocation$ CenterScreen=�6H   .��5      � $��0,0,2,1q�6   .+�5   
   �� $
��Left=�6   $��25��6+   $��	10,76,0,0q�67   $��Nombre:��6J   $	��Top=�6\   $��98��6t   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��
10,106,0,0q�67   $
��Rut:��6K   $	��Top=�6Z   $��98��6r   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��
10,137,0,0q�67   $��Dirección:��6K   $	��Top=�6`   $��98��6x   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��
10,167,0,0q�67   $��	Telefono:��6K   $	��Top=�6_   $��98��6w   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��
248,15,0,0q�67   $��Razon Social:��6K   $	��Top=�6c   $��98��6{   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��
248,54,0,0q�67   $��Email:��6K   $	��Top=�6\   $��79��6t   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��
248,89,0,0q�67   $��Actividad Empreasa:��6K   $	��Top=�6i   $	��149��6�   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��248,125,0,0q�67   $��Tipo Empresa:��6L   $	��Top=�6d   $	��149��6|   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   -   5         ��Name$ 	txtnombre��5      $
��Left=�6%   $��20��6@   $��	86,74,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��148��6�   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Juanito Perez��6�   �� 5   
   -   5        $ txtrut��5      $
��Left=�6"   $��20��6=   $��
86,105,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��148��6�   $ 
12345678-9��6�    J� RenderTransformOrigin$ 0.291,-0.885&�6�   �� 5   
   -   5        $ txtdireccion��5      $
��Left=�6(   $��20��6C   $��
86,136,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��148��6�   $ av. ejemplo 1234��6�   �� 5   
   -   5        $ txttelefono��5      $
��Left=�6'   $��20��6B   $��
86,166,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��148��6�   $ +56912345678��6�   �� 5   
   -   5        $ txtr_social��5      $
��Left=�6'   $��20��6B   $��
420,15,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��148��6�   $ OnBreak��6�   �� 5   
   -   5        $ txtemail��5      $
��Left=�6$   $��20��6?   $��
420,53,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��148��6�   $ Ejemplo@Ejemplo.com��6�   �� 5   
   -   5         ��Name$ cbox_actEmp��5      $
��Left=�6)   $��25��6D   $��
420,88,0,0q�6P   $	��Top=�6d   $	��164��6|   5      �� 5   
   -   5        $ 	cbox_tEmp��5      $
��Left=�6&   $��25��6A   $��420,131,0,0q�6M   $	��Top=�6b   $	��164��6z   5      !  MahApps.Metro.Controls.Tile  5    
   -	   5          Name$
 back��5       $��484,234,34,29q�6&      TitleFontSize$ 15Q�6>   	   HorizontalTitleAlignment$	 Center=�6Q   $
��Auto��6s   $
��Auto��6�   .��5!      �� $��Icon/back.png��6   $��56��6+   $��79��66   
 J� Effect
 5"      3  -System.Windows.Media.Effects.DropShadowEffect  5#      5%      5'        5(   
   -
   5        $ RegistrarCliente��5(         Title$ 	Registrar��63   $��10,202,521,0q�6E   $ 15Q�6\   $	 Center=�6o   $
��Auto��6�   $
��Auto��6�      VerticalTitleAlignment$	 Top=�6�   
 5)        5*      .��5,      �� $��Image/Cliente_add.png��6   $��61��63   $��72��6>   $��Bottom=�6J   5-        5.   
   -   5        $ 
Actualizar��5.      $ 
Actualizar��6-   $��114,202,417,0q�6@   $ 15Q�6X   $	 Center=�6k   $
��Auto��6�   $
��Auto��6�   $	 Top=�6�   
 5/        50      .��52      �� $��Image/Cliente_update.png��6   $��61��66   $��72��6A   $��Bottom=�6M   53        54   
   -   5        $ Eliminar��54      $ Eliminar��6+   $��216,202,315,0q�6<   $ 15Q�6T   $	 Center=�6g   $
��Auto��6�   $
��Auto��6�   $	 Top=�6�   
 55        56      .��58      �� $��Image/Cliente_delete.png��6   $��61��66   $��72��6A   $��Bottom=�6M   59        5:   
   -   5        $ Buscar��5:      $ Buscar��6)   $��319,177,162,41q�68   $ 15Q�6Q   $	 Center=�6d   $
��Auto��6�   $
��Auto��6�   $	 Top=�6�   
 5;        5<      .��5>      �� $��Image/Cliente_search.png��6   $��61��66   $��72��6A   $��Bottom=�6M   5@      �� 5A   
   -   5        $ 
txtfiltrar��5A      $
��Left=�6&   $��23��6A   $
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��137��6�   $��319,282,0,0q�6�   $ Ingrese rut��6�   .��6�   
 5B        5C      .��5D      5E      �� 5F   
   -   5        $��Limpiar campos��5F      $
��Left=�6*   $��34��6E   $��482,162,0,0q�6Q   $	��Top=�6f   $	��102��6~   ���	#FF0F1D4D
 5G        5H      5J        5K   
   -   5        $ Admin��5K      $  Administracion de Clientes��6(   $��0,0,375,270q�6K   $ 15Q�6a   $	 Center=�6t   $
��Auto��6�   $
��Auto��6�   $	 Top=�6�   $��Felix Titling)�6�   ���	#FF00AAE45L      5N      5O      