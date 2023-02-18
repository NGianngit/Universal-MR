using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizScoreManager : MonoBehaviour
{
    public TextMeshProUGUI totalScoreShow;

    public static int MercuryScore;
    public static int VenusScore;
    public static int EarthScore;
    public static int MarsScore;
    public static int JupiterScore;
    public static int SaturnScore;
    public static int UranusScore;
    public static int NeptuneScore;
    public static int SolarSystemScore;
    public int Quizscore;

    public int mercuryScore;
    public int venusScore;
    public int earthScore;
    public int marsScore;
    public int jupiterScore;
    public int saturnScore;
    public int uranusScore;
    public int neptuneScore;
    public int solarSystemScore;

    public static int TotalScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TotalScore = MercuryScore + VenusScore + EarthScore + MarsScore + JupiterScore + SaturnScore + UranusScore + NeptuneScore + SolarSystemScore;
        //Debug.Log(TotalScore);
        mercuryScore = MercuryScore;
        venusScore = VenusScore;
        earthScore = EarthScore;
        marsScore = MarsScore;
        jupiterScore = JupiterScore;
        saturnScore = SaturnScore;
        uranusScore = UranusScore;
        neptuneScore = NeptuneScore;
        solarSystemScore = SolarSystemScore;
        totalScoreShow.text = TotalScore.ToString();
    }

    //change quiz score to planet score
    public void AddMercuryScore()
    {
        MercuryScore = Quizscore;
        Debug.Log(MercuryScore);
    }
    public void AddVenusScore()
    {
        VenusScore = Quizscore;
        Debug.Log(VenusScore);
    }
    public void AddEarthScore()
    {
        EarthScore = Quizscore;
        Debug.Log(EarthScore);
    }
    public void AddMarsScore()
    {
        MarsScore = Quizscore;
        Debug.Log(MarsScore);
    }
    public void AddJupiterScore()
    {
        JupiterScore = Quizscore;
        Debug.Log(JupiterScore);
    }
    public void AddSaturnScore()
    {
        SaturnScore = Quizscore;
        Debug.Log(SaturnScore);
    }
    public void AddUranusScore()
    {
        UranusScore = Quizscore;
        Debug.Log(UranusScore);
    }
    public void AddNeptuneScore()
    {
        NeptuneScore = Quizscore;
        Debug.Log(NeptuneScore);
    }
    public void AddSolarSystemScore()
    {
        SolarSystemScore = Quizscore;
        Debug.Log(SolarSystemScore);
    }


    public void ShowTotalScore()
    {
        if ( (MercuryScore > 0) && (VenusScore > 0) && (EarthScore > 0) && (MarsScore > 0) && (SaturnScore > 0) && (JupiterScore > 0) && (UranusScore > 0) && (NeptuneScore > 0) && (SolarSystemScore > 0) )
        {
            Debug.Log(TotalScore);
            totalScoreShow.text = TotalScore.ToString();
        }
    }

}
