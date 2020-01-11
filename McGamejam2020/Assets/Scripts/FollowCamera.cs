using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
    // fields for camera movement;
    public GameObject player;
    public float rotSpeed;

    Transform cameraTrfm;
    Transform playerTrfm;

    Vector3 offset = new Vector3();

    // Start is called before the first frame update
    void Start() {
        // get references
        playerTrfm = player.GetComponent<Transform>();

        cameraTrfm = GetComponent<Transform>();

        // get initial offset
        offset = cameraTrfm.position - player.transform.position;
    }

    // Update is called once per frame
    void Update() {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, rotX);
        transform.Rotate(Vector3.right, -rotY);
    }

    private void LateUpdate() {
        cameraTrfm.position = player.transform.position + offset;
    }

}