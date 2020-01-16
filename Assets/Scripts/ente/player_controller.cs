﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player_controller : MonoBehaviour
{
    private float m_speed = 10.0f;

    private Rigidbody m_rigidbody;
    public int mCollectibleCount;
    public Text count;
    public Babies babiesScript;

    // Start is called before the first frame update
    private void Start()
    {
        //m_rigidbody = gameObject.GetComponent<Rigidbody>();
        //mCollectibleCount = GameObject.FindGameObjectsWithTag("collectable").Length;
        //count.text = mCollectibleCount.ToString();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //m_rigidbody.AddForce(movement * m_speed);
}

    private void OnTriggerEnter(Collider other)

    {
        if(other.gameObject.CompareTag("babies"))
        {
            other.gameObject.SetActive(false);
            babiesScript.activateBaby();
            /*
            mCollectibleCount = mCollectibleCount - 1;
            count.text = mCollectibleCount.ToString();
            babiesScript.activateBaby();
            */
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
 


