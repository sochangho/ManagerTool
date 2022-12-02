using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class MultiColumnHeaderContoler
{
    #region MultiColumnHeader
    private MultiColumnHeaderState _multiColumnHeaderState;
    private MultiColumnHeader _multiColumnHeader;

    private MultiColumnHeaderState.Column[] _columns;
    #endregion


    private List<MultiColumnHeaderState.Column> list_columns = new List<MultiColumnHeaderState.Column>();

    public void HeaderAttributeColumnAdd(float min_w, float w, float max_w, GUIContent header_content)
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


    public void HeaderInit()
    {
        _columns = list_columns.ToArray();
        this._multiColumnHeaderState = new MultiColumnHeaderState(columns: this._columns);
        this._multiColumnHeader = new MultiColumnHeader(state: this._multiColumnHeaderState);
        // When we chagne visibility of the column we resize columns to fit in the window.
        this._multiColumnHeader.visibleColumnsChanged += (multiColumnHeader) => multiColumnHeader.ResizeToFit();
        // Initial resizing of the content.
        this._multiColumnHeader.ResizeToFit();
        

    }

    public MultiColumnHeader GetMultiHeader()
    {
        return  _multiColumnHeader;
    }

    public MultiColumnHeaderState.Column[] GetMultiHeaderColumns()
    {
        return _columns;
    }

}
