   M S B A M L   `   `   `  ����I  EYcFdyth.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:YcFdyth.ClientYcFdyth.Client  5   	       YcFdyth.Client.frmLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:YcFdyth.Client     5   	   W SMaterialDesignThemes.Wpf, Version=1.2.0.23348, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$  frmLogin��5
   	   $	��450��6   $	��800��6(    � WindowStyle$
 None=�64    � WindowStartupLocation$ CenterScreen=�6H    � AllowsTransparency .  � 
ResizeMode$ NoResize=�6�   
������  J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      
BlurRadius$ 10Q�6      Color$ 	#FF858484��6+      	Direction$ 90Q�6=   	   ShadowDepth$	 1Q�6L   .��5      � $	��400��6   $	��300��6   ��5   
   �� 5      
 �� ImageSource$
 /Image/login.jpg��6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      �� 5      $��40 �6   .+�5   
   '  !MaterialDesignThemes.Wpf.PackIcon  -   5        �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=1.2.0.23348, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�5   "   $��30��6M   $��30��6X   $��0 5 5 0q�6d   $��Right=�6v   
�������$��Center=�6�   5      � 5   
   $��1��6   $��0��6    5      �� 5      �� 5      $��45 �6    �� 5      $��45 �6    �� 5      $��50 �6    �� 5       $
��auto �6    .+�5"      �� $��0��6   $��0��6%   $'��!不动产登记信息采集系统��65   ���#05fffc$��20(�6]   $��Center=�6k   $��Center=�6�   �� 5#      -   5        $��txtAccountName��5#   #   $��1��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	用户名��69   $	��180��6^   
�������
������� %  !MaterialDesignFloatingHintTextBox#��[  6�   $��Center=�6�   G� 5$      -   5        $��txtPwd��5$   '   $��2��6   $ 密 码��65   $	��180��6Z   
�������
�������$��Center=�5%   C    ) %MaterialDesignFloatingHintPasswordBox#��[ 5&      �� 5'      -   5        $��登录��5'      $��3��63   $	��180��6@   ���#1adcff���#0a3d756a   �� 5(      -   5        $��labMsg��5(   %   $��4��6   
�������$��Center=�6F   $��Center=�6c   $��16(�6~   5)      5*      5+      