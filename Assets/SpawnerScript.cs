using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject humanPrefab;

    public float timeBetweenSpawn;
    float timeSinceLastSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceLastSpawn < Time.time)
        {
            timeSinceLastSpawn = Time.time + timeBetweenSpawn;
            Instantiate(humanPrefab, transform.position, transform.rotation);
        }
    }
}
