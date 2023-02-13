using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public Transform Spawner;
    public float asteroidSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = asteroidPrefab.GetComponent<Rigidbody>();

        if (rb)
        {
            Debug.Log("rigidbody detected");
            rb.AddForce(Spawner.forward * asteroidSpeed, ForceMode.Impulse);
        }
    }
}
