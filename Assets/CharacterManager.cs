using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public Sprite ShadowyFigure;
    public Sprite[] Bandit, Guard, King, Witch;
    public SpriteRenderer spr;
    private int expNum;

    public void ChangeSprite(string name, string expression)
    {
        if(name == "ShadowyFigure")
        {
            spr.sprite = ShadowyFigure;
        }

        if (name == "Bandit")
        {
            if (expression == "Normal")
            {
                expNum = 0;
            }

            if (expression == "Attack")
            {
                expNum = 1;
            }

            spr.sprite = Bandit[expNum];
        }

        if (name == "Guard")
        {
            if (expression == "Normal")
            {
                expNum = 0;
            }

            if (expression == "Attack")
            {
                expNum = 1;
            }

            spr.sprite = Guard[expNum];
        }

        if (name == "King")
        {
            if (expression == "Normal")
            {
                expNum = 0;
            }

            if (expression == "Seize")
            {
                expNum = 1;
            }

            spr.sprite = King[expNum];
        }

        if (name == "Witch")
        {
            if (expression == "Normal")
            {
                expNum = 0;
            }

            if (expression == "Angry")
            {
                expNum = 1;
            }

            spr.sprite = Witch[expNum];
        }
    }

    public void ClearSprite()
    {
        spr.sprite = null;
    }
}
