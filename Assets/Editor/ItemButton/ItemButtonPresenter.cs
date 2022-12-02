using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ItemButtonPresenter
{
    
    private List<KeyValuePair<ItemButtonModel, ManagementView>> itemButtonModels 
        = new List<KeyValuePair<ItemButtonModel, ManagementView>>();

    

    public void Init()
    {

        ItemButtonModel item_account = new ItemButtonModel("계정 조회", true);
        ItemButtonModel item_im = new ItemButtonModel("아이템 지급", false);
        ItemButtonModel item_notice = new ItemButtonModel("공지 관리", false);
        ItemButtonModel item_chatting = new ItemButtonModel("채팅 공지", false);

        ManagementView account_view = new AccountInquiryView();
        ManagementView itempayment_view = new ItemPaymentView();
        ManagementView chattingManagement_view = new ChattingManagementVew();
        ManagementView notice_view = new NoticeView();


        itemButtonModels.Add(new KeyValuePair<ItemButtonModel, ManagementView>(item_account, account_view));

        itemButtonModels.Add(new KeyValuePair<ItemButtonModel, ManagementView>(item_im, itempayment_view));

        itemButtonModels.Add(new KeyValuePair<ItemButtonModel, ManagementView>(item_notice, chattingManagement_view));

        itemButtonModels.Add(new KeyValuePair<ItemButtonModel, ManagementView>(item_chatting, notice_view));
    }




    public void GUIButtonRender()
    {


        GUILayout.BeginVertical();
        
        GUILayout.Space(30);
        foreach(var item in itemButtonModels)
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

        foreach (var item in itemButtonModels)
        {
            if (item.Key.button_isCheck)
            {
                item.Value.ShowGUI();
            }
        }


    }


    private void GUIItemButtonClick(ItemButtonModel itemButtonModel)
    {
        
        foreach (var item in itemButtonModels)
        {
            item.Key.button_isCheck = false;

        }

        itemButtonModel.button_isCheck = true;
    }


    
}
