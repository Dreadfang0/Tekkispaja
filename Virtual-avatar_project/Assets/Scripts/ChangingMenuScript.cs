using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangingMenuScript : MonoBehaviour {

    public GameObject panel; //Lazy, this is the default (Hair panel)
    public GameObject beardpanel;
    public GameObject toppanel;
    public GameObject legspanel;
    public GameObject glovespanel;
    public GameObject accpanel;
    public GameObject skincolorpanel;
    public GameObject haircolorpanel;
    

    public void Update()
    {
        
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
    }
    

    public void OpenPanelBeard()
    {
        panel.SetActive(false);
        toppanel.SetActive(false);
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
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(false);
        toppanel.SetActive(true); //HERE!
    }
   
    public void OpenPanelLegs()
    {
        panel.SetActive(false);
        beardpanel.SetActive(false);
        toppanel.SetActive(false);
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
        legspanel.SetActive(false);
        glovespanel.SetActive(false);
        accpanel.SetActive(false);
        skincolorpanel.SetActive(false);
        haircolorpanel.SetActive(true); //HERE!
    }
   

}
