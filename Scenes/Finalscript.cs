using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finalscript : MonoBehaviour
{
    public GameObject finalScreen, mainScreen, PlayerScreen;
    public Text titleText;
    int currentLevel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");
        titleText.text = "Level " + currentLevel + " Completed ";
    }

    public void buttonmain()
    {
        finalScreen.SetActive(false);
        mainScreen.SetActive(true);
    }
    public void Continue()
    {
        finalScreen.SetActive(false);
        PlayerScreen.SetActive(true);
    }
}
    /*public void OnEnable() 
    {
        
    }*/

