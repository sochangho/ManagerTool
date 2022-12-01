using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class AccountItemBulider : ModelsBuilder 
{

 
    override public MultiColumnHeaderState.Column[] ColumnsSet()
    {
        _columns = new MultiColumnHeaderState.Column[]
      {
            new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
                autoResize = true,
                minWidth = 100,
                width = 100,
                maxWidth = 200,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Number", "item number"),
                headerTextAlignment = TextAlignment.Left,
            },
             new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
                autoResize = true,
                minWidth = 100,
                width = 100,
                maxWidth = 200,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Type", "item type"),
                headerTextAlignment = TextAlignment.Left,
            },
              new MultiColumnHeaderState.Column()
            {
                 allowToggleVisibility = false, // At least one column must be there.
                autoResize = true,
                minWidth = 100,
                width = 100,
                maxWidth = 100,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Name", "item name"),
                headerTextAlignment = TextAlignment.Left,
            },
               new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
                autoResize = true,
                minWidth = 100,
                width = 100,
                maxWidth = 100,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Amount", "item amount"),
                headerTextAlignment = TextAlignment.Left,
            },
                new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
                autoResize = true,
                minWidth = 100,
                width = 100,
                maxWidth = 100,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Create_date", "date"),
                headerTextAlignment = TextAlignment.Left,
            },
      };

        return _columns;
    }



}
