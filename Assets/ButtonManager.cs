using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameManager gm;

    public Button button1;
    public Button button2;

    public Vector2[] button1Pos;

    // Start is called before the first frame update
    void ChangePos()
    {
        gm.x++;

        if(gm.x == 1)
        {
            
        }
    }
}
