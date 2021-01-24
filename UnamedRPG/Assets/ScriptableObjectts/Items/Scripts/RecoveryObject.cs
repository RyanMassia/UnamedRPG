using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recovery Object", menuName = "Inventroy System/Items/Recovery")]
public class RecoveryObject : ItemObject
{
    public int restoreHpValue;
    public void Awake()
    {
        type = ItemType.Recovery;   
    }

    
}
