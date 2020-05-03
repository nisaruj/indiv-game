using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Obtainable
{
    [Range(0f, 360f)][SerializeField] float m_RotationSpeed = 120f;

    public override void onObtain(GameObject player) 
    {
        Debug.Log("Obtained");
    }

    public void Update() 
    {
        transform.Rotate(0, m_RotationSpeed * Time.deltaTime, 0);
    }
}
