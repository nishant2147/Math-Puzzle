using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Puzzlescript : MonoBehaviour
{

    public GameObject puzzleScreen, mainScreen, playingScreen;
    public Sprite Lock,tick;
    public Image[] images;
    public Button[] buttons;
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
        var maxLevel = PlayerPrefs.GetInt("maxLevel",0);
        for (int i = 0; i < buttons.Length; i++)
        {
            Button button = buttons[i];
            Text text = button.GetComponentInChildren<Text>();
            int k = i;
            string status = PlayerPrefs.GetString("status" +i,"pending");
            print(i + "----->" + status);
            if (status == "Completed")
            {
                button.image.sprite = tick;
                text.text = "" + (i + 1);
                button.interactable = true;
            }
            else if(status == "skip" || maxLevel == i)
            {
                button.image.sprite = null;
                text.text = "" + (i + 1);
                button.interactable = true;
            }
            else
            {
                button.image.sprite = Lock;
                text.text = "";
                button.interactable = false;
            }

            button.onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt("currentLevel", k);
                puzzleScreen.SetActive(false);
                playingScreen.SetActive(true);
            });
        }
    }

}

