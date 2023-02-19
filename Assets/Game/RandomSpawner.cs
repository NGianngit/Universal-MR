using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform Spawner;
    public GameObject asteroidPrefab;

    public float xAxisPosition1 = -10;
    public float xAxisPosition2 = 11;

    public float yAxisPosition1 = 100;
    public float yAxisPosition2 = 100;

    public float zAxisPosition1 = -18;
    public float zAxisPosition2 = 7;

    public float asteroidSpeed;

    private IEnumerator randomSpawner;

    public int spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnAsteroids()
    {
        //vector 3 range of where objects are to be spawned
        Vector3 randomSpawnPosition = new Vector3(Random.Range(xAxisPosition1, xAxisPosition2), Random.Range(yAxisPosition1,yAxisPosition2), Random.Range(zAxisPosition1, zAxisPosition2));
        //multiply the objects to spawn and remain in the same orientation
        Instantiate(asteroidPrefab, randomSpawnPosition, Quaternion.identity);
        
        //Rigidbody rb = asteroidPrefab.GetComponent<Rigidbody>();

        //if (rb)
        //{
        //    Debug.Log("rigidbody detected");
        //    rb.AddForce(Spawner.forward * asteroidSpeed, ForceMode.Impulse);
        //}
        
    }

   
    IEnumerator level1()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTime);

            SpawnAsteroids();
            SpawnAsteroids();
        }
    }

    public void startSpawn()
    {
        if (randomSpawner != null)
            StopCoroutine(randomSpawner);

        randomSpawner = level1();
        StartCoroutine(randomSpawner);
    }

    public void StopSpawn()
    {
        StopCoroutine(randomSpawner);
    }
    // Update is called once per frame
}
