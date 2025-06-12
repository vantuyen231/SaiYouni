using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryCtrl : SaiBehaviour
{
    [SerializeField] protected List<ItemInventory> items = new();
    public List<ItemInventory> Items => items;
    public abstract InvCodeName GetName();

    public virtual void AddItem(ItemInventory item)
    {

        ItemInventory itemExist = this.FindItemInInventory(item.ItemProfile.itemCode);
        if (!item.ItemProfile.isStackable || itemExist == null)
        {
            item.SetId(Random.Range(0, 999999999));
            this.items.Add(item);
            return;
        }

        itemExist.itemCount += item.itemCount;
    }

    public virtual bool RemoveItem(ItemInventory item)
    {
        ItemInventory itemExist = this.FindItemNotEmpty(item.ItemProfile.itemCode);
        if (itemExist == null) return false;
        if (!itemExist.CanDeduct(item.itemCount)) return false;
        itemExist.Deduct(item.itemCount);
        if (itemExist.itemCount == 0) this.items.Remove(itemExist);
        return true;
    }

    public virtual ItemInventory FindItemNotEmpty(ItemCode itemCode)
    {
        foreach (ItemInventory itemInventory in this.items)
        {
            if (itemInventory.ItemProfile.itemCode != itemCode) continue;
            if (itemInventory.itemCount > 0) return itemInventory;
        }

        return null;
    }

    public virtual ItemInventory FindItemInInventory(ItemCode itemCode)
    {
        foreach (ItemInventory itemInventory in this.items)
        {
            if (itemInventory.ItemProfile.itemCode == itemCode) return itemInventory;
        }

        return null;
    }

    public virtual ItemInventory FindItem(ItemCode itemCode)
    {
        return this.FindItemInInventory(itemCode);
    }
}