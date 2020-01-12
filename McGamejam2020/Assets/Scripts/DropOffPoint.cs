using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOffPoint : MonoBehaviour
{
    public GameObject player;
    public float DROP_OBJECT_DISTANCE;
    public float DROP_OBJECT_UI_Y_OFFSET;
    public GameObject dropObjectUIPrefab;
    private GameObject dropObjectUIInstance;
    private bool dropMsgSet = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject pickedUpCollec = GameObject.FindGameObjectWithTag("pickedUpCollectable");
        if (pickedUpCollec != null &&
            Vector3.Distance(transform.position,
            pickedUpCollec.transform.position) <= DROP_OBJECT_DISTANCE){

            if (dropMsgSet == false) {
                pickedUpCollec.transform.GetChild(0)
                    .gameObject.GetComponent<CollectableUIController>().prepareDrop();
                dropMsgSet = true;
            }
            
        } else {
            if (dropMsgSet == true) {
                pickedUpCollec.transform.GetChild(0)
                    .gameObject.GetComponent<CollectableUIController>().cancelDrop();
                dropMsgSet = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            pickedUpCollec.GetComponent<CollectableController>()
                .drop((gameObject.transform.position + pickedUpCollec.transform.position) / 2f);
        }
    }
}
