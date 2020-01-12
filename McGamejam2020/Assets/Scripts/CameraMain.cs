using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMain : MonoBehaviour
{
    public GameObject subject;


    private bool up = true;
    private float threshold = 0;

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
    }

    // Update is called once per frame
    void Update()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.RotateAround(subject.gameObject.transform.position,new Vector3(0,1,0),1f);
            transform.RotateAround(subject.transform.position, new Vector3(0, 0.5f, 0), 1);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.RotateAround(subject.gameObject.transform.position,new Vector3(0,1,0),1f);
            transform.RotateAround(subject.transform.position, new Vector3(0, -0.5f, 0), 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.RotateAround(subject.gameObject.transform.position,new Vector3(0,1,0),1f);
           // transform.RotateAround(subject.transform.position, new Vector3(0, 0, -0.5f), 1);
            transform.Translate(new Vector3(0, -0.5f,0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.RotateAround(subject.gameObject.transform.position,new Vector3(0,1,0),1f);
            // transform.RotateAround(subject.transform.position, new Vector3(0, 0, 0.5f), 1);
            transform.Translate(new Vector3(0, 0.5f,0));
        }
        else
        {
            // transform.position = subject.transform.position + offset;
        }
        transform.LookAt(subject.transform, Vector3.up);

    }
}
