   M S B A M L   `   `   `  ����K  GTrabalhoFinalFPA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TrabalhoFinalFPA.ViewsTrabalhoFinalFPA.Views  5      *    $TrabalhoFinalFPA.Views.DataInputView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TrabalhoFinalFPA.Views     5      ���#1E2A38.��5      � $��30q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Entrada de Dados��6   
�������$��28(�5      $
��Bold"�5      $��Center=�5      $��0,0,0,20q�5      � 5   
   $��1��6     5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5"      ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,20q�62   $��Center=�6D   .+�5#      �� $$��Número de conjuntos (1 a 10):��6   
�������$��16(�5$   /   $��Center=�6=   �� 5%      -   5         ��Name$ ConjuntosTextBox��5%      $��50��5&      $��10,0,0,0q�6%   $��16(�5'      
���   � �� 	MaxLength$ 2��5)      $��Center=�5*      5+      �� 5.      $��1��6   $
��Auto=�5/      $��Disabled=�50      $��0,0,0,10q�51      .��52      �� -   5         ��Name$ ParesStackPanel��52      $��Center=�66   $	��600��6S   53      54      �� 57   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,20,0,0q�6X   .+�59      �� -   5        $��Calcular LCS��59      $	��150��6,   $��40��68   $��0,0,15,0q�6D   $��16(�5:      ���#3498DB
�������$��0q�6C    � Cursor$
 Hand��5;      ��5<      �� 5=       �� 
TargetType" ��6    �� Triggers 5>      P� 5?       P� Property �@J�IsMouseOver	 P� Value$
	 True��6=   . �5@   "   �� 
 �� Property
 � �� �� Value �#2C80B46?   5A      5C      5E      �� 5H      -   5        $��Voltar��5H      $	��120��6&   $��40��62   $��16(�5I      ���#3498DB
�������$��0q�6C   $
 Hand��5J      ��5K      �� 5L      " ��6    5M      P� 5N       �@J�IsMouseOver$
	 True��6=   . �5O   "   �� 
 � �� �#2C80B46?   5P      5R      5T      5U      5V      5W      