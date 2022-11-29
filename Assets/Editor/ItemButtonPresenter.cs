using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ItemButtonPresenter
{
    
    private List<KeyValuePair<ItemButtonModel, System.Action>> itemButtonModels = new List<KeyValuePair<ItemButtonModel, System.Action>>();

    private ManagementView managementView = new ManagementView();

    public void Init()
    {

        ItemButtonModel item_account = new ItemButtonModel("���� ��ȸ", true);
        ItemButtonModel item_im = new ItemButtonModel("������ ����", false);
        ItemButtonModel item_notice = new ItemButtonModel("���� ����", false);
        ItemButtonModel item_chatting = new ItemButtonModel("ä�� ����", false);

        itemButtonModels.Add(new KeyValuePair<ItemButtonModel,System.Action >(item_account,managementView.AccountManagementShow));

        itemButtonModels.Add(new KeyValuePair<ItemButtonModel, System.Action>(item_im, managementView.ItemManagementShow));

        itemButtonModels.Add(new KeyValuePair<ItemButtonModel, System.Action>(item_notice, managementView.NoticeManagementShow));

        itemButtonModels.Add(new KeyValuePair<ItemButtonModel, System.Action>(item_chatting, managementView.ChattingManagementShow));
    }




    public void GUIButtonRender()
    {


        GUILayout.BeginVertical();
        
        GUILayout.Space(30);
        foreach(KeyValuePair<ItemButtonModel, System.Action> item in itemButtonModels)
        {
            GUILayoutOption[] options = new GUILayoutOption[]
            {
                GUILayout.Height(70),
                GUILayout.Width(100)

            };

            if (GUILayout.Button(item.Key.button_Name,options))
            {
                GUIItemButtonClick(item.Key);
            }

            GUILayout.Space(20);
        }

        GUILayout.EndVertical();
    }




    public void GUIManagementRender()
    {

        foreach (KeyValuePair<ItemButtonModel, System.Action> item in itemButtonModels)
        {
            if (item.Key.button_isCheck)
            {
                item.Value.Invoke();
            }
        }


    }


    private void GUIItemButtonClick(ItemButtonModel itemButtonModel)
    {
        
        foreach (KeyValuePair<ItemButtonModel, System.Action> item in itemButtonModels)
        {
            item.Key.button_isCheck = false;

        }

        itemButtonModel.button_isCheck = true;
    }


    
}
