using System;
using UnityEngine;
using UnityEngine.UI;

public class Buttonscript : MonoBehaviour
{

    public Text textfield;
    public Text titleText;
    public Image boardImage;
    public Sprite[] allBoardImages;
    public GameObject finalScreen,Playerscreen, Puzzelscreen;
    string[] answers = {"10", "25", "6", "14", "128","7","50","1025","100","3","212","3011","14","16","1","2","44","45","625","1"};
    int currentLevel;


    public void ButtonSubmit()
    {
        if(textfield.text == answers[currentLevel])
        {
            PlayerPrefs.SetString("status" + currentLevel, "Completed");
            PlayerPrefs.SetInt("currentLevel", currentLevel + 1);

            var maxLevel = PlayerPrefs.GetInt("maxLevel", 0);
            if (currentLevel +1 > maxLevel)
            {
                PlayerPrefs.SetInt("maxLevel", currentLevel + 1);
            }

            playingScreen.SetActive(false);
            finalScreen.SetActive(true);
        }
        else
        {
            textfield.text = "";
        }
    }
    public void skip()
    {
        var maxLevel = PlayerPrefs.GetInt("maxLevel", 0);
        if (currentLevel + 1 > maxLevel)
        {
            PlayerPrefs.SetInt("maxLevel", currentLevel + 1);
        }
        PlayerPrefs.SetInt("currentLevel" ,currentLevel + 1);
        PlayerPrefs.SetString("status" + currentLevel, "skip");
        OnEnable();
        
    }
    
    // Start is called before the first frame update
    public GameObject playingScreen, puzzleScreen;
    void Start()
    {

    }
    
    public void GotoHome()
    {
        playingScreen.SetActive(false);
        puzzleScreen.SetActive(true);
        textfield.text = "";
    }
    
    public void clear()
    {
        if (textfield.text.Length > 0)
        {
            textfield.text = textfield.text.Remove(textfield.text.Length - 1, 1);
        }

        if (textfield.text == "")
        {
            textfield.text = "0";
        }
    }
    public void clickButton0()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "0";
        }
        else
        {
            textfield.text = textfield.text + "0";
        }
    }
    public void clickButton9()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "9";
        }
        else
        {
            textfield.text = textfield.text + "9";
        }
    }
    public void clickButton8()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "8";
        }
        else
        {
            textfield.text = textfield.text + "8";
        }
    }
    public void clickButton7()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "7";
        }
        else
        {
            textfield.text = textfield.text + "7";
        }
    }
    public void clickButton6()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "6";
        }
        else
        {
            textfield.text = textfield.text + "6";
        }
    }
    public void clickButton5()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "5";
        }
        else
        {
            textfield.text = textfield.text + "5";
        }
    }
    public void clickButton4()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "4";
        }
        else
        {
            textfield.text = textfield.text + "4";
        }
    }
    public void clickButton3()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "3";
        }
        else
        {
            textfield.text = textfield.text + "3";
        }
    }
    public void clickButton2()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "2";
        }
        else
        {
            textfield.text = textfield.text + "2";
        }
    }
    public void clickButton1()
    {
        if (textfield.text == Convert.ToString(0))
        {
            textfield.text = "1";
        }
        else
        {
            textfield.text = textfield.text + "1";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
        currentLevel = PlayerPrefs.GetInt("currentLevel");
        print("current Level --> " + (currentLevel + 1));
        titleText.text = "Puzzle " + (currentLevel + 1);

        boardImage.sprite = allBoardImages[currentLevel];
        textfield.text = "";
    }

}
