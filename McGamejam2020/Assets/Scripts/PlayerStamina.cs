using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    [Range(0, 100)] 
    private float staminaDecreaseRate;
    private float staminaPoints;
    // Start is called before the first frame update
    void Start()
    {
        staminaPoints = 100;
    }

    // Update is called once per frame
    void Update()
    {
        staminaDecreaseRate = 0;
    }
}
