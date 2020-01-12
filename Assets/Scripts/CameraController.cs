using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
<<<<<<< Updated upstream
    [SerializeField] private GameObject ente;
=======
    [SerializeField] private GameObject m_playerObject;
>>>>>>> Stashed changes
    private Vector3 m_offset;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        m_offset = gameObject.transform.position - ente.transform.position;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        gameObject.transform.position = ente.transform.position + m_offset;
    }
}
=======
        m_offset = gameObject.transform.position - m_playerObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = m_playerObject.transform.position + m_offset;
    }
}
>>>>>>> Stashed changes
