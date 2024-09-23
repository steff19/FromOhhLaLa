using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
   
 [SerializeField] GameObject playerOne;
  [SerializeField] float camZPos = -20f;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerOne.transform.position + new Vector3(0,0,camZPos);
    }
}
