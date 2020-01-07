using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 10.0f;
    //public Rigidbody ente;
    

    // Start is called before the first frame update
    void Start()
    {
        //ente = gameObject.GetComponent<Rigidbody>();
        //ente.AddForce(0, 0, speed, ForceMode.Impulse);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);

    }

    void FixedUpdate()
    {
       
        //ente.AddRelativeForce(Vector3.forward * speed);
        
    }
    
    
}
