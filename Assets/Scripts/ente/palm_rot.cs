using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palm_rot : Detector
{
    palm_rotation rot;
    GameObject palm;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Translate(1, 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //float roll = palm.palmNormal().roll();
    }
}
