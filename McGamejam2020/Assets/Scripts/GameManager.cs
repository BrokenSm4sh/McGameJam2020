using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private  Canvas gameOverScreen;

    private bool isPaused;
    private ControllerStuff controls; 
    
    // Start is called before the first frame update
    void Awake()
    {
        controls = new ControllerStuff();
        controls.Menu.Pause.performed += ctx => ToggleGame();
        AppManager.SetGameInstance(this);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            hardRestartGame();
        }
        if(Input.GetKey(KeyCode.G))
        {
            ForceGameOver();
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            ToggleGame();
        }
    }
    
    private void OnEnable()
    {
        controls.Menu.Enable();
    }

    private void OnDisable()
    {
        controls.Menu.Disable();
    }

    private void ToggleGame()
    {
        Debug.Log("pause?");
        if (!isPaused)
        {
            PauseGame();
        }
        else
        {
            ContinueGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        //pausePanel.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    } 
    private void ContinueGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        //pausePanel.SetActive(false);
        //enable the scripts again
    }

    void hardRestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.gameObject.SetActive(false);

    }

    public void ForceGameOver()
    {
        gameOverScreen.gameObject.SetActive(true);
    }
}
