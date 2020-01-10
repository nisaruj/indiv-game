using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IdleChecker : MonoBehaviour
{
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    bool m_Dancing = false;

    private float idleTime = 0;
    public float danceLimit = 10f;
    public float motionDetectorThreshold = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Animator.GetFloat("Forward") < motionDetectorThreshold && m_Animator.GetFloat("Turn") < motionDetectorThreshold) {
            idleTime += Time.deltaTime;
        } else {
            idleTime = 0f;
            m_Dancing = false;
        }

        if (m_Animator.GetBool("OnGround") && idleTime > danceLimit) {
            m_Dancing = true;
        }

        m_Animator.SetBool("Dance", m_Dancing);
    }
}
