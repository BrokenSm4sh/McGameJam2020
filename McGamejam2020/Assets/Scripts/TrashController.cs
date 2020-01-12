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
    public float FLOATABLE_DISTANCE;
    public float TRASH_FLOAT_OFFSET;
    public float PLAYER_FLOAT_OFFSET;
    
    private bool isFloating = false;
    private bool floatingPrepared = false;

    private float yBeforeFloating;

    // Start is called before the first frame update
    void Start()
    {
        floatingUIInstance = Instantiate(floatingUIPrefab,
            new Vector3(gameObject.transform.position.x,
            gameObject.transform.position.y + floatingUIYOffset,
            gameObject.transform.position.z),
            Quaternion.identity, gameObject.transform);
        gameObject.tag = "trash";
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFloating) {
            yBeforeFloating = player.transform.position.y;
            // within float radius, not floating and not prepared for floating.
            if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= FLOATABLE_DISTANCE
                && !floatingPrepared) {
                gameObject.tag = "okToFloat";
                floatingUIInstance.GetComponent<FloatUIContoller>().prepareFloatPrompt();
                floatingPrepared = true;
            }

            // out of float radius, not floating.
            if (Vector3.Distance(gameObject.transform.position, player.transform.position) > FLOATABLE_DISTANCE
                && floatingPrepared) {
                gameObject.tag = "trash";
                floatingUIInstance.GetComponent<FloatUIContoller>().cancelFloatPrompt();
                floatingPrepared = false;
            }

            // this makes player float on the trash
            if (Input.GetKeyDown(KeyCode.F)) {
                startFloating();
            }
        } else {
            if (Input.GetKeyDown(KeyCode.V)) {
                stopFloating();
            }
        }
    }

    void startFloating() {
        GameObject carrier = GameObject.FindGameObjectWithTag("okToFloat");
        carrier.tag = "FloatingCarrier";
        carrier.transform.parent = player.transform;
        player.transform.position =
            new Vector3(player.transform.position.x,
            player.transform.position.y + PLAYER_FLOAT_OFFSET,
            player.transform.position.z);
        carrier.transform.position =
            new Vector3(player.transform.position.x, TRASH_FLOAT_OFFSET, player.transform.position.z);
        floatingUIInstance.GetComponent<FloatUIContoller>().cancelFloatPrompt();
        isFloating = true;

    }

    void stopFloating() {
        GameObject carrier = GameObject.FindGameObjectWithTag("FloatingCarrier");
        carrier.transform.parent = null;
        carrier.SetActive(false);
        isFloating = false;
        player.transform.position = new Vector3(
            player.transform.position.x,
            yBeforeFloating,
            player.transform.position.z);
    }
}
