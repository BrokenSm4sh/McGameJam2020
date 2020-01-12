using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerInputs : MonoBehaviour
{
    private ControllerStuff controls;
    
    private Vector2 move;
    
    

    private bool rPressed;
    private bool lPressed;
    private enum LastPressed
    {
        right,
        left
    }
    
    private void Awake()
    {
        controls = new ControllerStuff();
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx  => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.performed += ctx => Debug.Log("moving");
        controls.Gameplay.Move.canceled += ctx => Debug.Log("move stop");

        controls.Gameplay.SpeedBoostL.performed += ctx => lPressed = true;

    }

    void Update()
    {
        Vector3 m = new Vector3(5*move.x,0,5*move.y) * Time.deltaTime;
        transform.Translate(m,Space.World);
        if (lPressed && rPressed)
        {
            
        }
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
    
}
