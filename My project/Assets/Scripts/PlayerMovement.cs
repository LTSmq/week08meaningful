using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
     private InputAction WalkingAction;
     private Movement actions;

       private float moveSpeed = 7f; 
       private Vector3 playerDirection = new Vector3(0f, 0f, 0f);

    void Awake()
    {
        actions = new Movement();
        WalkingAction = actions.Walking.walking;
        UIManager.Get();
        ScoreKeeper.Get();
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
