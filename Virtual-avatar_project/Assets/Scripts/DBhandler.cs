using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class DBhandler : MonoBehaviour {


    string hash = "InsertHashHere";
    string formNick = "InsertNicknameHere";
    string formPass = "InsertFormPasswordHerer";
    WWWForm form;
    private WWW www;
    string formText;
    string passWarning;

    IEnumerator Login()
    {
        form = new WWWForm();
        form.AddField("Myform_hash", hash);
        form.AddField("myformnick", formNick);
        form.AddField("myFormPass", formPass);

        www = new WWW("insert address here/scripts/check_user.php", form);
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
    public string name;
    public int level;
    // Stat list.
    public float Strength;
    public float Intelligence;
    public float Charisma;
    // List of IDs for avatar bodyparts: Hair/hat, Face, beard, coat, shirt, pants with shoes and accessories.
    public int Hair;
    public int Face;
    public int Beard;
    public int Coat;
    public int Shirt;
    public int Pants;
    public int Accessories;


    public Character(int id, string name, int level, float Strength, float Intelligence, float Charisma, int Hair, int Face, int Beard, int Coat, int Shirt, int Pants, int Accessories)
    {
        this.ID = id;
        this.name = name;
        this.level = level;
        this.Strength = Strength;
        this.Intelligence = Intelligence;
        this.Charisma = Charisma;
        this.Hair = Hair;
        this.Face = Face;
        this.Beard = Beard;
        this.Coat = Coat;
        this.Shirt = Shirt;
        this.Pants = Pants;
        this.Accessories = Accessories;

    }
}
