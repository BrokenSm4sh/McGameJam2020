using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{

    public float MAX_SPEED;
    public float VELOCIT_LERP_INCREMENT = 0.1f;
    private float velocityLerpTime;

    public float MAX_TURN_SPEED;
    public float ROTATION_LERP_STEP = 0.1f;
    private char lastPressedKey = ' ';
    private char curPressedKey = ' ';

    private Quaternion targetRotation;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) {
            curPressedKey = 'L';
            velocityLerpTime = 0;
        } else if (Input.GetKeyDown(KeyCode.C)) {
            curPressedKey = 'R';
            velocityLerpTime = 0;
        } else {
            curPressedKey = ' ';
        }

        if (curPressedKey != lastPressedKey && curPressedKey != ' ') {
            // get input direction
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            //
            // Debug.Log("Horizontal: " + Input.GetAxis("Horizontal"));
            // Debug.Log("Vertical: " + Input.GetAxis("Vertical"));

            // Vector3 direction = new Vector3(
            //     (horizontalInput + Camera.main.transform.forward.x * 2f), 
            //     0, 
            //     (verticalInput + Camera.main.transform.right.z * 2f));
            Vector3 direction = Vector3.zero;
            if (horizontalInput < 0)
            {
                 direction += -Camera.main.transform.right;
            }
            if (horizontalInput > 0)
            {
                 direction += Camera.main.transform.right;
            }
            if (verticalInput < 0)
            {
                 direction += -Camera.main.transform.forward;
            }
            if (verticalInput > 0)
            {
                 direction += Camera.main.transform.forward;
            }
            
                
            
            
            rb.velocity = direction;
            

            // update lastPressedKey
            lastPressedKey = curPressedKey;
        }

        // SmoothStep Velocity
        if (velocityLerpTime <= 1f) {
            rb.velocity *= Mathf.SmoothStep(MAX_SPEED, 0, velocityLerpTime);
            // Debug.Log("SmoothStep: " + Mathf.SmoothStep(MAX_SPEED, 0, velocityLerpTime));
            velocityLerpTime += VELOCIT_LERP_INCREMENT;
        } else {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (rb.velocity != Vector3.zero) {    
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(rb.velocity.normalized), ROTATION_LERP_STEP);
        }

        // Lerp Rotation
        //if (rotationLerpTime != 1f) {
        //gameObject.transform.rotation = Quaternion.Slerp(targetRotation,
        //gameObject.transform.rotation, rotationLerpTime);
        //rotationLerpTime += ROTATION_LERP_INCREMENT;
        //}


    }
}
