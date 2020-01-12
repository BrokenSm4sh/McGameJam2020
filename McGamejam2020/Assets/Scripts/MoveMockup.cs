using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMockup : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rgbd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("w");
            rgbd.velocity += 40 *Camera.main.transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("a");
            rgbd.velocity += -40*Camera.main.transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("s");
            rgbd.velocity += -30*Camera.main.transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("d");
            rgbd.velocity += 40*Camera.main.transform.right;
        }
    }
}
