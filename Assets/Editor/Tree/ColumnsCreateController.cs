using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEditor;
using UnityEngine;

public class ColumnsCreateController 
{
   
    public static void TextCreateColumn(int index, string value, float rowY, MultiColumnHeader multiColumnHeader)
    {
        

        int columnIndex = index;
        if (multiColumnHeader.IsColumnVisible(columnIndex: columnIndex))
        {
            
            int visibleColumnIndex = multiColumnHeader.GetVisibleColumnIndex(columnIndex: columnIndex);

            Rect columnRect = multiColumnHeader.GetColumnRect(visibleColumnIndex: visibleColumnIndex);
      
            columnRect.y = rowY;

      
            GUIStyle nameFieldGUIStyle = new GUIStyle(GUI.skin.label)
            {
                padding = new RectOffset(left: 10, right: 10, top: 2, bottom: 2)
            };
            EditorGUI.LabelField(
                position: multiColumnHeader.GetCellRect(visibleColumnIndex: visibleColumnIndex, columnRect),
                label: new GUIContent(value),
                style: nameFieldGUIStyle
            );
        }
    }


}
