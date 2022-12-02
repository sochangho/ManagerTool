using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPaymentTreeView : TreeView
{
    override public void Init()
    {
        items = new Model[]
        {
            new ItemPaymentModel(0 , 1 , "²Ü¹ú Åë¿Ê"),
            new ItemPaymentModel(1 , 2 , "°æÂû Åë¿Ê"),
            new ItemPaymentModel(2 , 4 , "°æÂû Åë¿Ê"),
            new ItemPaymentModel(3 , 7 , "¤¾    0"),

        };
        multiColumnHeaderContoler.HeaderAttributeColumnAdd(100, 100, 200, new GUIContent("Number", "Item Number"));
        multiColumnHeaderContoler.HeaderAttributeColumnAdd(100, 100, 200, new GUIContent("Type", "Item Type"));
        multiColumnHeaderContoler.HeaderAttributeColumnAdd(100, 100, 200, new GUIContent("Name", "Item Name"));       
        multiColumnHeaderContoler.HeaderInit();
    }


    override public void DrawColumns(Model model, float rowY)
    {
        ItemPaymentModel itemModel = (ItemPaymentModel)model;
        ColumnsCreateController.TextCreateColumn(0, itemModel.number.ToString(), rowY, multiColumnHeaderContoler.GetMultiHeader());
        ColumnsCreateController.TextCreateColumn(1, itemModel.type.ToString(), rowY, multiColumnHeaderContoler.GetMultiHeader());
        ColumnsCreateController.TextCreateColumn(2, itemModel.name_item, rowY, multiColumnHeaderContoler.GetMultiHeader());
    }
}
