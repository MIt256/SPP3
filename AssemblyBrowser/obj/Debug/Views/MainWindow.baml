   M S B A M L   `   `   `  ����J  FAssemblyBrowser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AssemblyBrowser.ViewModelsAssemblyBrowser.ViewModels  5   	   &     AssemblyBrowser.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:AssemblyBrowser.ViewModels     5   	   -   5          �Name$
  Lab3��5   	    � Title$ LABA№3��5   	   $	��831��6   $��729.5��6%    � DataContext 5      2   ,AssemblyBrowser.ViewModels.AssemblyViewModel  5   
   .��5      � $��0,0,-0.4,401q�6    � RowDefinitions 5   
   �� 5      $
��380* �6   �� 5      $
��267* �6    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $
��151* �6   �� 5      $
��404* �6   �� 5      $
��168* �6   .+�5   
   o� $��0,0,0,-9q�6   $��5��6!   $��2��65   .@�5       m� $��Load assembly��6   $��27��6N   $	��106��6Z    m� Command 6.   �� *LoadCommand+6Z   5!      R� 5#   
   -   5        $��AssemblyTreeView��5#      $
��Left=�6+   $
��1712��6F   $��0,28,0,-1341q�6T   $	��722��6j   $��0��6v   $��5��6�   $��Tahoma)�5$   9   $��16(�6M   $��Stretch=�6[   $��Stretch=�6~   $	��Top=�6�   $��2��6�   ��6   �� *AssemblyInfos+��5%      �� 5'       �� ItemsSource 6+   �� *AssemblyNamespaces+.R�5(      �� ��6    �� *AssemblyName+ �� ItemTemplate 5*      �� 5+       63   �� *NamespaceTypes+.R�5,      �� ��6(   �� *NamespaceName+ 5.      �� 5/   "    6;   �� *MembersInfos+.R�50   &   �� ��60   �� *
TypeName+ 52   &   �� 53   *   .R�54   .   �� ��68   �� *Description+55   +   58   #   5:      5=      5?      5B      5C      