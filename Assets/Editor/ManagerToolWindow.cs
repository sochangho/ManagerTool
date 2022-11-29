using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ManagerToolWindow : EditorWindow
{
    
    static ItemButtonPresenter itemButtonPresenter ; 


    [MenuItem("Window/Manager Tool")]
    public static void Init()
    {
       ManagerToolWindow managerToolWindow = (ManagerToolWindow)EditorWindow.GetWindow(typeof(ManagerToolWindow));
       managerToolWindow.Show();

       managerToolWindow.titleContent.text = "Ubbiy ¿î¿µÅø";
       managerToolWindow.minSize = new Vector2(600, 800);
       managerToolWindow.maxSize = new Vector2(800, 1000);

       itemButtonPresenter = new ItemButtonPresenter();
       itemButtonPresenter.Init();
       
    }

    private void OnGUI()
    {

    
        GUILayout.BeginArea(new Rect(0, 0, 100, 400));
        itemButtonPresenter.GUIButtonRender();
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect(120, 30, 600, 700));
        itemButtonPresenter.GUIManagementRender();
        GUILayout.EndArea();




    }
}
