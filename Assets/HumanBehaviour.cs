using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanBehaviour : MonoBehaviour
{

    public GameObject deadBodyPrefab;
    public GameObject smokePrefab;

    Rigidbody rigidbody;


    float xSpeed;
    float zSpeed;

    float DeathCounter = 0;
    public float timeToKill;
    public float timeToDie;
    public float timeBurnt = 0;

    bool dead = false;

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
        rigidbody.velocity = transform.forward * xSpeed;

        if (!dead && timeBurnt > timeToKill)
        {
            xSpeed += 12f;

            dead = true;
        }

        if (dead)
        {
            gameObject.transform.Find("Fire").gameObject.SetActive(true);
            DeathCounter += Time.deltaTime;
        }

        if(DeathCounter > timeToDie)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deadBodyPrefab, transform.position - new Vector3(0, 2f, 0), transform.rotation);
        Instantiate(smokePrefab, transform.position, smokePrefab.transform.rotation);
        Destroy(gameObject);
    }
}
