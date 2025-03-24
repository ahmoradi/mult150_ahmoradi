using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int birthday = 28;
        for (int i =1; i<=31; i++)
        {
            print(i);
            if (i==birthday)
            {
                print("It's my birthday!!!!!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
