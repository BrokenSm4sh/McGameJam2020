using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    [Range(0, 100)] 
    public float staminaDecreaseRate;
    private float staminaPoints;
    // Start is called before the first frame update
    void Start()
    {
        staminaPoints = 100;
    }

    // Update is called once per frame
    void Update()
    {
        staminaPoints -= staminaDecreaseRate * Time.deltaTime;
      //  Debug.Log(staminaPoints);
        if (staminaPoints <= 0)
        {
            AppManager.GetGameInstance().ForceGameOver();
            
        }
    }
    
    
}
