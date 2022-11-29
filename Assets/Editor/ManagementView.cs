using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ManagementView 
{
    string myString;

    public void AccountManagementShow()
    {
        GUILayout.BeginHorizontal();

        myString = EditorGUILayout.TextField("Text Field", myString);

        if (GUILayout.Button("ют╥б"))
        {

        }

        GUILayout.EndHorizontal();
    }
    public void ItemManagementShow()
    {

    }
    public void NoticeManagementShow()
    {

    }
    public void ChattingManagementShow()
    {


    }



}
