using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class laptimeManager : MonoBehaviour
{
    public static int min ;
    public static int sec;
    public static float milli ;
    public static string lapDisplay;
     public GameObject triggerA;
    public GameObject triggerB;

    public TextMeshProUGUI minBox;
    public TextMeshProUGUI secBox;
    public TextMeshProUGUI milliBox;

    void Start(){
        min = 0;
        sec=0;
        milli=0f;
        triggerA.SetActive(false);
         triggerB.SetActive(false);
    }
    // Update is called once per frame

    void Update()
    {
        milli += Time.deltaTime * 10;
        lapDisplay = milli.ToString("F0");
        milliBox.text = "" + lapDisplay;

        if(milli >=10){
            milli = 0;
            sec +=1;
        }
        if(sec<=9){
            secBox.text = "0" + sec + ".";
        }
        else{
             secBox.text = "" + sec + ".";

        }
          if(sec >=60){
            sec = 0;
            min +=1;
        }
        if(min<=9){
            minBox.text = "0" + min + ".";
        }
        else{
             minBox.text = "" + min + ".";

        } 
    }
}
