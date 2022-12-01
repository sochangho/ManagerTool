using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.IMGUI.Controls;
using UnityEditor;
using System.Linq;
using Unity.Plastic.Newtonsoft.Json.Linq;
using UnityEditor.SceneManagement;

public class ItemTreeView :EditorWindow
{


 

    private List<ItemModel> items = new List<ItemModel>();

    #region MultiColumnHeader

    private MultiColumnHeaderState _multiColumnHeaderState;
    private MultiColumnHeader _multiColumnHeader;

    private MultiColumnHeaderState.Column[] _columns;
    #endregion


    private float _multiColumnHeaderWidth;
    private bool _firstOnGUIIterationAfterInitialize;

    private void Init()
    {
        this._firstOnGUIIterationAfterInitialize = true;

        this._multiColumnHeaderWidth = this.position.width;

        _columns = new MultiColumnHeaderState.Column[]         
        {
            new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
				autoResize = true,
                minWidth = 100.0f,
                maxWidth = 100.0f,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Number", "Item Number"),
                headerTextAlignment = TextAlignment.Left,
            },
            new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
				autoResize = true,
                minWidth = 100.0f,
                maxWidth = 100.0f,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Type", "Item type"),
                headerTextAlignment = TextAlignment.Left,
            },
            new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
				autoResize = true,
                minWidth = 100.0f,
                maxWidth = 100.0f,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Name", "Item name"),
                headerTextAlignment = TextAlignment.Left,
            },
            new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
				autoResize = true,
                minWidth = 100.0f,
                maxWidth = 100.0f,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Amount", "Item amount"),
                headerTextAlignment = TextAlignment.Left,
            },
            new MultiColumnHeaderState.Column()
            {
                allowToggleVisibility = false, // At least one column must be there.
				autoResize = true,
                minWidth = 100.0f,
                maxWidth = 100.0f,
                canSort = true,
                sortingArrowAlignment = TextAlignment.Right,
                headerContent = new GUIContent("Create_date", "Item create_data"),
                headerTextAlignment = TextAlignment.Left,
            },

        };

        this._multiColumnHeaderState = new MultiColumnHeaderState(columns: this._columns);

        this._multiColumnHeader = new MultiColumnHeader(state: this._multiColumnHeaderState);

        // When we chagne visibility of the column we resize columns to fit in the window.
        this._multiColumnHeader.visibleColumnsChanged += (multiColumnHeader) => multiColumnHeader.ResizeToFit();

        // Initial resizing of the content.
        this._multiColumnHeader.ResizeToFit();


        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0,1,"²Ü¹ú Åë¿Ê",1,"2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");
        items.Add(ScriptableObject.CreateInstance<ItemModel>());
        items[items.Count - 1].Initialize(0, 1, "²Ü¹ú Åë¿Ê", 1, "2022-12-01");

        Debug.Log("item count :: " + items.Count);
    }

    private readonly Color _lighterColor = new Color(r: 1.0f, g: 1.0f, b: 1.0f, a: 0.15f);
    private readonly Color _darkerColor = new Color(r: 0.0f, g: 0.0f, b: 0.0f, a: 0.15f);

    private Vector2 _scrollPosition;


    public void TreeViewShow()
    {

  



        float columnHeight = EditorGUIUtility.singleLineHeight;

        GUILayout.FlexibleSpace();

        Rect windowRect = GUILayoutUtility.GetLastRect();

        windowRect.width = this.position.width;
        windowRect.height = this.position.height;

        if(this._multiColumnHeader == null)
        {

            this.Init();
        }

        GUIStyle groupGUIStyle = new GUIStyle(GUI.skin.box) { };
        Vector2 groupRectPaddingInWindow = new Vector2(20.0f, 20.0f);
        Rect groupRect = new Rect(source: windowRect);

        groupRect.x += groupRectPaddingInWindow.x;
        groupRect.width -= groupRectPaddingInWindow.x * 2;

        groupRect.y += groupRectPaddingInWindow.y;
        groupRect.height -= groupRectPaddingInWindow.y * 2;


        GUI.BeginGroup(position: groupRect, style: groupGUIStyle);
        { //Grop Scope

            groupRect.x -= groupRectPaddingInWindow.x;
            groupRect.y -= groupRectPaddingInWindow.y;
            
            Rect positionalRectAreaOfScrollView = new Rect(source: groupRect);

            // Create a `viewRect` since it should be separate from `rect` to avoid circular dependency.
            Rect viewRect = new Rect(source: groupRect)
            {
                width = this._multiColumnHeaderState.widthOfAllVisibleColumns, // Scroll max on X is basically a sum of width of columns.
                                                                               //? Do not remove this hegiht. It's compensating for the size of bottom scroll slider when it appears, that is why the right side scroll slider appears.                                                                               //height = groupRect.height - columnHeight, // Remove `columnHeight` - basically size of header.
            };

            groupRect.width += groupRectPaddingInWindow.x * 2;
            groupRect.height += groupRectPaddingInWindow.y * 2;

            this._scrollPosition = GUI.BeginScrollView(
                position: positionalRectAreaOfScrollView,
                scrollPosition: this._scrollPosition,
                viewRect: viewRect,
                alwaysShowHorizontal: false,
                alwaysShowVertical: false
             );
            //Scroll View Scope.
            {
                this._multiColumnHeaderWidth = Mathf.Max(positionalRectAreaOfScrollView.width + this._scrollPosition.x, this._multiColumnHeaderWidth);

                Rect columnRectPrototype = new Rect(source: positionalRectAreaOfScrollView)
                {
                    width = this._multiColumnHeaderWidth,
                    height = columnHeight, // This is basically a height of each column including header.
                };

                this._multiColumnHeader.OnGUI(rect: columnRectPrototype, xScroll: 0.0f);

                float heightJump = columnHeight;

                for(int i = 0; i< items.Count; i++)
                {
                    SerializedObject serializedObject = new SerializedObject(obj: this.items[i]);
                    float calculatedRowHeight = 0.0f;

                    Rect rowRect = new Rect(source: columnRectPrototype);

                    CreateColumn(0, this.items[i].number.ToString(), rowRect.y + heightJump*(i+1));
                    CreateColumn(1, this.items[i].type.ToString(), rowRect.y + heightJump * (i + 1));
                    CreateColumn(2, this.items[i].name_item, rowRect.y + heightJump * (i + 1));
                    CreateColumn(3, this.items[i].amount.ToString(), rowRect.y + heightJump * (i + 1));
                    CreateColumn(4, this.items[i].create_date, rowRect.y + heightJump * (i + 1));

                    Rect backgroundColorRect = new Rect(source: rowRect)
                    {
                        y = rowRect.y + heightJump,
                        height = calculatedRowHeight
                    };

                    // Draw a texture before drawing each of the fields for the whole row.
                    if (i % 2 == 0)
                        EditorGUI.DrawRect(rect: backgroundColorRect, color: this._darkerColor);
                    else
                        EditorGUI.DrawRect(rect: backgroundColorRect, color: this._lighterColor);

                    heightJump += calculatedRowHeight;


                }

             
            }
            GUI.EndScrollView(handleScrollWheel: true);
        }
        GUI.EndGroup();
        this._firstOnGUIIterationAfterInitialize = false;
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




