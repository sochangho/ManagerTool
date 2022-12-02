using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPaymentModel : Model
{
    public int number;
    public int type;
    public string name_item;

    public ItemPaymentModel(int number, int type, string name_item)
    {
        this.number = number;
        this.type = type;
        this.name_item = name_item;
    }
}
