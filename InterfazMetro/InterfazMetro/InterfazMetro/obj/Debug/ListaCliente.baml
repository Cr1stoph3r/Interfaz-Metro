   M S B A M L   `   `   `  ����H  DInterfazMetro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:InterfazMetroInterfazMetro  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	        InterfazMetro.ListaCliente   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:InterfazMetro     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	   	     � Title$  ListaCliente��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67   ���#00AAE4.��5      � $��0,0,2,0q�6   .+�5   
   �� -   5         ��Name$ cbox_actEmp��5      $
��Left=�6)   $��25��6D   $��
164,69,0,0q�6P   $	��Top=�6d   $	��164��6|   5      �� 5   
   -   5        $ 	cbox_tEmp��5      $
��Left=�6&   $��25��6A   $��164,100,0,0q�6M   $	��Top=�6b   $	��164��6z   5      �� 5   
   $
��Left=�6   $��25��6+   $��	10,65,0,0q�67   $��Actividad Empreasa:��6J   $	��Top=�6h   $	��149��6�   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��	10,95,0,0q�67   $��Tipo Empresa:��6J   $	��Top=�6b   $	��149��6z   
������ $��0q�6�   
�������$��Arial Black)�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgPersonas��5      $
��Left=�6'   $	��283��6B   $	��Top=�6O   $	��790��6g   $��	0,131,0,0q�6s      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *NombreContacto+  5      $	 Rut��6!      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6M    6.   �� *
RutCliente+6M     5      $ 	R. Social��6!   $	 100 6T    64   �� *RazonSocial+6T     5      $
 Mail��6!   $	 100 6P    6/   �� *MailContacto+6P     5      $ 	Direccion��6!    64   �� *	Direccion+  5      $ Telefono��6!    63   �� *
Telefono+  5      $ Actividad Emp.��6!    69   �� *DescripcionActividad+  5      $ 	Tipo Emp.��6!   $	 100 6[    64   �� *DescripcionEmpresa+6[   5      �� 5   
   -   5        $��Limpiar campos��5      $
��Left=�6*   $��34��6E   $��
333,89,0,0q�6Q   $	��Top=�6e   $	��102��6}   ���	#FF0F1D4D	 J� Effect	 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!      5#      �� 5$   
   -   5        
 ��Name$
 Filtro��5$      $��485,77,206,309q�6!   $��Friltrar��69   $��20(�6L    J� RenderTransformOrigin$ 0.158,0.553&�6o   �� 5%   
   -   5         ��Name$ txtrut��5%      $
��Left=�6"   $��20��6=   $��
164,34,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��164��6�   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 
12345678-9��6�   $ 0.291,-0.885&�6�   �� 5&   
   $
��Left=�6   $��25��6+   $��	10,35,0,0q�67   $
��Rut:��6J   $	��Top=�6Y   $��98��6q   
������ $��0q�6�   
�������$��Arial Black)�6�   !  MahApps.Metro.Controls.Tile  5'   
   -   5        $��724,82,10,288q�5'      $
��Auto��6/   $
��Auto��6=   .��5(      �� $��Icon/Back.png��6   $��50��6+   $��62��67   $ 0.5,0.5&�6B   z�5)      V� 5*      .~�5+      �� �� 5,       �� AngleY$ 0.905Q�6(   �� 5-      T� 5.       T� Y$ 1.484Q�6-   5/      52      53      �� 54   
   $��Image/OneBreaKK.png��6   $��454,0,10,342q�6-   55      56      