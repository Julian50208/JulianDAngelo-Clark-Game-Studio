using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _codexMenu;
    // [SerializeField] private GameObject _pauseButton;

    public int codexID;
    [SerializeField] private Image _enemySprite;
    [SerializeField] private Text _text;

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

    public void CodexOpen()
    {
        _pauseMenu.SetActive(false);
        _codexMenu.SetActive(true);
    }

    public void CodexClose()
    {
        _codexMenu.SetActive(false);
        _pauseMenu.SetActive(true);
    }

    public void CodexLoadSlot(int slot) //TO-DO: set up a spritsheet with all the monsters in it for easy swapping of monster display 
    {
        switch (slot)
        {
            case 1://Fairy
                _text.text = "Fairy codex entry";
                break;
            case 2://Spirit
                _text.text = "Spirit codex entry";
                break;
            case 3://Werewolf
                _text.text = "Werewolf codex entry";
                break;
            default:
                _text.text = "Invalid Codex ID";
                break;
        }
    }


    public void Resume()
    {
        Time.timeScale = 1.0f;
        _pauseMenu.SetActive(false);
        //Pause = false;
        //_pauseButton.SetActive(true);
    }


}
