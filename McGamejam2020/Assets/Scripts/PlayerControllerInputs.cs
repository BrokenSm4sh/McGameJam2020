using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerControllerInputs : MonoBehaviour
{
    private enum LastPressed
    {
        right,
        left,
        none = -1,
    }
    private ControllerStuff controls;

    private Vector2 move;

    [Range(1, 10)] public float speed;

    private float boost;
    private LastPressed prevButton;
    private bool rPressed;
    private bool lPressed;

    

    private void Awake()
    {
        prevButton = LastPressed.none;
        boost = speed;
        controls = new ControllerStuff();
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.performed += ctx => Debug.Log("moving");
        controls.Gameplay.Move.canceled += ctx => Debug.Log("move stop");

        controls.Gameplay.SpeedBoostL.canceled += ctx => LeftPress();
        controls.Gameplay.SpeedBoostR.canceled += ctx => RightPress();
    }

    void Update()
    {
        Vector3 m = new Vector3(5 * move.x, 0, 5 * move.y) * Time.deltaTime;
        //Source Nimso Ny
        Vector3 camF = Camera.main.transform.forward;
        Vector3 camR = Camera.main.transform.right;
        camF.y = 0;
        camR.y = 0;
        camF = camF.normalized;
        camR = camR.normalized;
        
       
        transform.position +=  (camF * move.y + camR * move.x) * (Time.deltaTime * boost);
        
        
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    private void LeftPress()
    {
        Debug.Log("l press");

        if (prevButton != LastPressed.left)
        {
            lPressed = true;
            prevButton = LastPressed.left;
        }
        else
        {
            lPressed = false;
        }
        if (lPressed && rPressed)
        {
            lPressed = false;
            rPressed = false;
            boost = 10 * speed;
            Debug.Log("BOOST");
            StartCoroutine(DecreaseBoost());

        }
        else
        {
            boost = speed;
        }
    }
    private void RightPress()
    {
        Debug.Log("r press");
        if (prevButton != LastPressed.right)
        {
            rPressed = true;
            prevButton = LastPressed.right;
        }
        else
        {
            rPressed = false;
        }
        if (lPressed && rPressed)
        {
            lPressed = false;
            rPressed = false;
            boost = 10 * speed;
            Debug.Log("BOOST");
            StartCoroutine(DecreaseBoost());
        }
        else
        {
            boost = speed;
        }
    }

    public IEnumerator DecreaseBoost()
    {
        while (boost >= speed)
        {
            boost -= boost*speed/60;
            yield return null;
        }

        if (boost < speed)
        {
            boost = speed;
        }
    }
}