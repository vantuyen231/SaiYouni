using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemProfile", menuName = "ScriptableObjects/ItemProfile", order = 1)]
public class ItemProfileSO : ScriptableObject
{
    public InvCodeName invCodeName;
    public ItemCode itemCode;
    public string itemName;
    public Sprite itemImage;
    public bool isStackable = false;
}