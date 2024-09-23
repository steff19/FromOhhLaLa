using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

public class carMove : MonoBehaviour
{
    [SerializeField] private InputActionReference steer;
    [SerializeField] float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerDir = steer.action.ReadValue<Vector2>().x * moveSpeed * Time.deltaTime;
        float moveDir = steer.action.ReadValue<Vector2>().y * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerDir);
        transform.Translate(0, moveDir, 0);
    }
}



/*  float steerVal = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; 
        transform.Rotate(0,0,-steerVal);
        transform.Translate(0,moveVal,0);
         */
