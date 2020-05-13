using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private GameObject player;
    public GameObject bullet;
    [SerializeField] float m_BulletVelocity = 5f;
    [SerializeField] Vector3 m_BulletOffset = new Vector3(0, 10, 0);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e")) {
            onShoot();
        }
    }

    void onShoot()
    {
        GameObject createdBullet = (GameObject)Object.Instantiate(bullet, player.transform.position + m_BulletOffset + player.transform.forward, Quaternion.identity);
        createdBullet.GetComponent<Rigidbody>().velocity = player.transform.forward * m_BulletVelocity;
    }
}
