using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingColorScript : MonoBehaviour
{
    public GameObject panel;

    public SpriteRenderer hat;
    public Image squareHatDisplay;
    public Color red;
    public Color blue;
    public Color green;
    public Color yellow;

    public int whatColor = 1;

    private void Update()    
    {
        squareHatDisplay.color = hat.color;
        if (whatColor == 1)
        {
            hat.color = red;
        }
       else if(whatColor == 2)
        {
            hat.color = blue;
        }
       else if(whatColor == 3)
        {
            hat.color = green;
        }
       else if(whatColor == 4)
        {
            hat.color = yellow;
        }
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }

    public void ChangeHatRed()
    {
        whatColor = 1;
    }

    public void ChangeHatBlue()
    {
        whatColor = 2;
    }
    public void ChangeHatGreen()
    {
        whatColor = 3;
    }
    public void ChangeHatYellow()
    {
        whatColor = 4;
    }



}
	
