   M S B A M L   `   `   `  ����H  DInterfazMetro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:InterfazMetroInterfazMetro  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullZ=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.MetroMahApps.Metro.Behaviours 5   	   V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	   	   !    InterfazMetro.ListaContrato   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:InterfazMetro     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   N
behaviours=clr-namespace:MahApps.Metro.Behaviours;assembly=MahApps.Metro  5   	   JControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5	   	     � Title$  Lista Contrato��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69   ���#00AAE4.��5      � $��0,0,2,0q�6   .+�5   
   �� -   5         ��Name$ 	txtnumero��5      $
��Left=�6%   $��20��6@   $��
164,34,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��164��6�   *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ 
12345678-9��6�    J� RenderTransformOrigin$ 0.291,-0.885&�6�   �� 5   
   -   5         ��Name$ cbox_tipoevento��5      $
��Left=�6,   $��25��6G   $��164,100,0,0q�6S   $	��Top=�6h   $	��164��6�   5      �� 5   
   $
��Left=�6   $��25��6+   $��	10,65,0,0q�67   $��Numero Contrato��6J   $	��Top=�6d   $	��149��6|   
������ $��0q�6�   
�������$��Arial Black)�6�   �� 5   
   $
��Left=�6   $��25��6+   $��	10,95,0,0q�67   $��Tipo Evento:��6J   $	��Top=�6a   $	��149��6y   
������ $��0q�6�   
�������$��Arial Black)�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgContrato��5      $
��Left=�6(   $	��283��6C   $	��Top=�6P   $	��790��6h   $��	0,131,0,0q�6t      AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Numero��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Numero+  5      $	
 Rut��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Q    62   �� *
RutCliente+6Q     5      $
 Creacion��6%   $	 100 6T    67   �� *
Creacion+6T     5      $
 Termino��6%   $	 100 6R    66   �� *	Termino+6R     5      $
 	Modalidad��6%    68   �� *DescripcionModalidad+  5      $

 Tipo��6%    63   �� *DescripcionEvento+  5      $
 Fecha Inicio��6%    6;   �� *FechaHoraInicio+  5      $
 Fecha Termino��6%   $	 100 6a    6<   �� *FechaHoraTermino+6a     5      $
 
Asistentes��6%    69   �� *
Asistentes+  5      $
 Personal Add.��6%    6<   �� *PersonalAdicional+  5      $
 	Realizado��6%    68   �� *	Realizado+  5      $
 Valor Contrato��6%    6=   �� *ValorTotalContrato+  5       $
 Observaciones��6%    6<   �� *Observaciones+5"      �� 5#   
   -   5        $��Limpiar campos��5#      $
��Left=�6*   $��34��6E   $��
333,89,0,0q�6Q   $	��Top=�6e   $	��102��6}   ���	#FF0F1D4D J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%      5'      �� 5(   
   -   5         ��Name$ Filtro��5(      $��485,77,206,309q�6!   $��Friltrar��69   $��20(�6L   $ 0.158,0.553&�6o   �� 5)   
   -   5        $ txtrut��5)      $
��Left=�6"   $��20��6=   $��
164,65,0,0q�6I   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��164��6�   $
 4324��6�   $ 0.291,-0.885&�6�   �� 5*   
   $
��Left=�6   $��25��6+   $��	10,35,0,0q�67   $
��Rut:��6J   $	��Top=�6Y   $��98��6q   
������ $��0q�6�   
�������$��Arial Black)�6�   !  MahApps.Metro.Controls.Tile  5+   
   -   5        $��724,82,10,288q�5+      $
��Auto��6/   $
��Auto��6=   .��5,      �� $��Icon/Back.png��6   $��40��6+   $��70��67   $ 0.5,0.5&�6B   z�5-      V� 5.      .~�5/      �� �� 50       �� AngleY$ 0.905Q�6(   �� 51      T� 52       T� Y$ 1.484Q�6-   53      56      57      �� 58   
   $��Image/OneBreaKK.png��6   $��454,0,10,342q�6-   59      5:      