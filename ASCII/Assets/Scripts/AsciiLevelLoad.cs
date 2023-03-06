using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using System.IO;
using File = System.IO.File;


public class AsciiLevelLoad : MonoBehaviour
{
    public GameObject Circle;
    public GameObject Triangle;
    public GameObject Square;
    public GameObject ComputerPlayer;
    public GameObject Cylinder;

    private GameObject currentComputer;
    
    private GameObject level;

    private int currentLevel = 0;

    public Vector2 computerStartPos;

    public int CurrentLevel
    {
        get { return currentLevel;  }
        set
        {
            currentLevel = value;
            LoadLevel();
        }
    }

    private const string FILE_NAME = "LevelNum.txt";
    private const string FILE_DRIVE = "/Levels/";
    private string FILE_PATH;

    public float xOffset; //offsets the x and y var
    public float yOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        FILE_PATH = Application.dataPath + FILE_DRIVE + FILE_NAME; //directory

        LoadLevel(); //load this function on start
        
    }

    bool LoadLevel()
    {
        Destroy(level);

        level = new GameObject("Level");

        string newPath = FILE_PATH.Replace("Num", currentLevel + "");//replace the num with the level number
        
        //load all the lines of the file into an array of strings
        string[] fileLines = File.ReadAllLines(newPath);
        
        //for loop to go through each line
        for (int yPos = 0; yPos < fileLines.Length; yPos++)
        {
            //get each line out of the array
            string lineText = fileLines[yPos];
            
            //turn the current line into an array of chars (chars are characters)
            char[] lineChars = lineText.ToCharArray();
            
            //loop through each char
            for (int xPos = 0; xPos < lineChars.Length; xPos++)
            {
                //get the current char
                char c = lineChars[xPos];
                
                //make a var for a new gameobject
                GameObject newObj;
                
                //switch is a more compact way of doing many different if statements
                //break, breaks the loop once it found what its looking for
                switch (c)
                {
                    case 'p'://computer is the char a p?
                        computerStartPos = new Vector2(xOffset + xPos, yOffset - yPos);
                        newObj = Instantiate<GameObject>(ComputerPlayer); //then make a new player
                        currentComputer = newObj;
                        break;
                    case 'y': //cylinder is the char a y?
                        newObj = Instantiate<GameObject>(Cylinder); //make a new cylinder
                        break;
                    case 't': //is there a t?
                        newObj = Instantiate<GameObject>(Triangle);//make a triange
                        break;
                    case 'c':
                        newObj = Instantiate<GameObject>(Circle);
                        break;
                    case 's':
                        newObj = Instantiate<GameObject>(Square);
                        break;
                    default: //otherwise (like else in an if statement)
                        newObj = null; //it is null
                        break;
                }
                //if we made a new GameObject
                if (newObj != null)
                {
                    //position it based on where it was
                    //in the file, using the variables
                    //we used to loop through our arrays
                    newObj.transform.position =
                        new Vector2(
                            xOffset + xPos,
                            yOffset - yPos);

                    newObj.transform.parent = level.transform;
                }
                
            }
        }

        return false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetComputer() //resets the player upon collision
    {
        currentComputer.transform.position = computerStartPos;
        Debug.Log("reset");
    }
    
    public void LevelUp() //goes to the next level
    {
        Debug.Log("hit on mouse down");
        CurrentLevel++;
    }
}
