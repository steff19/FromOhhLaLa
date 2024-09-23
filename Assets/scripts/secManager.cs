using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class secManager : MonoBehaviour
{
  
    public GameObject trigger;
    public TextMeshProUGUI minBox;
    public TextMeshProUGUI secBox;
    public TextMeshProUGUI milliBox;

    void OnTriggerEnter2D (){
        if(laptimeManager.sec<=9){
            secBox.text = "0" + laptimeManager.sec + ".";
        }
        else{
             secBox.text = "" + laptimeManager.sec + ".";

        }
        if(laptimeManager.min<=9){
            minBox.text = "0" + laptimeManager.min + ".";
        }
        else{
             minBox.text = "" + laptimeManager.min + ".";

        }
        milliBox.text = "" + laptimeManager.milli;
        trigger.SetActive(true);

         // Save laptime text values to PlayerPrefs if they are different from the previous stored values
        PlayerPrefs.SetString("SecTexta", secBox.text);
        PlayerPrefs.SetString("MinTexta", minBox.text);
        PlayerPrefs.SetString("MilliTexta", milliBox.text);
    }
}
