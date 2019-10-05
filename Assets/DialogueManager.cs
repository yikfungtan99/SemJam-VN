using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
        bm.buttonQuit.SetActive(true);

        bgm.BackgroundChange("MainMenu");
        stage = 0;
    }

    public void NextPage()
    {
        if(page == 1)
        {
            bgm.BackgroundChange("Black");
            dialogueWindow.SetActive(true);
            bm.buttonNext.SetActive(true);
            bm.buttonStart.SetActive(false);
            bm.buttonQuit.SetActive(false);

            dialogue.SetText("You awoke in a strange place.");
        }
        if (page == 2)
        {
            dialogue.SetText("The buildings around you, they seemed...medieval.");
        }
        if (page == 3)
        {
            dialogue.SetText("You try to walk around, lost and confused..");
        }
        if (page == 4)
        {
            dialogue.SetText("You took a sharp turn and find yourself in an alleyway.");
        }
        if (page == 5)
        {
            bm.actionPhase(1);
            dialogue.SetText("A shadowy figure stands at the other end.");
        }
        if (page == 6)
        {
            cm.ChangeSprite("ShadowyFigure", null);
            bgm.BackgroundChange("Alleyway");
            charName.SetText("Shadowy Figure");
            dialogue.SetText("Oi mate! Whatcha doin’ over there?");
        }
        if (page == 7)
        {
            dialogue.SetText("The figure turns out to be unruly bandit.");
        }
        if (page == 8)
        {
            cm.ChangeSprite("Bandit", "Normal");
            charName.SetText("Bandit");
            dialogue.SetText("Whatchu wearin’? Don’t seem to be around here, eh?");
        }
        if (page == 9)
        {
            cm.ChangeSprite("Bandit", "Attack");
            bm.actionPhase(2);
            dialogue.SetText("Heh, like I thought so. Faraway fella, betcha be rich, hmm?");
        }
        if (page == 10)
        {
            if(flag == 1)
            {
                cm.ClearSprite();
                dialogue.SetText("The bandit is teleported far far away. As he disappears, a piece of paper falls out of his coat.");
            }

            if(flag == 2)
            {
                page = 31;
                NextPage();
            }
        }

        if (page == 11)
        {
            bm.actionPhase(1);
            dialogue.SetText("You make pick up the piece of paper, however, you can only make out a few parts of it.");
        }
        if (page == 12)
        {
            bm.actionPhase(3);
            dialogue.SetText("Message:”I need you to… at the...dungeon. With this power we can… the castle… Faerghus forbids… Scarlet… moon of death..");
        }
        if (page == 13)
        {
            if(flag == 1)
            {
                cm.ChangeSprite("Guard", "Normal");
                bgm.BackgroundChange("Entrance");
                dialogue.SetText("You find yourself in front of a large imposing castle. You see one guard standing watch.");
            }

            if(flag == 2)
            {
                page = 26;
                NextPage();
            }

            if(flag == 3)
            {
                page = 28;
                NextPage();
            }   
        }
        if (page == 14)
        {
            cm.ChangeSprite("Guard", "Attack");
            charName.SetText("Guard");
            bm.actionPhase(1);
            dialogue.SetText("Halt! Stop right there.");
        }
        if (page == 15)
        {
            cm.ChangeSprite("Guard", "Normal");
            bm.actionPhase(1);
            dialogue.SetText("The guard is frozen to the spot. You casually walk past him into the throne room.");
        }
        if (page == 16)
        {
            cm.ChangeSprite("King", "Normal");
            charName.SetText("King");
            bgm.BackgroundChange("ThroneRoom");
            dialogue.SetText("What is the meaning of this?!");
        }
        if (page == 17)
        {
            cm.ChangeSprite("King", "Seize");
            bm.actionPhase(1);
            dialogue.SetText("Guards, seize this fool!");
        }
        if (page == 18)
        {
            cm.ClearSprite();
            dialogue.SetText("The guards pounce on the king altogether, binded by a flurry of big men in steel armour, the king is unable to breathe and dies..");
        }
        if (page == 19)
        {
            bgm.BackgroundChange("WizardRoom");
            dialogue.SetText("You go to the Castle Keep and find the witch.");
        }
        if (page == 20)
        {
            charName.SetText("Witch");
            cm.ChangeSprite("Witch", "Normal");
            bm.actionPhase(3);
            dialogue.SetText("Hello there. What brings you to my domain? \n" +
                             "Did you really think that I’ll help you get back home after what you’ve done. \n" +
                             "At the very least you deserve some kind of punishment!");
        }

        if (page == 21)
        {
            if(flag == 1)
            {
                cm.ClearSprite();
                bgm.BackgroundChange("Room");
                dialogue.SetText("Upon realising when she just said, she attempts to cast a spell to keep you trapped but it’s too late as you warp back to your comfortable bedroom.");
            }

            if(flag == 2)
            {
                cm.ChangeSprite("Witch", "Angry");
                bgm.BackgroundChange("Black");
                page = 24;
                NextPage();
            }

            if (flag == 3)
            {
                cm.ChangeSprite("Witch", "Angry");
                bgm.BackgroundChange("Black");
                page = 24;
                NextPage();
            }

        }

        if (page == 22)
        {
            dialogue.SetText("YOU WIN!!! THANKS FOR PLAYING");
        }

        if(page == 23)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        //GAME OVER HERE

        if (page == 24)//main end
        {
            dialogue.SetText("With a snap of her finger, the witch sends you to an endless void where you are forced to question your existence.");
        }

        if (page == 25)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (page == 26)//Dungeon
        {
            dialogue.SetText("With a flash of light, you find yourself in a dark, damp cell. Seems you wouldn’t be going anywhere anytime soon.");
        }

        if(page == 27)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (page == 28)//Moon
        {
            dialogue.SetText("You feel a sudden glow and glance up. To your horror, you see the moon edging closer, the ground starts to shake and you lose your balance.");
        }
        if (page == 29)
        {
            bgm.BackgroundChange("Moonfall");
            dialogue.SetText("Then, a screeching sound pierces your ears until they bleed as you realize that the moon itself is collapsing onto the earth. The last thing you see is a huge explosion.");
        }

        if (page == 30)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (page == 31)//Rich
        {
            dialogue.SetText("The bandit stares in awe and surprise as gold coins begins to magically pour out of every pockets you have.");
        }
        if (page == 32)
        {
            dialogue.SetText("“Hah, I knew you were worth a pretty penny” \n" +
                               "The bandit chuckles as he shanks you in the side and makes off with your newfound wealth.");
        }

        if (page == 33)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
