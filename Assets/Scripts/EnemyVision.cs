using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    private const int V = 3;
    [Range(1f, 20f)] [SerializeField] float m_MaxDistance = 7.0f;

    [SerializeField] float m_MovementSpeed = 1f;
    [SerializeField] float m_RotateSpeed = 1f;

    [SerializeField] float m_AttackForce = 10f;
    [SerializeField] Vector3 m_AttackForceOffset = new Vector3(0f, 0.5f, 0f);
    [SerializeField] int m_MaxHP = 3;

    private GameObject player;
    private Rigidbody playerRigidbody;
    private Vector3 toPlayer;
    private int currentHP = 3;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerRigidbody = player.GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        toPlayer = player.transform.position - transform.position;
        toPlayer.y = 0;

        if (toPlayer.magnitude <= m_MaxDistance)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.transform.position - transform.position), m_RotateSpeed * Time.deltaTime);
            transform.position += transform.forward * m_MovementSpeed * Time.deltaTime;
        }
    }

    // Attack the player
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(transform.forward);
            Vector3 force = (transform.forward + m_AttackForceOffset) * m_AttackForce;
            playerRigidbody.AddForce(force, ForceMode.Impulse);
        }
        else if (collision.gameObject.tag == "Weapon")
        {
            Debug.Log("Goomba is attacked.");
            OnAttacked();
        }
    }
    void OnAttacked()
    {
        currentHP--;
        if (currentHP > 0) return;
        Dead();
    }
    void Dead()
    {
        Destroy(GameObject.FindWithTag("Enemy"));
    }
}
