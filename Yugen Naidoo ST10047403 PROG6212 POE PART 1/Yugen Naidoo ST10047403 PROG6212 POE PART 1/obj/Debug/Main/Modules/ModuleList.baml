   M S B A M L   `   `   `  ����f  bYugen Naidoo ST10047403 PROG6212 POE PART 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Fclr-namespace:Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Modules8Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Modules  5      s>clr-namespace:Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core0Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core  6c   I    CYugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Modules.ModuleList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      XlocalFclr-namespace:Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Modules     5      Ocore>clr-namespace:Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core     6c   -   5        .��5	      �   � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ AddModuleButton��5      $��
ADD MODULE��6*   $��Right=�6]   $	��150��6y   $��30��6�   $��20(�6�   $��	0,10,10,0q�6�   ��6�   �� *SwitchToAddModulesCommand+�� 5   
   -   5         ��Name$ SemesterWeeksComboBox��5      $	��150��62   $��30��6>   $��
0 10 180 0q�6J   $��Right=�6^   6z   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ ModuleListDatagrid��5         SelectionMode$ Extended=�6/      SelectionUnit$ FullRow=�6H      AutoGenerateColumns .  $��	10 0 10 0q�6|      DataGridStyle1#��[  6�      	CellStyle 5      �� 5       �� ResourceKey$ DataGridCellStyle1��6!   	   RowStyle	 5      �� 5      $ DataGridRowStyle1��6!   
   ColumnHeaderStyle
 5      �� 5      $  DataGridColumnHeaderStyle1��6!      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6%      
IsReadOnly .    CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6X     5      -   5        
moduleCode��$
 Code��5   9    . $ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6c   �� *
ModuleCode+  5       -   5        
moduleName��$
 Name��5    9    . $ * 6Y    6c   �� *
ModuleName+  5!      -   5        moduleCredits��$ Credits��5!   <    . $ * 6_    6i   �� *ModuleCredits+  5"      -   5        moduleSelfStudyHours��$ Study Hours Total��5"   C    . $ * 6p    6z   �� *ModuleSelfStudyHours+  5#      -	   5        !moduleSelfStudyHoursRemaining��$ Study Hours Left��5#   L    . $ * 6x    6�   �� *ModuleSelfStudyHoursRemaining+5%      5(      5)      