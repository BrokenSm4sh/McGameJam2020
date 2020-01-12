using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Canvas gameOverScreen;

    [SerializeField] private RawImage startScreen;
    [SerializeField] public Texture story1;
    [SerializeField] public Texture story2;
    [SerializeField] public Texture story3;
    [SerializeField] public Texture story4;

    private Texture currentImage;

    private List<Texture> storyBoard;

    private bool isPaused;
    private bool storyStarted;
    private ControllerStuff controls;


    // Start is called before the first frame update
    void Awake()
    {
        storyBoard = new List<Texture>();
        storyStarted = false;
        controls = new ControllerStuff();
        controls.Menu.Pause.performed += ctx => ToggleGame();
        controls.Menu.StartSotryboard.performed += ctx => ContinueStory();
        AppManager.SetGameInstance(this);
        PauseGame();
        startScreen.enabled = true;
    }

    private void Start()
    {
        storyBoard.AddRange(new[] {story1, story2, story3, story4});
    }

    private void ContinueStory()
    {
        var curIndex = storyBoard.IndexOf(currentImage)+1;
        if (curIndex < storyBoard.Count)
        {
            currentImage = storyBoard[storyBoard.IndexOf(currentImage) + 1];
            startScreen.texture = currentImage;
        }
        else
        {
            startScreen.enabled = false;
            gameOverScreen.enabled = false;
            controls.Menu.StartSotryboard.performed -= ctx => ContinueStory();
            ContinueGame();

        }
    }

    // Update is called once per frame
    void Update()
    {
       
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
        if (startScreen.IsActive())
        {
            storyStarted = true;
            currentImage = story1;
        }

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