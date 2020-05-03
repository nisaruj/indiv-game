using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Obtainable
{
    public override void onObtain(GameObject player) 
    {
        Debug.Log("Obtained");
    }
}
