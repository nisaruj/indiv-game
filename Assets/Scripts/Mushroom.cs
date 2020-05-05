using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mushroom : Obtainable
{
    public override void onObtain(GameObject player)
    {
        Debug.Log("Healed");
        player.SendMessage("heal", 1.0f);
    }

    public void Update()
    {

    }
}