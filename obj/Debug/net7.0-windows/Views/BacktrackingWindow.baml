   M S B A M L   `   `   `  ����K  GTrabalhoFinalFPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TrabalhoFinalFPA.ViewsTrabalhoFinalFPA.Views  5      /    )TrabalhoFinalFPA.Views.BacktrackingWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TrabalhoFinalFPA.Views     5      $	��400��5      $	��600��6,   ���#1E2A38.��5	      � $��20q�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $/��)Cálculo de Subsequências (Backtracking)��6   
�������$��22(�5   '   $
��Bold"�65   $��Center=�5      $��0,0,0,15q�61   $��0��6C   �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   $��0,0,0,10q�69   .+�5      �� $ 
Horizontal=�6   $��0,0,0,5q�62   .+�5      �� $��Sequência Helena:��6   $	��150��65   $��Center=�6A   
�������6\   �� 5      -   5         ��Name$ txtSequenciaHelena��5      $��25��66   $	��300��6B   ���#263545
����������#4445   B   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Sequência Marcus:��6   $	��150��65   $��Center=�6A   
�������6\   �� 5      -   5        $ txtSequenciaMarcus��5      $��25��66   $	��300��6B   ���#263545
����������#4445    B   5!      5"      �� 5%   
   -   5         ��Name$ lstResultados��5%      $��2��6)   $��	0,10,0,10q�66   ���#263545
����������#4445&   :   �� 5(   
   $��3��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,20,0,0q�6X   .+�5*      �� -   5        $��Calcular��5*      $	��120��6(   $��35��64   $��0,0,10,0q�6@   $��16(�5+      ���#3498DB
�������$��0q�6C   ��5-      �� 5.       �� 
TargetType" ��6    �� Triggers 5/      P� 50       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �51   "   ��  �� Property � ��	 �� Value	 �#2C80B46?   52      54      56      �� 59      -   5        $��Voltar��59      $	��120��6&   $��35��62   $��16(�5:      ���#3498DB
�������$��0q�6C   ��5<      �� 5=      " ��6    5>      P� 5?       �@J�IsMouseOver$
 True��6=   . �5@   "   ��  � ��	 �#2C80B46?   5A      5C      5E      5F      5G      5H      