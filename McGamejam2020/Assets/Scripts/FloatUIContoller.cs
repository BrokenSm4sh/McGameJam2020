using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatUIContoller : MonoBehaviour
{
    private GameObject player;
    private GameObject camera;
    private Text nearbyPrompt;

    [HideInInspector]
    public bool isFloating;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        nearbyPrompt = transform.GetChild(0).gameObject.GetComponent<Text>();
        gameObject.GetComponent<Canvas>().worldCamera =
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);
    }

    public void prepareFloatPrompt() {
        nearbyPrompt.text = "F to float";
    }

    public void whenFloating() {
        nearbyPrompt.text = "V to stop floating";
    }

    public void cancelFloatPrompt() {
        nearbyPrompt.text = " ";
    }
}
