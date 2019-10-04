using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameManager gm;

    public RectTransform button1;
    public RectTransform button2;

    public Vector2[] button1Pos;
    public Vector2[] button1Size;

    // Start is called before the first frame update

    public void ChangePos()
    {
        Debug.Log(gm.x);

        button1.localPosition = button1Pos[gm.x];
        button1.localScale = button1Size[gm.x];

    }
}
