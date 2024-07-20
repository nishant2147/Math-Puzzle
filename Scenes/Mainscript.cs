using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mainscript : MonoBehaviour
{

    public GameObject mainScreen, playingScreen, puzzleScreen;
    public Button[] button;
    int currentlevel;
    // Start is called before the first frame update
    void Start()
    {
        print("Start ---->  ");
       //PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickContinue()
    {
        var maxLevel = PlayerPrefs.GetInt("maxLevel");
        PlayerPrefs.SetInt("currentLevel", maxLevel);
        mainScreen.SetActive(false);
        playingScreen.SetActive(true);
    }

    public void clickPuzzles()
    {
        mainScreen.SetActive(false);
        puzzleScreen.SetActive(true);
    }
    public void clickGotomain()
    {
        puzzleScreen.SetActive(false);
        mainScreen.SetActive(true);
    }

}
