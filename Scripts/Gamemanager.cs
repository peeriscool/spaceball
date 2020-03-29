using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    public Text Countdown;
    public GameObject player1;
    public GameObject player2;
    public walking player1control;
    public walking player2control;
    public shoot gun1;
    public shoot gun2;
    public Text scoreplayer1;
    public Text scoreplayer2;
    public Canvas puntencanvas;
    public static int score1;
    public static int score2;

    private static Gamemanager instance;
    //public Statemachine Rounds;
    public static Gamemanager Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<Gamemanager>();
            return instance;
        }
    }
    public void add2score(string scorename)
    {
        if (scorename == "goal1") { score2 = +1; }
        if (scorename == "goal") { score1 = +1; }
    }
    public void OnLevelWasLoaded()
    {
        Debug.Log("check for new round?");
        //scoreplayer1.text = ;
     //   Destroy(GameObject.Find("Canvas (1)"));
    }
    
}
