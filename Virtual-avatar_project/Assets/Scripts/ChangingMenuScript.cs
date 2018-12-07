using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangingMenuScript : MonoBehaviour {

    // These are needed for UPDATE to Update squares according to what is WORN by the character 
    public Image squareHeadDisplay;
    public Image squareBeardDisplay;
    public Image squareTopDisplay;
    public Image squareJacketDisplay;
    public Image squareLegsDisplay;
    public Image squareGlovesDisplay;
    



    //Panel Objects
    public GameObject panel; //Lazy, this is the default (Hair panel)
    public GameObject beardpanel;
    public GameObject toppanel;
    public GameObject jacketpanel;
    public GameObject legspanel;
    public GameObject glovespanel;
    public GameObject accpanel;
    public GameObject skincolorpanel;
    public GameObject haircolorpanel;
    // Panel Objects ABOVE

    //Code for Hair buttons
    public SpriteRenderer hair;
    public Sprite[] hairs;
    public int whathair = 1;
    public void Changehair(int index)
    {
        whathair = index;
    }
    //Code for Beard buttons
    public SpriteRenderer beard;
    public Sprite[] beards;
    public int whatbeard = 1;
    public void Changebeard(int index)
    {
        whatbeard = index;
    }
    //Code for Shirt buttons
    public SpriteRenderer shirt;
    public Sprite[] shirts;
    public int whatshirt = 1;
    public void ChangeShirt(int index)
    {
        whatshirt = index;
    }
    //Code for Jacket buttons
    public SpriteRenderer jacket;
    public Sprite[] jackets;
    public int whatJacket = 1;
    public void ChangeJacket(int index)
    {
        whatJacket = index;
    }
    //Code for Legs buttons
    public SpriteRenderer leg;
    public Sprite[] legs;
    public int whatleg = 1;
    public void Changeleg(int index)
    {
        whatleg = index;
    }
    //Code for Gloves buttons
    public SpriteRenderer glove;
    public Sprite[] gloves;
    public int whatglove = 1;
    public void Changeglove(int index)
    {
        whatglove = index;
    }
    //Code for Accessories buttons
    public SpriteRenderer acc;
    public Sprite[] accs;
    public int whatacc = 1;
    public void Changeacc(int index)
    {
        whatacc = index;
    }
    //Code for SC/HC ??

    public void Update()
    {

        squareHeadDisplay.sprite = hair.sprite;
        squareBeardDisplay.sprite = beard.sprite;
        squareTopDisplay.sprite = shirt.sprite;
        squareJacketDisplay.sprite = jacket.sprite;
        squareLegsDisplay.sprite = leg.sprite;
        squareGlovesDisplay.sprite = glove.sprite;

        for (int i = 0; i < hairs.Length; i++) // HAIR CODE
        {
            if(i == whathair)
            {
                hair.sprite = hairs[i];
            }

        }
        for (int i = 0; i < jackets.Length; i++) // JACKET CODE
        {
            if (i == whatJacket)
            {
                jacket.sprite = jackets[i];
            }
        }
        for(int o = 0; o < beards.Length; o++) //BEARD CODE
        {
            if (o == whatbeard)
            {
                beard.sprite = beards[o];
            }
        }
        for (int o = 0; o < shirts.Length; o++)
        {
            if (o == whatshirt)
            {
                shirt.sprite = shirts[o];
            }
        }
        for (int o = 0; o < legs.Length; o++) //LEGS CODE
        {
            if (o == whatleg)
            {
                leg.sprite = legs[o];
            }
        }

        for (int o = 0; o < gloves.Length; o++) //Gloves CODE
        {
            if (o == whatglove)
            {
                glove.sprite = gloves[o];
            }
        }

        for (int o = 0; o < accs.Length; o++) //Accessories CODE
        {
            if (o == whatacc)
            {
                acc.sprite = accs[o];
            }
        }

    }
   
    
    
    //Opening and closing the menu-sections, made without arrays = have fun, its actual DOGESHIT
    public void OpenPanel()
    {
        panel.SetActive(true);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
        jacketpanel.SetActive(false);
    }
    public void ClosePanels() // DEBUG ; Close all panels
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
        jacketpanel.SetActive(false);
    } 
    public void OpenPanelBeard()
    {
        panel.SetActive(false);
        toppanel.SetActive(false);
        jacketpanel.SetActive(false);
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
        beardpanel.SetActive(true); //HERE!
    }
    public void OpenPanelTop()
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        jacketpanel.SetActive(false);
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
        toppanel.SetActive(true); //HERE!
    }
    public void OpenPanelJacket()
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
        jacketpanel.SetActive(true); //HERE
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
    }
    public void OpenPanelLegs()
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
        jacketpanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
        legspanel.SetActive(true); //HERE!
    }
    public void OpenPanelGloves()
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
        jacketpanel.SetActive(false);
        legspanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
        glovespanel.SetActive(true); //HERE!
    }
    public void OpenPanelAccesories()
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
        jacketpanel.SetActive(false);
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
        accpanel.SetActive(true); //HERE!
    } 
    public void OpenPanelSkincolor()
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
        jacketpanel.SetActive(false);
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(true); //HERE!
        haircolorpanel.SetActive(false);
    }
    public void OpenPanelHaircolor()
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
        jacketpanel.SetActive(false);
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(true); //HERE!
    }
   

}
