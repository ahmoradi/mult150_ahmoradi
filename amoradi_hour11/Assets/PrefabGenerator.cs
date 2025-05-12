using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject LampPrefab;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            
            Instantiate(LampPrefab, transform.position+ new Vector3(i , 0, 0), transform.rotation);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(LampPrefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(LampPrefab, transform.position, transform.rotation);
        }
    }
}
