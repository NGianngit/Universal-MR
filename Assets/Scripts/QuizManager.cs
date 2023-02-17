using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    // call the score manager
    public QuizScoreManager quizScoreManager;
    public int whichQuiz;
    /// <summary>
    /// calling list from QuestionAndAnswers script
    /// </summary>
    public List<QuestionsAndAnswers> QnA;

    /// <summary>
    /// the answer options
    /// </summary>
    public GameObject[] options;

    /// <summary>
    /// the current qn the user is on
    /// </summary>
    public int currentQuestions;

    /// <summary>
    /// reference to questions text
    /// </summary>
    public TMP_Text QuestionText;

    /// <summary>
    /// variables for gameover panel
    /// </summary>
    public GameObject QuizPanel;
    public GameObject GoPanel;

    /// <summary>
    /// Variable for number of questions in the quiz
    /// </summary>
    int totalQuestions = 0;

    /// <summary>
    /// display score txt
    /// </summary>
    public TMP_Text ScoreTxt;

    /// <summary>
    /// score count variable
    /// </summary>
    public int score;
    private void Start()
    {
        totalQuestions = QnA.Count;
        //GoPanel.SetActive(false);
        //QuizPanel.SetActive(true);
        //generateQuestions();
    }

    public void StartQuiz()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        QuizPanel.SetActive(true);
        generateQuestions();
        currentQuestions = 0;
        score = 0;
    }

    public void Update()
    {
        ScoreTxt.text = score.ToString();
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GameOver()
    {
        GoPanel.SetActive(true);
        QuizPanel.SetActive(false);
        ScoreTxt.text = score + "/" + totalQuestions;
        AddQuizScore();

        
    }
    /// <summary>
    /// remove previous qn and put the 
    /// </summary>
    public void correct()
    {   
        /// add score when correct
        score += 1;
        QnA.RemoveAt(currentQuestions);
        generateQuestions();
    }
    public void wrong()
    {   
        /// move on to next question when wrong
        QnA.RemoveAt(currentQuestions);
        generateQuestions();
    }
    /// <summary>
    /// Check if answer is correct 
    /// </summary>
    void SetAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestions].Answers[i];
           
            if(QnA[currentQuestions].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    /// <summary>
    /// randomly generate the questions based on the questions available
    /// </summary>
    void generateQuestions()
    {
        if (QnA.Count > 0)
        {
            /// Random number from 0 to the total number to questions 
            currentQuestions = Random.Range(0, QnA.Count);

            QuestionText.text = QnA[currentQuestions].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Quesstions");
            GameOver();

        }
    }

    public void AddQuizScore()
    {
        if (whichQuiz == 1)
        {
            if (score > quizScoreManager.mercuryScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddMercuryScore();
            }
        }
        if (whichQuiz == 2)
        {
            if (score > quizScoreManager.venusScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddVenusScore();
            }
        }
        if (whichQuiz == 3)
        {
            if (score > quizScoreManager.earthScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddEarthScore();
            }
        }
        if (whichQuiz == 4)
        {
            if (score > quizScoreManager.marsScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddMarsScore();
            }
        }
        if (whichQuiz == 5)
        {
            if (score > quizScoreManager.jupiterScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddJupiterScore();
            }
        }
        if (whichQuiz == 6)
        {
            if (score > quizScoreManager.saturnScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddSaturnScore();
            }
        }
        if (whichQuiz == 7)
        {
            if (score > quizScoreManager.uranusScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddUranusScore();
            }
        }

        if (whichQuiz == 8)
        {
            if (score > quizScoreManager.neptuneScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddNeptuneScore();
            }
        }

        if (whichQuiz == 9)
        {
            if (score > quizScoreManager.solarSystemScore)
            {
                quizScoreManager.Quizscore = score;
                quizScoreManager.AddSolarSystemScore();
            }
        }
    }
}
