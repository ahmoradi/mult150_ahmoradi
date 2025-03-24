using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*print("Hello World!!!");
        Debug.Log("Goodbye World ");*/
        int health;
        health = 100;
        int potion = 20;
        health -= 30;
        Debug.Log("Health is" + health);
        health = health + potion;
        Debug.Log("potion is" + potion);
        print("hello");
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("Spam!!!");*/
    }
}
