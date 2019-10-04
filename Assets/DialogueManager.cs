using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public void Option()
    {
        int option = GameManager.x;
        GameManager.x++;

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
