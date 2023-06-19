using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSquare : Selectable
{
    public GameObject number_text;
    private int number_ = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void DisplayText()
    {
        if(number_ <= 0)
        {
            number_text.GetComponent<Text>().text = " ";
            
        }
        else
        {
            number_text.GetComponent<Text>().text = number_.ToString();
        }
    }

    public void SetNumber(int number)
    {
        number_ = number;
        DisplayText();
    }
}
