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
    public GameObject hand;
    Vector3 defaultPos;

    // Start is called before the first frame update
    void Start()
    {
        defaultPos = transform.position;
        //ente = gameObject.GetComponent<Rigidbody>();
        //ente.AddForce(0, 0, speed, ForceMode.Impulse);
        
    }

    void Update()
    {
        if (hand.activeSelf)
        {
            //transform.Translate(Vector3.forward * speed/70);
            //transform.Translate(Vector3.up * Time.deltaTime, Space.World);

            Vector3 rot = obj_rot.transform.localRotation.eulerAngles;

            float rotation = rot.y -180f;

            //Debug.Log("rotation = " + rotation);
            transform.Rotate(Vector3.down, rotation * Time.deltaTime);
            transform.Translate(Vector3.forward * speed/70);
        }
    }

    void FixedUpdate()
    {

        //ente.AddRelativeForce(Vector3.forward * speed);
        //if (hand.activeSelf)
        //{
        //    ente.AddForce(Vector3.forward * speed / 70f );
        //}
    }

}

