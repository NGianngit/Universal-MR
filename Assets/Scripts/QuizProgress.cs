using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizProgress : MonoBehaviour
{
    public PlanetLock MercuryLock;
    public PlanetLock VenusLock;
    public PlanetLock EarthLock;
    public PlanetLock MarsLock;
    public PlanetLock JupiterLock;
    public PlanetLock SaturnLock;
    public PlanetLock UranusLock;
    public PlanetLock NeptuneLock;

    public static int QuizCounter;
    public TextMeshProUGUI quizCount;
    public GameObject solarSystemQuiz;
    //public int QuizCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        quizCount.text = QuizCounter.ToString();

        if (QuizCounter <= 1)
        {
            MercuryLock.isUnlock = true;
        }

        if (QuizCounter == 2)
        {
            MercuryLock.isUnlock = true;
            VenusLock.isUnlock = true;
        }

        if (QuizCounter == 3)
        {
            MercuryLock.isUnlock = true;
            VenusLock.isUnlock = true;
            EarthLock.isUnlock = true;
        }

        if (QuizCounter == 4)
        {
            MercuryLock.isUnlock = true;
            VenusLock.isUnlock = true;
            EarthLock.isUnlock = true;
            MarsLock.isUnlock=true;
        }

        if (QuizCounter == 5)
        {
            MercuryLock.isUnlock = true;
            VenusLock.isUnlock = true;
            EarthLock.isUnlock = true;
            MarsLock.isUnlock = true;
            JupiterLock.isUnlock = true;
        }

        if (QuizCounter == 6)
        {
            MercuryLock.isUnlock = true;
            VenusLock.isUnlock = true;
            EarthLock.isUnlock = true;
            MarsLock.isUnlock = true;
            JupiterLock.isUnlock = true;
            SaturnLock.isUnlock = true;
        }

        if (QuizCounter == 7)
        {
            MercuryLock.isUnlock = true;
            VenusLock.isUnlock = true;
            EarthLock.isUnlock = true;
            MarsLock.isUnlock = true;
            JupiterLock.isUnlock = true;
            SaturnLock.isUnlock = true;
            UranusLock.isUnlock = true;
        }

        if (QuizCounter == 8)
        {
            MercuryLock.isUnlock = true;
            VenusLock.isUnlock = true;
            EarthLock.isUnlock = true;
            MarsLock.isUnlock = true;
            JupiterLock.isUnlock = true;
            SaturnLock.isUnlock = true;
            UranusLock.isUnlock = true;
            NeptuneLock.isUnlock = true;
        }

        if (QuizCounter == 9)
        {
            MercuryLock.isUnlock = true;
            VenusLock.isUnlock = true;
            EarthLock.isUnlock = true;
            MarsLock.isUnlock = true;
            JupiterLock.isUnlock = true;
            SaturnLock.isUnlock = true;
            UranusLock.isUnlock = true;
            NeptuneLock.isUnlock = true;
            solarSystemQuiz.SetActive(true);
        }




    }

    public void MercuryComplete()
    {
        if (QuizCounter < 2)
        {

            QuizCounter = 2;
        }
    }
    public void VenusComplete()
    {
        if (QuizCounter < 3)
        {

            QuizCounter = 3;
        }
    }
    public void EarthComplete()
    {
        if (QuizCounter < 4)
        {

            QuizCounter = 4;
        }
    }
    public void MarsComplete()
    {
        if (QuizCounter < 5)
        {

            QuizCounter = 5;
        }
    }
    public void JupiterComplete()
    {
        if (QuizCounter < 6)
        {

            QuizCounter = 6;
        }
    }
    public void SaturnComplete()
    {
        if (QuizCounter < 7)
        {

            QuizCounter = 7;
        }
    }
    public void UranusComplete()
    {
        if (QuizCounter < 8)
        {

            QuizCounter = 8;
        }
    }
    public void NeptuneComplete()
    {
        if (QuizCounter < 9)
        {

            QuizCounter = 9;
        }
    }

    public void DevUnlock()
    {
        QuizCounter = 9;
    }

}
