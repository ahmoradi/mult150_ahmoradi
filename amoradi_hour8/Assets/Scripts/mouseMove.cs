using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXvalue = Input.GetAxis("Mouse X");
        float mouseYvalue = Input.GetAxis("Mouse Y");
        if (mouseXvalue != 0)
        {
            print("My x mouse movement is" + mouseXvalue);
        }
        if (mouseYvalue != 0)
        {
            print("My y mouse movement is" + mouseYvalue);
        }
    }
}
