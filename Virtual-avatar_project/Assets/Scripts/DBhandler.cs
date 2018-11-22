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
    public int ID;
    public string Name;
    public int Level;
    public int Coins;
    // Stat list.
    public float Strength;
    public float Intelligence;
    public float Charisma;
    // List of IDs for avatar bodyparts: Hair/hat, Face, beard, coat, shirt, pants with shoes and accessories.
    public int Body;
    public int Hair;
    public int Face;
    public int Beard;
    public int Coat;
    public int Shirt;
    public int Gloves;
    public int Pants;
    public int Accessories;
    


    public Character(int ID, string Name, int Level, float Strength, float Intelligence, float Charisma, int Body, int Hair, int Face, int Beard, int Coat, int Shirt, int Gloves, int Pants, int Accessories, int Coins)
    {
        this.ID = ID;
        this.Name = Name;
        this.Level = Level;
        this.Strength = Strength;
        this.Intelligence = Intelligence;
        this.Charisma = Charisma;
        this.Body = Body;
        this.Hair = Hair;
        this.Face = Face;
        this.Beard = Beard;
        this.Coat = Coat;
        this.Shirt = Shirt;
        this.Gloves = Gloves;
        this.Pants = Pants;
        this.Accessories = Accessories;
        this.Coins = Coins;

    }
}
