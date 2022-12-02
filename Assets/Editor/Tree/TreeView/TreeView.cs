using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro.EditorUtilities;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public abstract class TreeView 
{

    public MultiColumnHeaderContoler multiColumnHeaderContoler = new MultiColumnHeaderContoler();
    public Model[] items ;
    public  float column_height = 30;


    public readonly Color _lighterColor = Color.white * 0.3f;
    public readonly Color _darkerColor = Color.white * 0.1f;

    private Vector2 _scrollPosition;




    #region Rect


    Rect columnRectPrototype;
    Rect header_columnRectPrototype;

    private Rect ViewRect()
    {

        Rect windowRect = GUILayoutUtility.GetLastRect();


        windowRect.width = 800;
        windowRect.height = 800;


        float columnHeight = 30.0f;//EditorGUIUtility.singleLineHeight;
        float headerColumnHeight = EditorGUIUtility.singleLineHeight;
        columnRectPrototype = new Rect(source: windowRect)
        {
            height = columnHeight, // This is basically a height of each column including header.
        };
        header_columnRectPrototype = new Rect(source: windowRect)
        {
            height = headerColumnHeight, // This is basically a height of each column including header.
        };

       // Rect positionalRectAreaOfScrollView = GUILayoutUtility.GetRect(0, float.MaxValue, 0, float.MaxValue);

        Rect viewRect = new Rect(source: windowRect)
        {
            xMax = this.multiColumnHeaderContoler.GetMultiHeaderColumns().Sum((column) => column.width), // Scroll max on X is basically a sum of width of columns.
            yMax = items.Length * columnHeight + 300,

        };

        return viewRect;
    }

    #endregion


    abstract public void Init();

    abstract public void DrawColumns(Model model , float rowY);

    public void TreeViewShow()
    {

        if (multiColumnHeaderContoler.GetMultiHeader() == null)
        {
            Init();
        }



        Rect viewRect = ViewRect();

        Rect positionalRectAreaOfScrollView = GUILayoutUtility.GetRect(0, float.MaxValue, 0, float.MaxValue);
        this._scrollPosition = GUI.BeginScrollView(
            position: positionalRectAreaOfScrollView,
            scrollPosition: this._scrollPosition,
            viewRect: viewRect,
            alwaysShowHorizontal: false,
            alwaysShowVertical: false
        );

        this.multiColumnHeaderContoler.GetMultiHeader().OnGUI(rect: header_columnRectPrototype, xScroll: 0.0f);
        for (int i = 0; i < this.items.Length; i++)
        {

            Rect rowRect = new Rect(columnRectPrototype);

            rowRect.y += column_height * (i + 1);


            if (i % 2 == 0)
                EditorGUI.DrawRect(rect: rowRect, color: this._darkerColor);
            else
                EditorGUI.DrawRect(rect: rowRect, color: this._lighterColor);


            DrawColumns(items[i] , rowRect.y);
        }

        GUI.EndScrollView(handleScrollWheel: true);

    }





}
