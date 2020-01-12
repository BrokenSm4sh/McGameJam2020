﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableController : MonoBehaviour
{
    public GameObject player;
    public float CollectableZOffsetFromPlayer;

    public float PICK_UP_RADIUS;

    public float pickUpUIYOffset;
    public GameObject pickupUIPrefab;
    private GameObject pickupUIInstance;


    // Start is called before the first frame update
    void Start()
    {
        // spawn pickUp UI
        pickupUIInstance = Instantiate(pickupUIPrefab,
            new Vector3(transform.position.x, 
            transform.position.y + pickUpUIYOffset, 
            transform.position.z), 
            Quaternion.identity,
            gameObject.transform);

    }

    // Update is called once per frame
    void Update()
    {
        // if player within pick up radius, change tag to okToPickUp
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= PICK_UP_RADIUS) {
            if (gameObject.tag != "pickedUpCollectable") {
                gameObject.tag = "okToPickUp";
            }
            
        } 
    }

    // handle collision with player
    public void pickUp() {
        gameObject.transform.SetParent(player.transform);
        gameObject.transform.position = new Vector3(
            player.transform.position.x,
            player.transform.position.y,
            player.transform.position.z + CollectableZOffsetFromPlayer);
        gameObject.tag = "pickedUpCollectable";
        pickupUIInstance.GetComponent<CollectableUIController>().isPickedUp = true;
        pickupUIInstance.transform.GetChild(0).gameObject
            .GetComponent<Text>().text = " ";
    }

    public void drop(Vector3 dropOffLocation) {
        gameObject.transform.parent = null;
        gameObject.transform.position = dropOffLocation;
        pickupUIInstance.transform.GetChild(0).gameObject
            .GetComponent<Text>().text = " ";
    }
}
