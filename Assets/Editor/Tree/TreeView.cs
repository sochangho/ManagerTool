using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class TreeView : MonoBehaviour
{
    #region MultiColumnHeader
    private MultiColumnHeaderState _multiColumnHeaderState;
    private MultiColumnHeader _multiColumnHeader;

    private MultiColumnHeaderState.Column[] _columns;
    #endregion


    private List<MultiColumnHeaderState.Column> list_columns;

    Model[] items ;
    float column_height;
    public void ColumnAdd(float min_w , float w , float max_w , GUIContent header_content)
    {
        MultiColumnHeaderState.Column column = new MultiColumnHeaderState.Column()
        {
            allowToggleVisibility = false, // At least one column must be there.
            autoResize = true,
            minWidth = min_w,
            width = w,
            maxWidth = max_w,
            canSort = true,
            sortingArrowAlignment = TextAlignment.Right,
            headerContent = header_content,
            headerTextAlignment = TextAlignment.Left,
        };
        list_columns.Add(column);
    }


    private void Init()
    {        
        _columns = list_columns.ToArray();

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


        windowRect.width = 800;
        windowRect.height = 800;


        float columnHeight = column_height;
        float headerColumnHeight = EditorGUIUtility.singleLineHeight;
        Rect columnRectPrototype = new Rect(source: windowRect)
        {
            height = columnHeight, // This is basically a height of each column including header.
        };
        Rect header_columnRectPrototype = new Rect(source: windowRect)
        {
            height = headerColumnHeight, // This is basically a height of each column including header.
        };

        Rect positionalRectAreaOfScrollView = GUILayoutUtility.GetRect(0, float.MaxValue, 0, float.MaxValue);

        Rect viewRect = new Rect(source: windowRect)
        {
            xMax = this._columns.Sum((column) => column.width), // Scroll max on X is basically a sum of width of columns.
            yMax = items.Length * columnHeight + 300,

        };

        this._scrollPosition = GUI.BeginScrollView(
            position: positionalRectAreaOfScrollView,
            scrollPosition: this._scrollPosition,
            viewRect: viewRect,
            alwaysShowHorizontal: false,
            alwaysShowVertical: false
        );

        this._multiColumnHeader.OnGUI(rect: header_columnRectPrototype, xScroll: 0.0f);
        for (int i = 0; i < this.items.Length; i++)
        {

            Rect rowRect = new Rect(columnRectPrototype);

            rowRect.y += columnHeight * (i + 1);


            if (i % 2 == 0)
                EditorGUI.DrawRect(rect: rowRect, color: this._darkerColor);
            else
                EditorGUI.DrawRect(rect: rowRect, color: this._lighterColor);

            
            for(int j = 0; j < list_columns.Count; j++)
            {


            }

        }

        GUI.EndScrollView(handleScrollWheel: true);

    }


    private void CreateColumn(int index, string value, float rowY)
    {
        int columnIndex = index;
        if (this._multiColumnHeader.IsColumnVisible(columnIndex: columnIndex))
        {
            int visibleColumnIndex = this._multiColumnHeader.GetVisibleColumnIndex(columnIndex: columnIndex);

            Rect columnRect = this._multiColumnHeader.GetColumnRect(visibleColumnIndex: visibleColumnIndex);

            
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
