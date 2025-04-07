using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageFromFireball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireBall();
        print("Player Health" + x);
        int y = TakeDamageFromFireBall(25);
        print("Player Health" + y);
        int z = TakeDamageFromFireBall(30,50);
        print("Player Health" + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int TakeDamageFromFireBall()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }

    int TakeDamageFromFireBall(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }

    int TakeDamageFromFireBall(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
}
