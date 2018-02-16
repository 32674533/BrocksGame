using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Person
{
    public string Name;
    public int intelligence;
    public int strength;
    public int dexterity;
    public int gold;
    public int ID;
    public int magic;
    public int health;
    public int charisma;
    public int favour;

    //location - probs an int representative for a place
    public Person(string name, int age)
    {
        Name = name;
    }
    public Person()
    {
        Name = "unknown";
        intelligence = 3;
        strength = 3;
        dexterity = 3;
        gold = 100;
        ID = 0;

    }
    //Other properties, methods, events...
}



public class MainGameScript : MonoBehaviour {
    //the array for player information - need to change it to a map or something
    Person[] player = new Person[6];
    int turnNum;
    //idk other non player specific stats go here
	// Use this for initialization
    //need to think of an easy way for loading in events/options - load from file?
	void Start () {
        turnNum = 0;
	}
	
    //need method to show current stats
    //need method for generating random events
    //need method for clicking on buildings

    public void NewTurn()
    {
        turnNum++;


        string myString = turnNum.ToString();

        GameObject.Find("Turn Num").GetComponentInChildren<Text>().text = string.Concat("Turn", myString);
        Debug.Log("new turn");
        //find a way to change text on a utton
    }

	// Update is called once per frame
    //probs don't need this
	void Update () {
		
	}
}
