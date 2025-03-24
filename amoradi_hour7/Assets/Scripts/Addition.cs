using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int a = 2, b = 4, c = 8;
        int sum;
        sum = a + b + c;
        sum += 1;
        Debug.Log("The sum is " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
