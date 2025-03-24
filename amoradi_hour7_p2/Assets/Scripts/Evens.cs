using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int even = 20;
        while (even<100)
        {
            even = even + 2;
            print(even);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
