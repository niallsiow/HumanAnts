using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightConeScript : MonoBehaviour
{

    public GameObject deadBodyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider otherCollider)
    {
        if (otherCollider.tag == "Human")
        {
            otherCollider.GetComponent<HumanBehaviour>().timeBurnt += Time.deltaTime;
        }
    }
}
