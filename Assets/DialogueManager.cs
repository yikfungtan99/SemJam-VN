using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    //public GameManager gm;
    public TextMeshProUGUI dialogue;

    public CharacterManager cm;
    public TextMeshProUGUI charName;

    public BackgroundManager bgm;
    public ButtonManager bm;

    public GameObject dialogueWindow;

    public int page = 0;
    public int stage = 0;

    public int flag;

    private void Start()
    {
        dialogueWindow.SetActive(false);
        bm.button1.SetActive(false);
        bm.button2.SetActive(false);
        bm.button3.SetActive(false);
        bm.buttonNext.SetActive(false);

        bgm.BackgroundChange("MainMenu");
        stage = 0;
    }

    public void NextPage()
    {
        if(page == 1)
        {
            dialogueWindow.SetActive(true);
            bm.buttonNext.SetActive(true);
            bm.buttonStart.SetActive(false);
            bm.buttonQuit.SetActive(false);

            bgm.BackgroundChange("RoomNight");  
            dialogue.SetText("You awake in a strange town. Everyone is dressed stragely here and the architecture looks medieval in style.");
            cm.ChangeSprite("FemaleStudent1", "Sad");
        }

        if (page == 2)
        {
            bm.actionPhase();
            bgm.BackgroundChange("Room");
            dialogue.SetText("You are now standing in an alleyway. There seems to be a shadowy figure at the other end.");
            cm.ChangeSprite("FemaleStudent1", "Blush");
        }
        else if  (page == 3) 
        {
            bgm.BackgroundChange("School");
            dialogue.SetText("lmao");
            cm.ChangeSprite("FemaleStudent1", "Happy");
        }
        else if (page == 4)
        {
            bgm.BackgroundChange("notExist");
            dialogue.SetText("Debug should show background not found");
            cm.ChangeSprite("FemaleStudent1", "Sad");
        }
        else if (page == 5)
        {
            bgm.BackgroundChange("Room");
            dialogue.SetText("is it working?");
            cm.ChangeSprite("FemaleStudent1", "Sad");
        }
        else if (page == 6)
        {
            dialogue.SetText("is it working?");
            cm.ChangeSprite("FemaleStudent1", "Sad");
        }

    }
}
