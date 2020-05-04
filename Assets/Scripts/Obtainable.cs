using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public abstract class Obtainable : MonoBehaviour
{
    public abstract void onObtain(GameObject player);

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject player = collision.gameObject;
            onObtain(player);
            Destroy(gameObject);
        }
    }
}