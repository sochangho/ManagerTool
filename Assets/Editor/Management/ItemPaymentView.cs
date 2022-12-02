using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPaymentView : ManagementView
{

    ItemPaymentTreeView ItemPaymentTreeView;


    public ItemPaymentView()
    {
        ItemPaymentTreeView = new ItemPaymentTreeView();
    }

    public override void ShowGUI()
    {
        GUILayout.BeginHorizontal();
        GUILayout.Space(50);
        ItemPaymentTreeView.TreeViewShow();
        GUILayout.EndHorizontal();
    }
}
