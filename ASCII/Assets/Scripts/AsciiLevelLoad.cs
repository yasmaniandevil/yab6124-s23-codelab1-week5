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

    public float xOffset;
    public float yOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        FILE_PATH = Application.dataPath + FILE_DRIVE + FILE_NAME; //directory

        LoadLevel();
        
    }

    bool LoadLevel()
    {
        Destroy(level);

        level = new GameObject("Level");

        string newPath = FILE_PATH.Replace("Num", currentLevel + "");

        string[] fileLines = File.ReadAllLines(newPath);

        for (int yPos = 0; yPos < fileLines.Length; yPos++)
        {
            string lineText = fileLines[yPos];

            char[] lineChars = lineText.ToCharArray();

            for (int xPos = 0; xPos < lineChars.Length; xPos++)
            {
                char c = lineChars[xPos];

                GameObject newObj;

                switch (c)
                {
                    case 'p'://computer
                        computerStartPos = new Vector2(xOffset + xPos, yOffset - yPos);
                        newObj = Instantiate<GameObject>(ComputerPlayer);
                        currentComputer = newObj;
                        break;
                    case 'y': //cylinder
                        newObj = Instantiate<GameObject>(Cylinder);
                        break;
                    case 't':
                        newObj = Instantiate<GameObject>(Triangle);
                        break;
                    case 'c':
                        newObj = Instantiate<GameObject>(Circle);
                        break;
                    case 's':
                        newObj = Instantiate<GameObject>(Square);
                        //newObj.transform.position = new Vector2(5, 3);
                        break;
                    default:
                        newObj = null;
                        break;
                }

                if (newObj != null)
                {
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

    public void ResetComputer()
    {
        currentComputer.transform.position = computerStartPos;
        Debug.Log("reset");
    }
    
    public void LevelUp()
    {
        Debug.Log("hit on mouse down");
        CurrentLevel++;
    }
}
