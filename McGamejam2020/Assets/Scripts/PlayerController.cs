using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public delegate void CollectableAction();
    public static event CollectableAction onPickUp;
    public static event CollectableAction onPutDown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            onPickUp();
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            onPutDown();
        }
    }
}
