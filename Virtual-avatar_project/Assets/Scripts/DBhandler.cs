using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

/*
 Original Creator and the Curser of this script: Janne Karhu TTK18S
 All of this remains untested and unimplementd to this date so it might or might not work, but theoretically it should work.
*/
public class DBhandler : MonoBehaviour
{

    //Fetch the data from SQL Database somehow    
    //Also saving the values to SQL Database might be a good idea to be implemented

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
    // IDs are used in Get*InsertBodypartHere* for fetching the sprites.. sprites need to be named with numbers eg. 1, 2, 3 etc.
    private int Body;
    private int Hair;
    private int Face;
    private int Beard;
    private int Coat;
    private int Shirt;
    private int Gloves;
    private int Pants;
    private int Accessories;
    // Call the Set*whatevers when Fetching the values form DB.
    // The Gets are should be used in the editor or whenever you need to use these values.
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

    // ID getters and setters for bodyparts 
    // Remember to rename sprites to numbers in folders
    public int GetBody()
    {
        Sprite bodySprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Body Type/"+ Body + ".png");
        return Body;
    }
    public void SetBody(int NewBody)
    {
        Body = NewBody;
        
    }

    public int GetHair()
    {
        // Checks the bodytype and changes the sprite from the proper bodytype according to ID.
        
        while (Body == 1)
        {
            //This line should hopefully work but i am not entirely sure since i have not been able to test it
            Sprite hairSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Childlike/Hair/" + Hair + ".png");
        }
        while (Body == 2)
        {
            Sprite hairSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Female/Hair/" + Hair + ".png");
        }
        while (Body == 3)
        {
            Sprite hairSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Slim/Hair/" + Hair + ".png");
        }
        while (Body == 4)
        {
            Sprite hairSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Muscular/Hair/" + Hair + ".png");
        }
        return Hair;
    }
    public void SetHair(int NewHair)
    {
        Hair = NewHair;
    }

    public int GetFace()
    {
        while (Body == 1)
        {
            Sprite FaceSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Faces/" + Face + ".png");
        }
        while (Body == 2)
        {
            Sprite FaceSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Faces/" + Face + ".png");
        }
        while (Body == 3)
        {
            Sprite FaceSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Faces/" + Face + ".png");
        }
        while (Body == 4)
        {
            Sprite FaceSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Faces/" + Face + ".png");
        }
        return Face;
    }
    public void SetFace(int NewFace)
    {
        Face = NewFace;
    }

    public int GetBeard()
    {
        while (Body == 1)
        {
            Sprite BeardSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Childlike/Beard/" + Beard + ".png");
        }
        while (Body == 2)
        {
            Sprite BeardSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Female/Beard/" + Beard + ".png");
        }
        while (Body == 3)
        {
            Sprite BeardSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Slim/Beard/" + Beard + ".png");
        }
        while (Body == 4)
        {
            Sprite BeardSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Muscular/Beard/" + Beard + ".png");
        }
        return Beard;
    }
    public void SetBeard(int NewBeard)
    {
        Beard = NewBeard;
    }

    public int GetCoat()
    {
        while (Body == 1)
        {
            Sprite CoatSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Childlike/Coat/" + Coat + ".png");
        }
        while (Body == 2)
        {
            Sprite CoatSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Female/Coat/" + Coat + ".png");
        }
        while (Body == 3)
        {
            Sprite CoatSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Slim/Coat/" + Coat + ".png");
        }
        while (Body == 4)
        {
            Sprite CoatSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Muscular/Coat/" + Coat + ".png");
        }
        return Coat;
    }
    public void SetCoat(int NewCoat)
    {
        Coat = NewCoat;
    }

    public int GetShirt()
    {
        while (Body == 1)
        {
            Sprite ShirtSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Childlike/Shirt/" + Shirt + ".png");
        }
        while (Body == 2)
        {
            Sprite ShirtSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Female/Shirt/" + Shirt + ".png");
        }
        while (Body == 3)
        {
            Sprite ShirtSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Slim/Shirt/" + Shirt + ".png");
        }
        while (Body == 4)
        {
            Sprite ShirtSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Muscular/Shirt/" + Shirt + ".png");
        }
        return Shirt;
    }
    public void SetShirt(int NewShirt)
    {
        Shirt = NewShirt;
    }

    public int GetGloves()
    {
        while (Body == 1)
        {
            Sprite GlovesSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Childlike/Gloves/" + Gloves + ".png");
        }
        while (Body == 2)
        {
            Sprite GlovesSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Female/Gloves/" + Gloves + ".png");
        }
        while (Body == 3)
        {
            Sprite GlovesSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Slim/Gloves/" + Gloves + ".png");
        }
        while (Body == 4)
        {
            Sprite GlovesSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Muscular/Gloves/" + Gloves + ".png");
        }
        return Gloves;
    }
    public void SetGloves(int NewGloves)
    {
        Gloves = NewGloves;
    }

    public int GetPants()
    {
        while (Body == 1)
        {
            Sprite PantsSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Childlike/Legs/" + Pants + ".png");
        }
        while (Body == 2)
        {
            Sprite PantsSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Female/Legs/" + Pants + ".png");
        }
        while (Body == 3)
        {
            Sprite PantsSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Slim/Legs/" + Pants + ".png");
        }
        while (Body == 4)
        {
            Sprite PantsSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Muscular/Legs/" + Pants + ".png");
        }
        return Pants;
    }
    public void SetPants(int NewPants)
    {
        Pants = NewPants;
    }

    public int GetAccessories()
    {
        while (Body == 1)
        {
            Sprite AccSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Childlike/Acc/" + Accessories + ".png");
        }
        while (Body == 2)
        {
            Sprite AccSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Female/Acc/" + Accessories + ".png");
        }
        while (Body == 3)
        {
            Sprite AccSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Slim/Acc/" + Accessories + ".png");
        }
        while (Body == 4)
        {
            Sprite AccSprite = Resources.Load<Sprite>("Assets/Sprites/Artti/Male Muscular/Acc/" + Accessories + ".png");
        }
        return Accessories;
    }
    public void SetAccessories(int NewAccessories)
    {
        Accessories = NewAccessories;
    }
}