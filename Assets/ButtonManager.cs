using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public DialogueManager dm;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    public GameObject buttonNext;
    public GameObject buttonStart;
    public GameObject buttonQuit;

    private RectTransform buttonRectTransform1;
    private RectTransform buttonRectTransform2;
    private RectTransform buttonRectTransform3;

    public Vector2[] button1Pos;
    public float[] button1Width;

    public Vector2[] button2Pos;
    public float[] button2Width;

    public Vector2[] button3Pos;
    public float[] button3Width;

    // Start is called before the first frame update

    private void Start()
    {
        buttonRectTransform1 = button1.GetComponent<RectTransform>();
        button1.SetActive(false);
    }

    public void ChangePage()
    {
        dm.page++;
        dm.NextPage();
        Debug.Log(dm.page);
    }

    public void actionPhase()
    {
        buttonNext.SetActive(false);
        button1.SetActive(true);
        dm.stage++;
        //Debug.Log("stage now = " + dm.stage);
        setPos();
    }

    public void setPos()
    {
        if(dm.stage >= button1Pos.Length)
        {
            Debug.Log("Button 1 have no position left");
        }
        else
        {
            buttonRectTransform1.localPosition = button1Pos[dm.stage];

            buttonRectTransform1.sizeDelta = new Vector2(button1Width[dm.stage], 90);
        }
    }

    public void setFlag1()
    {
        dm.flag = 1;
        button1.SetActive(false);
        buttonNext.SetActive(true);
        ChangePage();
    }

    public void setFlag2()
    {
        dm.flag = 2;
        button2.SetActive(false);
        buttonNext.SetActive(true);
        ChangePage();
    }

    public void setFlag3()
    {
        dm.flag = 3;
        button3.SetActive(false);
        buttonNext.SetActive(true);
        ChangePage();
    }
}
