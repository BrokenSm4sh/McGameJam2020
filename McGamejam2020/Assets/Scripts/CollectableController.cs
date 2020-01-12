using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    public GameObject player;
    public float CollectableZOffsetFromPlayer;

    public float pickUpUIYOffset;
    public GameObject pickupUI;

    // Start is called before the first frame update
    void Start()
    {
        // spawn pickUp UI
        Instantiate(pickupUI,
            new Vector3(transform.position.x, transform.position.y + pickUpUIYOffset, transform.position.z), Quaternion.identity)
            .transform.SetParent(gameObject.transform);

        // register event listener
        PlayerController.onPickUp += OnCollecPickedUp;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // handle collision with player
    private void OnCollecPickedUp() {
        gameObject.transform.SetParent(player.transform);
        gameObject.transform.position = new Vector3(
            player.transform.position.x,
            player.transform.position.y,
            player.transform.position.z + CollectableZOffsetFromPlayer);
    }

    private void OnCollecPutDown() {
        transform.parent = null;
    }

    private void OnDisable() {
        PlayerController.onPickUp -= OnCollecPickedUp;
    }
}
