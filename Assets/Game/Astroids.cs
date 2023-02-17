using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Astroids : MonoBehaviour
{
    public DestroyAsteroids destroyAsteroids;
    public RandomSpawner spawner;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI asteroidCount;
    

    private float startTime = 0;
    public float Tpassed;
    //private string hours;
    private string minutes;
    private string seconds;
    public bool gameOver = true;

    public int asteroidPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)

            return;


        //Timer in minutes and seconds
        Tpassed = Time.time - startTime;
        //hours = ((int)Tpassed / 3600).ToString();
        minutes = ((int)Tpassed % 3600 / 60).ToString();
        seconds = ((int)Tpassed % 60).ToString();
        timer.text = minutes + "min" + seconds + "sec";

        asteroidCount.text = asteroidPoints.ToString();
    }

    public void GameStart()
    {
        startTime = Time.time;
        gameOver = false;
        Tpassed = 0;
        spawner.startSpawn();
        timer.color = Color.white;
        asteroidPoints = 0;

    }

    public void GameEnd()
    {
        gameOver = true;
        timer.color = Color.red;
        asteroidPoints = 0;
        spawner.StopSpawn();
    }

    public void AsteroidDodged()
    {
        asteroidPoints++;
    }
}
