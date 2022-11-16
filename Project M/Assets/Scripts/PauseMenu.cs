using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{


    [SerializeField] private GameObject _pauseMenu;
    // [SerializeField] private GameObject _pauseButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            PauseButton();
        }
    }


    public void Title()
    {
        SceneManager.UnloadSceneAsync("Level_Scene");
        SceneManager.LoadScene("title");
        Time.timeScale = 1.0f;
        //TitleMenu = true;
        //Game = false;
        //Pause = false;
    }

    public void PauseButton()
    {
        Time.timeScale = 0f;
        _pauseMenu.SetActive(true);
        //Pause = true;
        //_pauseButton.SetActive(false);

    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        _pauseMenu.SetActive(false);
        //Pause = false;
        //_pauseButton.SetActive(true);
    }


}
