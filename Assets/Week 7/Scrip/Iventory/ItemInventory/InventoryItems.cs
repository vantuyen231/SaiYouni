using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItems : InventoryCtrl
{
    public override InvCodeName GetName()
    {
        return InvCodeName.Items;
    }
}