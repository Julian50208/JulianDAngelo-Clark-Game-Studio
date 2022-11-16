using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{



    public bool TitleMenu = true;
    public bool Game = false;
    public bool Pause = false;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);


    }



    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        SceneManager.LoadScene("Level_Scene");
        TitleMenu = false;
        Game = true;
    }
    
    public void Exit()
    {
        Application.Quit();
    }


}
