using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class finManager : MonoBehaviour
{
    public TextMeshProUGUI minBox;
    public TextMeshProUGUI secBox;
    public TextMeshProUGUI milliBox;
    public TextMeshProUGUI minBoxa;
    public TextMeshProUGUI secBoxa;
    public TextMeshProUGUI milliBoxa;
    public GameObject lapClock;
    public GameObject canvas;
   

    void OnTriggerEnter2D (){
       
        if(laptimeManager.sec<=9){
            secBox.text = "0" + laptimeManager.sec + ".";
            secBoxa.text = "0" + laptimeManager.sec + ".";
        }
        else{
             secBox.text = "" + laptimeManager.sec + ".";
               secBoxa.text = "" + laptimeManager.sec + ".";


        }
        if(laptimeManager.min<=9){
            minBox.text = "0" + laptimeManager.min + ".";
            minBoxa.text = "0" + laptimeManager.min + ".";
        }
        else{
             minBox.text = "" + laptimeManager.min + ".";
             minBoxa.text = "" + laptimeManager.min + ".";

        }
        milliBox.text = "" + laptimeManager.milli;
         milliBoxa.text = "" + laptimeManager.milli;

          PlayerPrefs.SetString("SecTextb", secBox.text);
        PlayerPrefs.SetString("MinTextb", minBox.text);
        PlayerPrefs.SetString("MilliTextb", milliBox.text);


         SceneManager.LoadScene(2);
       
    }

}
