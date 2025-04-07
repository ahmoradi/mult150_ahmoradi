using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Vertical");
        float vVal = Input.GetAxis("Horizontal");
        if(hVal != 0)
        {
            print("horizontal move:" + hVal);
        }
        if(vVal != 0)
        {
            print("vertical move:" + vVal);
        }
    }
}
