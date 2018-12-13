using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingAppearance : MonoBehaviour {

    public SpriteRenderer part;
    public Sprite[] options;
    public int index;
    public int index2;
    public GameObject[] BodyPanels;
    public GameObject Bodypanel;


     void Update()
    {
        for (int i = 0; i < options.Length; i++)
        {
            if(i == index)
            {
                part.sprite = options[i];
            }
        }
        for (int u = 0; u < BodyPanels.Length; u++)
        {
            if(u == index)
            {
                Bodypanel = BodyPanels[u];
            }

        }
    }
    public void Swap()
    {
        if(index < options.Length - 1)
        {
            index++;
        }
        else
        {
            index = 0;
        }
        if (index2 < BodyPanels.Length - 1)
        {
            index2++;
        }
        else
        {
            index2 = 0;
        }
    }
}
