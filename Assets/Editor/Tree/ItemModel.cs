using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel
{
    public int number;
    public int type;
    public string name_item;
    public int amount;
    public string create_date;


    public ItemModel(int number, int type, string name_item, int amount, string create_date)
    {
        this.number = number;
        this.type = type;
        this.name_item = name_item;
        this.amount = amount;
        this.create_date = create_date;
    }
}
