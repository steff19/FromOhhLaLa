using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endDisplay : MonoBehaviour
{
    public string score ,scoreb, scorec, scorex, scorey, scorez, score1, score2, score3, scorea, scoreaa, scoreaaa;
    public TextMeshProUGUI  scoreBox;
    public TextMeshProUGUI  scoreBoxa;
    public TextMeshProUGUI  scoreBoxb;
    public TextMeshProUGUI minBox;
    public TextMeshProUGUI secBox;
    public TextMeshProUGUI milliBox;
    public TextMeshProUGUI minBoxa;
    public TextMeshProUGUI secBoxa;
    public TextMeshProUGUI milliBoxa;
    public TextMeshProUGUI minBoxab;
    public TextMeshProUGUI secBoxab;
    public TextMeshProUGUI milliBoxab;
    // Start is called before the first frame update
    void Start()
    {
        scorex = PlayerPrefs.GetString("SecTextaa");
        secBox.text = scorex;
        scorey = PlayerPrefs.GetString("MinTextaa");
        minBox.text = scorey;
        scorez = PlayerPrefs.GetString("MilliTextaa");
        milliBox.text = scorez;

         score1 = PlayerPrefs.GetString("SecTexta");
        secBoxa.text = score1;
        score2 = PlayerPrefs.GetString("MinTexta");
        minBoxa.text = score2;
        score3 = PlayerPrefs.GetString("MilliTexta");
        milliBoxa.text = score3;

         scorea = PlayerPrefs.GetString("SecTextb");
        secBoxab.text = scorea;
        scoreaa = PlayerPrefs.GetString("MinTextb");
        minBoxab.text = scoreaa;
        scoreaaa = PlayerPrefs.GetString("MilliTextb");
        milliBoxab.text = scoreaaa;

         score = PlayerPrefs.GetString("MinTextb");
         scoreBox.text = score;
        scoreb = PlayerPrefs.GetString("SecTextb");
       scoreBoxa.text = scoreb;
        scorec = PlayerPrefs.GetString("MilliTextb");
        scoreBoxb.text = scorec;
    }

  
}
