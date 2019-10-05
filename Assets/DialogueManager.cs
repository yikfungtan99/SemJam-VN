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
            charName.SetText("");

            dialogueWindow.SetActive(true);
            bm.buttonNext.SetActive(true);
            bm.buttonStart.SetActive(false);
            bm.buttonQuit.SetActive(false);

            bgm.BackgroundChange("Black");  
            dialogue.SetText("You awoke in a strange place.");
        }

        if(page == 2)
        {
            dialogue.SetText("The buildings around you, they seemed...medieval.");
        }

        if(page == 3)
        {
            dialogue.SetText("You tried to walk around, lost and confused.");
        }

        if (page == 4)
        {
            bm.actionPhase(1);
            bgm.BackgroundChange("Alleyway");
            dialogue.SetText("An other-worldly traveller, a lost wanderer of the <color=green>alleyways</color> of time.");
        }
        if  (page == 5) 
        {
            dialogue.SetText("You took a sharp turn.");
        }
        if (page == 6)
        {
            dialogue.SetText("You found yourself in an alleyway.");
        }
        if (page == 7)
        {
            bm.actionPhase(1);
            dialogue.SetText("A <color=green>shadowy figure</color> stood at the other end.");
        }
        if (page == 8)
        {
            charName.SetText("???");
            dialogue.SetText("Hey bud! Whatcha doin’ over there?");
        }
        if(page == 9)
        {
            dialogue.SetText("You tried to answer, but found yourself incapable.");
        }
        if(page == 10)
        {
            charName.SetText("Bandit");
            bm.actionPhase(1);
            dialogue.SetText("Whatchu wearin’? <color=green>Don’t</color> seem to be around here, eh?");
        }
        if (page == 11)
        {
            dialogue.SetText("You shook your head.");
        }
        if (page == 12)
        {
            dialogue.SetText("Heh, like I thought so. Faraway fella, betcha be rich, hmm?");
        }
        if (page == 13)
        {
            dialogue.SetText("Ya life or ya money, pick one bud. Or I’ll pick it for ya.");
        }
        if (page == 14)
        {
            bm.actionPhase(2);
            dialogue.SetText("Look, this can be easy and simple.You can fork over the cash and get <color=green>knocked out</color>, or I’ll just <color=green>kill</color> you instead.");
        }
        if(page == 15)
        {
            dialogue.SetText("The bandit’s eyes widened in shock.");
        }
        if (page == 16)
        {
            dialogue.SetText("Blood, fresh blood, poured out of his mouth.");
        }
        if (page == 17)
        {
            dialogue.SetText("His eyes rolled back, then crumpled onto the floor.");
        }
        if (page == 18)
        {
            dialogue.SetText("");
        }
        if (page == 19)
        {
            dialogue.SetText("");
        }
        if (page == 20)
        {
            dialogue.SetText("");
        }
        if (page == 21)
        {
            dialogue.SetText("");
        }
        if (page == 22)
        {
            dialogue.SetText("");
        }
        if (page == 23)
        {
            dialogue.SetText("");
        }
        if (page == 24)
        {
            dialogue.SetText("");
        }
        if (page == 25)
        {
            dialogue.SetText("");
        }
        if (page == 26)
        {
            dialogue.SetText("");
        }
        if (page == 27)
        {
            dialogue.SetText("");
        }
        if (page == 27)
        {
            dialogue.SetText("");
        }
        if (page == 29)
        {
            dialogue.SetText("");
        }
        if (page == 30)
        {
            dialogue.SetText("");
        }
        if (page == 31)
        {
            dialogue.SetText("");
        }


    }
}
