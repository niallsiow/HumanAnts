using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanBehaviour : MonoBehaviour
{

    Rigidbody rigidbody;


    float xSpeed;
    float zSpeed;

    public float timeBurnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        xSpeed = Random.Range(0.3f, 5f);
        zSpeed = Random.Range(0.3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector3(xSpeed, 0, zSpeed);
    }
    
}
