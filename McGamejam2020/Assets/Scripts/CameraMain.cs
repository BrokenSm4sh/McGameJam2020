using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMain : MonoBehaviour
{
    public GameObject subject;

    public ControllerStuff controls;
    private Vector2 move;

    private bool up = true;
    private float threshold = 0;

    public Vector3 offset;

    // Use this for initialization
    void Awake()
    {
        controls = new ControllerStuff();

        controls.Gameplay.MoveCamera.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.MoveCamera.canceled += ctx => move = ctx.ReadValue<Vector2>();;
        controls.Gameplay.MoveCamera.canceled += ctx => transform.LookAt(subject.transform, Vector3.up);
        ;
        controls.Gameplay.MoveCamera.performed += ctx => Debug.Log("moving");
        controls.Gameplay.MoveCamera.canceled += ctx => Debug.Log("move stop");
        transform.position = subject.transform.position + offset;

    }
    
    
    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.RotateAround(subject.transform.position, new Vector3(0, -move.x, 0), 1);
        
        // if (transform.position.y >= 2.3)
        // {
        //     transform.position = (new Vector3(transform.position.x, 2.3f,transform.position.z ));
        // }
        // if (transform.position.y <= 0)
        // {
        //     transform.position = (new Vector3(transform.position.x, 0.5f,transform.position.z ));
        //
        // }
        transform.Translate(new Vector3(0, move.y, 0));

        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.

        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     //transform.RotateAround(subject.gameObject.transform.position,new Vector3(0,1,0),1f);
        //     transform.RotateAround(subject.transform.position, new Vector3(0, 0.5f, 0), 1);
        // }
        //
        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     //transform.RotateAround(subject.gameObject.transform.position,new Vector3(0,1,0),1f);
        //     transform.RotateAround(subject.transform.position, new Vector3(0, -0.5f, 0), 1);
        // }
        //
        // if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     //transform.RotateAround(subject.gameObject.transform.position,new Vector3(0,1,0),1f);
        //     // transform.RotateAround(subject.transform.position, new Vector3(0, 0, -0.5f), 1);
        //     transform.Translate(new Vector3(0, -0.5f, 0));
        // }
        //
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //     //transform.RotateAround(subject.gameObject.transform.position,new Vector3(0,1,0),1f);
        //     // transform.RotateAround(subject.transform.position, new Vector3(0, 0, 0.5f), 1);
        //     transform.Translate(new Vector3(0, 0.5f, 0));
        // }
        // else
        // {
        //     // transform.position = subject.transform.position + offset;
        // }
        
         transform.LookAt(subject.transform, Vector3.up);
        // Vector3 m = new Vector3(5 * move.x, 0, 5 * move.y) * Time.deltaTime;
        // transform.Translate(m);
    }
    
    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    private void CameraUpDown(InputAction.CallbackContext ctx)
    {
        
        
        
    }
}