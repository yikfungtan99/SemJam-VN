using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameManager gm;

    public GameObject button1;
    public GameObject button2;

    private RectTransform buttonRectTransform1;
    private RectTransform buttonRectTransform2;

    public Vector2[] button1Pos;
    public float[] button1Width;

    public Vector2[] button2Pos;
    public float[] button2Width;

    // Start is called before the first frame update

    private void Start()
    {
        buttonRectTransform1 = button1.GetComponent<RectTransform>();
    }

    public void ChangePos()
    {
        Debug.Log(gm.x);

        buttonRectTransform1.localPosition = button1Pos[gm.x];

        buttonRectTransform1.sizeDelta = new Vector2(button1Width[gm.x], 64);
    }
}
