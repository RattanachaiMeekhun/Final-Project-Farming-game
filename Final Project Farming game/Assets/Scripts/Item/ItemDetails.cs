
using UnityEngine;

[System.Serializable]

public class ItemDetails
{
    public int itemCode;
    public ItemType itemType;
    public string itemDescription;
    public Sprite itemSprite;
    public string itemLongDescritption;
    public short itemUseGridRadius;
    public float itemUseRadius;
    public bool isStartingItem;
    public bool canBePickup;
    public bool canBeDropped;
    public bool canBeEaten;
    public bool canBeCarried;
}
