using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    void Start()
    {
       
    }
    public void assignsomevalues()
    {

    }
   
    void Update()
    {
        
    }
}
