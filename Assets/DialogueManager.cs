using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameManager gm;
    public TextMeshProUGUI dialogue;
    public CharacterManager cm;
    public TextMeshProUGUI charName;

    int page = 0;

    public void Page()
    {
        gm.stage++;

        page = gm.stage;

        if (page == 1)
        {
            dialogue.SetText("lollolololol");
            cm.ChangeSprite("FemaleStudent1", "Blush");
        }
        else if  (page == 2)
        {
            dialogue.SetText("lmao");
            cm.ChangeSprite("FemaleStudent1", "Happy");
        }
    }
}
