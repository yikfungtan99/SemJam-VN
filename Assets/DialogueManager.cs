using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameManager gm;
    int option = 0;

    public void Option()
    {
        gm.x++;

        option = gm.x;

        if (option == 1)
        {
            Debug.Log("fuck");
        }
        else if  (option == 2)
        {
            Debug.Log("you");
        }
    }
}
