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
        SceneManager.UnloadSceneAsync("Section 1");
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
                _text.text = "Fairy codex entry: The concept of fairies first originated from Greek mythology, but their modern interpretation " +
                    "was influenced heavily by Old English folklore from the 13th Century. The design and interpretation of fairies varies " +
                    "greatly depending on the region and local superstition, with a range of fairies from good to evil, ugly to beautiful.";
                break;
            case 2://Spirit
                _text.text = "Spirit codex entry: Willow wisps are based off of a natural phenomena known as ghost lights, where gas that is slowly being" +
                    " released from a swampy area is ignited,  causing a floating light with no apparent source to appear in the wilderness. " +
                    "Often times, these lights would disappear as someone moved closer to investigate. These Willow wisps we're thus said to" +
                    " be spirits that lead travelers astray, either to become last within the woods or drawn into the swamp and into a watery grave. " +
                    "Another explanation is that fairies are the ones responsible for the lights, again too caused travelers to become hopelessly lost within the forest.";
                break;
            case 3://Werewolf
                _text.text = "Werewolf codex entry:  Werewolves are some of the most well-established myths or folklore, with" +
                    " some of their first confirmed origins coming from Ancient Greece in the 15th century. " +
                    "There are three common origins for you to become a werewolf: One, you are born with werewolf genes. " +
                    "Two, you are “infected” by a werewolf, typically through a bite wound. And three, you adorn a belt or" +
                    " pelt made from wolf hide and/or fur. Most modern werewolf mythos occurred from serial killers who" +
                    " would claim they had the ability to transform into a werewolf in an attempt to excuse themselves " +
                    "of their crimes. ";
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
