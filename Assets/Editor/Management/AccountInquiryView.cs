using System.Collections;
using System.Collections.Generic;
using Unity.Plastic.Newtonsoft.Json.Linq;
using UnityEditor;
using UnityEngine;
using UnityEditor.IMGUI.Controls;
using static UnityEditor.Progress;

public class AccountInquiryView : ManagementView
{
    string name_user;

    GUILayoutOption[] options_button;
    GUILayoutOption[] options_textfield;
    GUILayoutOption[] options_accountText;
    GUILayoutOption[] options_buttonExl;

    private AccountPlayerModel accountPlayerModel;
 
    

    private ItemTreeView ItemTreeView;


    public System.Action<object> action_account;
    public System.Action<object> action_exlExport;


    public AccountInquiryView()
    {
        options_button = new GUILayoutOption[]
        {
            GUILayout.Width(50),
            GUILayout.Height(20),
        };


        options_textfield = new GUILayoutOption[]
        {
            GUILayout.Width(200),
            GUILayout.Height(20),

        };

        options_accountText = new GUILayoutOption[]
        {
            GUILayout.Width(100)
        };

        options_buttonExl = new GUILayoutOption[]
        {
            GUILayout.Width(70),
            GUILayout.Height(30)

        };


        action_account = (obj) => { Debug.Log("���� ��ȸ"); };
        action_exlExport = (obj) => { Debug.Log("���� ���"); };

        accountPlayerModel = new AccountPlayerModel();


        ItemTreeView = new ItemTreeView();


    }




    override public void ShowGUI()
    {
        //----------------- �˻� ��ȸ ------------------------

        GUILayout.BeginHorizontal();

        GUILayout.Space(150);

        name_user = EditorGUILayout.TextField(name_user , options_textfield);

        GUILayout.Space(20);


        if (GUILayout.Button("��ȸ" , options_button))
        {
            action_account?.Invoke(null);
        }

        GUILayout.EndHorizontal();

        //-------------------------------------------------------



        //-------------- �÷��̾� ���� ----------------------------

        GUILayout.Space(20);
        AccountShow("Account : ", accountPlayerModel.account);
        AccountShow("Nicname : ", accountPlayerModel.nic_name);
        AccountShow("State : ", accountPlayerModel.state);
        AccountShow("LastPlayDate : ", accountPlayerModel.lastplayDate);
        GUILayout.Space(20);
        //-----------------------------------------------------------


        GUILayout.BeginHorizontal();
        GUILayout.Space(520);
        if (GUILayout.Button("����", options_buttonExl))
        {
            action_exlExport?.Invoke(null);
        }
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        GUILayout.BeginHorizontal();
        GUILayout.Space(50);
        ItemTreeView.TreeViewShow();
        GUILayout.EndHorizontal();


    }


    private void AccountShow(string item , string value)
    {
        GUILayout.BeginHorizontal();

        GUILayout.Space(50);
        EditorGUILayout.LabelField(item, options_accountText);
        EditorGUILayout.LabelField(value, options_accountText);

        GUILayout.EndHorizontal();

        GUILayout.Space(10);
    }

}
