using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
public class Mushroom : Obtainable
{
    public override void onObtain(GameObject player)
    {
        ThirdPersonCharacter tpCharacter = player.GetComponent<ThirdPersonCharacter>();
        tpCharacter.heal(1);
    }

    public void Update()
    {

    }
}