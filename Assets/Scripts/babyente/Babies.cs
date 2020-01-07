using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Babies : MonoBehaviour
{
    public List<GameObject> babies;

    private int activeBabies = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach( GameObject obj in babies)
        {
            obj.SetActive(false);
        }
    }

    public void activateBaby()
    {
        if (activeBabies >= babies.Count)
            return;

        babies[activeBabies].SetActive(true);
        activeBabies++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
