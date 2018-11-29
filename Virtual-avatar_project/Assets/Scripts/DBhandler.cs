using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class DBhandler : MonoBehaviour {

    //Login form stuff
    string hash = "InsertHashHere";
    string formNick = "InsertNicknameHere";
    string formPass = "InsertFormPasswordHerer";
    WWWForm form;
    private WWW www;
    string formText;
    string passWarning;

    IEnumerator Login()
    {
        //Creates Form Connection
        form = new WWWForm();
        form.AddField("Myform_hash", hash); // Adds Hash to the field;
        form.AddField("myformnick", formNick);
        form.AddField("myFormPass", formPass);

        //Calls server script
        www = new WWW("insert address here/scripts/check_user.php", form);
        //Waits for the form to check PHP file, so the game wont hang
        yield return www;

        if (www.error != null)
        {
            //error getting the result
            Debug.Log("Error 404 user script not found");
        }
        else
        {
            formText = www.text.Trim();
            Debug.Log("Result: " + formText);
            // If credentials are correct we log in.
            if (formText == "Correct")
            {
                // Insert login code and stat calls here

            }
            www.Dispose();
        }
        formPass = ""; // Clear pass if wrong
        passWarning = "wrong username or password";
    }
    //Insert UI Functions here

}
public class Character
{
    private int ID;
    private string Name;
    private int Level;
    private int Coins;
    // Stat list.
    private float Strength;
    private float Intelligence;
    private float Charisma;

    // List of IDs for avatar bodyparts: Hair/hat, Face, beard, coat, shirt, pants with shoes and accessories. 
    // IMPORTANT --> USE ENUMS FOR GETTING SPRITE IDs <-- IMPORTANT
    private int Body;
    private int Hair;
    private int Face;
    private int Beard;
    private int Coat;
    private int Shirt;
    private int Gloves;
    private int Pants;
    private int Accessories;
    
    public int GetID()
    {
        return ID;
    }
    public void SetID(int NewID)
    {
        ID = NewID;
    }

    public string GetName()
    {
        if (Name != null && Name.Length != 0)
        {
            return Name;
        }
        else
        {
            return "Name not set yet";
        }
    }
    public void SetName(string NewName)
    {
        if (NewName.Length != 0)
        {
            Name = NewName;
        }
    }

    public int GetLevel()
    {
        return Level;
    }
    public void SetLevel(int NewLevel)
    {
        Level = NewLevel;
    }

    public int GetCoins()
    {
        return Coins;
    }
    public void SetCoins(int NewCoins)
    {
        Coins = NewCoins;
    }

    public float GetStr()
    {
        return Strength;
    }
    public void SetStr(float NewStr)
    {
        Strength = NewStr;
    }

    public float GetInt()
    {
        return Intelligence;
    }
    public void SetInt(float NewInt)
    {
        Intelligence = NewInt;
    }

    public float GetCha()
    {
        return Charisma;
    }
    public void SetCha(float NewCha)
    {
        Charisma = NewCha;
    }

    public int GetBody()
    {
        return Body;
    }
    public void SetBody(int NewBody)
    {
        Body = NewBody;
    }

    public int GetHair()
    {
        return Hair;
    }
    public void SetHair(int NewHair)
    {
        Hair = NewHair;
    }

    public int GetFace()
    {
        return Face;
    }
    public void SetFace(int NewFace)
    {
        Face = NewFace;
    }

    public int GetBeard()
    {
        return Beard;
    }
    public void SetBeard(int NewBeard)
    {
        Beard = NewBeard;
    }

    public int GetCoat()
    {
        return Coat;
    }
    public void SetCoat(int NewCoat)
    {
        Coat = NewCoat;
    }

    public int GetShirt()
    {
        return Shirt;
    }
    public void SetShirt(int NewShirt)
    {
        Shirt = NewShirt;
    }

    public int GetGloves()
    {
        return Gloves;
    }
    public void SetGloves(int NewGloves)
    {
        Gloves = NewGloves;
    }

    public int GetPants()
    {
        return Pants;
    }
    public void SetPants(int NewPants)
    {
        Pants = NewPants;
    }

    public int GetAccessories()
    {
        return Accessories;
    }
    public void SetAccessories(int NewAccessories)
    {
        Accessories = NewAccessories;
    }
}
// Figure this shit out. How it should be done? 1 enum or enum per body part?
enum Hair
{
    
}
enum Face
{

}
enum Beard
{

}
enum Coat
{

}
enum Shirt
{

}
enum Gloves
{

}
enum Pants
{

}
enum Accessories
{

}