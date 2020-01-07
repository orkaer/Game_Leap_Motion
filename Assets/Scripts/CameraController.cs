using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject ente;
    private Vector3 m_offset;
    // Start is called before the first frame update
    void Start()
    {
        m_offset = gameObject.transform.position - ente.transform.position;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        gameObject.transform.position = ente.transform.position + m_offset;
    }
}