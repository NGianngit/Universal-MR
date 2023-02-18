using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOption : MonoBehaviour
{

    public static int quizOption;

    public int chooseQuizOption;

    public GameObject MercuryQuiz;
    public GameObject VenusQuiz;
    public GameObject EarthQuiz;
    public GameObject MarsQuiz;
    public GameObject JupiterQuiz;
    public GameObject SaturnQuiz;
    public GameObject UranusQuiz;
    public GameObject NeptuneQuiz;
    public GameObject SolarSystemQuiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (quizOption == 1)
        {
            MercuryQuiz.SetActive(true);
        }
        if (quizOption == 2)
        {
            VenusQuiz.SetActive(true);
        }
        if (quizOption == 3)
        {
            EarthQuiz.SetActive(true);
        }
        if (quizOption == 4)
        {
            MarsQuiz.SetActive(true);
        }
        if (quizOption == 5)
        {
            JupiterQuiz.SetActive(true);
        }
        if (quizOption == 6)
        {
            SaturnQuiz.SetActive(true);
        }
        if (quizOption == 7)
        {
            UranusQuiz.SetActive(true);
        }
        if (quizOption == 8)
        {
            NeptuneQuiz.SetActive(true);
        }
        if (quizOption == 9)
        {
            SolarSystemQuiz.SetActive(true);
        }
    }

    public void SetQuiz()
    {
        quizOption = chooseQuizOption;
    }
}
