
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CustomPropertyDrawer(typeof(ItemCodeDestricptionAttribute))]
public class ItemCodeDescriptionDrawer : PropertyDrawer
{

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {

        return EditorGUI.GetPropertyHeight(property) * 2;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position,label,property);

        if(property.propertyType == SerializedPropertyType.Integer)
        {

            EditorGUI.BeginChangeCheck();

            var newValue = EditorGUI.IntField(new Rect(position.x,position.y,position.width,position.height/2),property.intValue);

            EditorGUI.LabelField(new Rect(position.x, position.y+position.height/2, position.width, position.height / 2),
                "Item Description." , GetItemDescription(property.intValue));

            if (EditorGUI.EndChangeCheck())
            {
                property.intValue = newValue;
            }

        }

        EditorGUI.EndProperty();
    }

    private String GetItemDescription(int itemCode)
    {
        SO_Itemlist so_Itemlist;

        so_Itemlist = AssetDatabase.LoadAssetAtPath("Assets/Scriptable Object Assets/Item/so_ItemList.asset"
            ,typeof(SO_Itemlist)) as SO_Itemlist;

        List<ItemDetails> itemDetailsList = so_Itemlist.itemDetails;

        ItemDetails itemDetail = itemDetailsList.Find(x => x.itemCode == itemCode);

        if (itemDetail != null)
        {
            return itemDetail.itemDescription;
        }
        else
        {
            return "";
        }

    }
}
