using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Person
{
    //yes should be private but again cbf writing 10 getters and setters
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
        magic = 0;
        health = 10;
        charisma = 3;
        favour = 2;

    }
    //Other properties, methods, events... -- event can be it's own object
}

public class Event
{
    private int EvNum;
    public Event()
    {
      
    }



}


public class MainGameScript : MonoBehaviour {
    //the array for player information - need to change it to a map or something
    Person[] player = new Person[6];
    int turnNum;
    int playerNum;
    //idk other non player specific stats go here
	// Use this for initialization
    //need to think of an easy way for loading in events/options - load from file?
	void Start () {
        turnNum = 0;
        // do this up to the num of players - use a map instead maybe?
        player[0] = new Person();
        //ReadFile("Event.txt");
	}
	
    //need method to show current stats - done
    //need method for generating random events - need load from file first
    //need method for clicking on buildings - todo

    public void NewTurn()
    {
        turnNum++;
        string myString = turnNum.ToString();
        GameObject.Find("Turn Num").GetComponentInChildren<Text>().text = string.Concat("Turn", myString);
        Debug.Log("new turn");
    }

    //displays current player's stats
    public void ShowStats()
    {
        string myString = player[playerNum].intelligence.ToString();
        GameObject.Find("Int").GetComponentInChildren<Text>().text = string.Concat("Intelligence ", myString);
        myString = player[playerNum].strength.ToString();
        GameObject.Find("Strength").GetComponentInChildren<Text>().text = string.Concat("Strength ", myString);
        myString = player[playerNum].dexterity.ToString();
        GameObject.Find("Dexterity").GetComponentInChildren<Text>().text = string.Concat("Dexterity ", myString);
        myString = player[playerNum].charisma.ToString();
        GameObject.Find("Charisma").GetComponentInChildren<Text>().text = string.Concat("Charisma ", myString);
        myString = player[playerNum].gold.ToString();
        GameObject.Find("Gold").GetComponentInChildren<Text>().text = string.Concat("Gold ", myString);
        //find out how to create text boxes from script
        //find out how to change text in non children boxes - may not be possible
        //find out how to attach script that causes text box to appear and update when another button is clicked - may have to link the text to the button

    }

    //read in all event info from file
    //loop around until all events are read
    //remember to put in error handling cause otherwise this could break badly
    private void ReadFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        //need a char to specify a new event in the file
        //file read in shall be
        //L1 Event num
        //L2 Num of options
        //L3 event text
        //L4- text option 1
        //L5 text - I need to talk about this on Friday for how events will be shown

    }

    // Update is called once per frame
    //probs don't need this
    void Update () {
		
	}
}
