   M S B A M L   `   `   `  ����  Transformation3D.    (Transformation3D.TranslateTransformation   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5        � Title$   Translation Transformation��5      $	��310��6(   $	��400��65    � 	Resources 5         geometry k� 	Positions k� TriangleIndices  material u� Brush��%�   &	        &	 �     k� 5   
   Q �   . �$     	

5      u� 5   
   
 ��ح�6+   5      .��5      (�  (� Stretch$ Uniform=�6   .��5   
   � $	��430��6   $	��300��6   $
��Left=�6(   $	��Top=�5       � ShowGridLines .   � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      $	��330 �6#   .+�5       �� $��5q�6   $��0��6$   .+�5!      	� -   5         	�Name$ rbOrthographic��5!      $��2q�66   $��Orthographic��5"      	 d� 	IsChecked$
	 TrueY�6-   	� 5#      -   5        $ rbPerspective��5#      $��2q�65   $��Perspective��5$      $	 FalseY�6,   �� 5%      $��OffsetX��6   $��2q�6+   �� 5&      -   5        $��	tbOffsetX��5&      $��2q�6+   $
��Left=�5'      $��0��65   �� 5(      $��OffsetY��6   $��2q�6+   �� 5)      -   5        $��	tbOffsetY��5)      $��2q�6+   $
��Left=�5*      $��0��65   �� 5+      $��OffsetZ��6   $��2q�6+   �� 5,      -   5        $��	tbOffsetZ��5,      $��2q�6+   $
��Left=�5-      $��0��65   �� 5.      -   5        $��btnApply��5.      $��2,5,2,2q�6)   .��5/   0   Apply67   50      �� 52      $��5q�6   
���   �$��1q�64   $
��Left=�53      $	��320��60   $	��290��6<   $��1��6I   ._�54      '� -   5        $��
myViewport��54      }�. 
 '� Camera
 55      y� 56      -   5        myCameraMatrix��56   '   .x�59      7  1System.Windows.Media.Media3D.ContainerUIElement3D     Children. 5:      3  -System.Windows.Media.Media3D.ModelUIElement3D     Model. 5;   "   h� .��5=   &   �  � Geometry# [  66    � Material# [ 5>   2    j� 	Transform 5@   *   S� 5A   .   -	   5        myTransform��5A   C   5C   '   �� 5F   &    �� Color$
 Gray��63   t� 5G   &   $
 Gray��67    t� 	Direction$ -1 -2 -35�6D   5H   #   5I      5J      5K      5L      5M      5N      5O      