using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroids : MonoBehaviour
{
    public Astroids astroids;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Destroy(gameObject);
            astroids.AsteroidDodged();
        }

        if (collision.gameObject.tag == "ship")
        {
            Destroy(gameObject);
            astroids.GameEnd();
        }
    }
}
