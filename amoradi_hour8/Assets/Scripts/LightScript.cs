using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightStatus;
    bool onstatus = false;
    // Start is called before the first frame update
    void Start()
    {
        lightStatus = GetComponent<Light>();
        lightStatus.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.L))
        {
            lightStatus.enabled = onstatus;
            onstatus = !onstatus;
        }
    }
}
