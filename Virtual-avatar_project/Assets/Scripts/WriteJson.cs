using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WriteJson : MonoBehaviour {

    /*This might not be used because we might actually do this with SQL instead of Json*/

    // Use this for initialization
    void Start() {

    }

    

	
}

public class Character
{
    public int ID;
    public string name;
    public int level;
    // Stats are Strength Intelligence and Charisma.
    public float Strength;
    public float Intelligence;
    public float Charisma;
    // avatar includes Hair/hat, Face, beard, coat, shirt, pants with shoes and accessories.
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
