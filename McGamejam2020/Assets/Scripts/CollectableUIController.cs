using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableUIController : MonoBehaviour
{
    private GameObject camera;
    private GameObject player;
    private GameObject nearbyPrompt;
    private GameObject positionInticator;

    public float pickUpAvailableDistance;

    [HideInInspector]
    public bool isPickedUp = false;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindGameObjectWithTag("Player");

        nearbyPrompt = gameObject.transform.GetChild(0).gameObject;
        positionInticator = gameObject.transform.GetChild(1).gameObject;

        // reference event camera
        gameObject.GetComponent<Canvas>().worldCamera =
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);

        // check if player within proximity
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= pickUpAvailableDistance
            && !isPickedUp) {
            // set nearbyPrompt  to be active
            nearbyPrompt.GetComponent<Text>().text = "E to Pick Up";
            nearbyPrompt.SetActive(true);
            positionInticator.SetActive(false);

        } else if (!isPickedUp) {
            // set position indicator to be active 
            nearbyPrompt.SetActive(false);
            positionInticator.SetActive(true);
        }
    }

    public void prepareDrop() {
        nearbyPrompt.GetComponent<Text>().text = "R to put down";
    }

    public void cancelDrop() {
        nearbyPrompt.GetComponent<Text>().text = " ";
    }

    
}
