using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.IMGUI.Controls;
using UnityEditor;
using System.Linq;
using Unity.Plastic.Newtonsoft.Json.Linq;

public class ItemTreeView :EditorWindow
{


    private ItemModel[] items = new ItemModel[] {

    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°ø·æ Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"³ë¶û ¿øÇÇ½º",1,"2022-11-01"),
    new ItemModel(0,1,"·¹µå Ä¡¸¶",1,"2022-11-01"),
    new ItemModel(0,1,"²Ü¹ú Åë¿Ê",1,"2022-11-01"),
    new ItemModel(0,1,"°æÂû Åë¿Ê",1,"2022-11-01"),


    };

    #region MultiColumnHeader
    private MultiColumnHeaderState _multiColumnHeaderState;
    private MultiColumnHeader _multiColumnHeader;

    private MultiColumnHeaderState.Column[] _columns;
    #endregion

    private void Init()
    {
        _columns = new MultiColumnHeaderState.Column[]         
        { 
            new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
                autoResize = true,
                minWidth = 100,
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
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Create_date", "date"),
                headerTextAlignment = TextAlignment.Left,
            },
        };

        this._multiColumnHeaderState = new MultiColumnHeaderState(columns: this._columns);

        this._multiColumnHeader = new MultiColumnHeader(state: this._multiColumnHeaderState);

        // When we chagne visibility of the column we resize columns to fit in the window.
        this._multiColumnHeader.visibleColumnsChanged += (multiColumnHeader) => multiColumnHeader.ResizeToFit();

        // Initial resizing of the content.
        this._multiColumnHeader.ResizeToFit();

    }

    private readonly Color _lighterColor = Color.white * 0.3f;
    private readonly Color _darkerColor = Color.white * 0.1f;

    private Vector2 _scrollPosition;


    public void TreeViewShow()
    {

        if (this._multiColumnHeader == null)
        {
            this.Init();
        }

        Rect windowRect = GUILayoutUtility.GetLastRect();

        windowRect.width = 600;
        windowRect.height = 600;


        float columnHeight = EditorGUIUtility.singleLineHeight;

        Rect columnRectPrototype = new Rect(source: windowRect)
        {
            height = columnHeight, // This is basically a height of each column including header.
        };


        Rect positionalRectAreaOfScrollView = GUILayoutUtility.GetRect(0, float.MaxValue, 0, float.MaxValue);

        Rect viewRect = new Rect(source: windowRect)
        {
            xMax = this._columns.Sum((column) => column.minWidth) // Scroll max on X is basically a sum of width of columns.
        };

        this._scrollPosition = GUI.BeginScrollView(
            position: positionalRectAreaOfScrollView,
            scrollPosition: this._scrollPosition,
            viewRect: viewRect,
            alwaysShowHorizontal: false,
            alwaysShowVertical: false
        );
        this._multiColumnHeader.OnGUI(rect: columnRectPrototype, xScroll: 0.0f);

        for (int i = 0;  i < this.items.Length; i++)
        {

            Rect rowRect = new Rect(columnRectPrototype);
            rowRect.y += columnHeight * (i + 1);

            if (i % 2 == 0)
                EditorGUI.DrawRect(rect: rowRect, color: this._darkerColor);
            else
                EditorGUI.DrawRect(rect: rowRect, color: this._lighterColor);

            CreateColumn(0, items[i].number.ToString(), rowRect.y);
            CreateColumn(1, items[i].type.ToString(), rowRect.y);
            CreateColumn(2, items[i].name_item, rowRect.y);
            CreateColumn(3, items[i].amount.ToString().ToString(), rowRect.y);
            CreateColumn(4, items[i].create_date, rowRect.y);
        }

        GUI.EndScrollView(handleScrollWheel: true);

    }


    private void CreateColumn(int index , string value , float rowY)
    {
        int columnIndex = index;
        if (this._multiColumnHeader.IsColumnVisible(columnIndex: columnIndex))
        {
            int visibleColumnIndex = this._multiColumnHeader.GetVisibleColumnIndex(columnIndex: columnIndex);

            Rect columnRect = this._multiColumnHeader.GetColumnRect(visibleColumnIndex: visibleColumnIndex);

            // This here basically is a row height, you can make it any value you like. Or you could calculate the max field height here that your object has and store it somewhere then use it here instead of `EditorGUIUtility.singleLineHeight`.
            // We move position of field on `y` by this height to get correct position.
            columnRect.y = rowY;

            GUIStyle nameFieldGUIStyle = new GUIStyle(GUI.skin.label)
            {
                padding = new RectOffset(left: 10, right: 10, top: 2, bottom: 2)
            };

            EditorGUI.LabelField(
                position: this._multiColumnHeader.GetCellRect(visibleColumnIndex: visibleColumnIndex, columnRect),
                label: new GUIContent(value),
                style: nameFieldGUIStyle
            );
        }
    }


}




