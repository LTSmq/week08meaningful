using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
     private InputAction WalkingAction;
     private PlayerActivity actions;

       private float moveSpeed = 7f; 
       private Vector3 playerDirection = new Vector3(0f, 0f, 0f);

    void Awake()
    {
        actions = new PlayerActivity();
        WalkingAction = actions.Walking.walking;
    }

    void OnEnable()
    {
        WalkingAction.Enable();
    }

    void OnDisable()
    {
        WalkingAction.Disable();
    } 


    // Update is called once per frame
    void Update()
    {
        playerDirection = WalkingAction.ReadValue<Vector3>(); 
        transform.Translate(playerDirection.normalized * Time.deltaTime * moveSpeed, Space.Self); 
    }
}
