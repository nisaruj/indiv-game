using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCam : MonoBehaviour
{
    public float speed = 10f;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Follow player's position
        transform.position = player.transform.position;
        // transform.Rotate(0, speed * Time.deltaTime, 0);

        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        // Rotate our transform a step closer to the target's.
        transform.rotation = Quaternion.RotateTowards(transform.rotation, player.transform.rotation, step);
    }
}
