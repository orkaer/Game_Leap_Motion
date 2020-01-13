using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;



public class player_movement : MonoBehaviour
{
    public float speed = 1.0f;
    public Rigidbody ente;
    private palm_rotation rot;
    public GameObject obj_rot;
    Vector3 defaultPos;



    // Start is called before the first frame update
    void Start()
    {
        defaultPos = transform.position;
        ente = gameObject.GetComponent<Rigidbody>();
        //ente.AddForce(0, 0, speed, ForceMode.Impulse);
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        transform.rotation = obj_rot.transform.rotation;

       
       
    }

    void FixedUpdate()
    {
       
        //ente.AddRelativeForce(Vector3.forward * speed);
        
    }
    
    
}

