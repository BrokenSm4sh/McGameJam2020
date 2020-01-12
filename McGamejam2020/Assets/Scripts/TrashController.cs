using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashController : MonoBehaviour
{
    public GameObject player;
    public float FLOATING_PLAYER_OFFSET;
    public GameObject floatingUIPrefab;
    public float floatingUIYOffset;
    private GameObject floatingUIInstance;
    private Text nearbyPrompt;
    public float PLAYER_FLOAT_OFFSET;
    public float FLOATABLE_DISTANCE;

    private bool isFloating = false;

    // Start is called before the first frame update
    void Start()
    {
        floatingUIInstance = Instantiate(floatingUIPrefab,
            new Vector3(gameObject.transform.position.x,
            gameObject.transform.position.y + floatingUIYOffset,
            gameObject.transform.position.z),
            Quaternion.identity, gameObject.transform);
        nearbyPrompt = floatingUIInstance.transform.GetChild(0).gameObject.GetComponent<Text>();
        floatingUIInstance.transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= FLOATABLE_DISTANCE
            && !isFloating) {
            nearbyPrompt.text = "F to float";
            gameObject.tag = "okToFloat";
        } else {
            nearbyPrompt.text = " ";
        }
        
        // this makes player float on the trash
        if (Input.GetKeyDown(KeyCode.F)) {
            player.transform.parent = GameObject.FindGameObjectWithTag("okToFloat").transform;
            player.transform.position = new Vector3(0, FLOATING_PLAYER_OFFSET, 0);
            isFloating = true;
        }
    }


}
