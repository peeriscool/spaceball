using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InRound : Basestate
{
    bool start = false;                                                           
    float currCountdownValue;
    float timeLeft = 60f;
    // Start is called before the first frame update
    public InRound(TestingState testingstate): base(testingstate.gameObject)
    {
     //   Debug.Log("InRound is initialized");
    }

    public override Type tick()
    {
        if (start == false) //dit is niet optimaal
        {
        Start();

        }
        roundtime();
        return null;
        //throw new NotImplementedException(); //hier moet iets anders
    }
    void Start()
    {
        Gamemanager.Instance.player1control.enabled = true;
        Gamemanager.Instance.player2control.enabled = true;
      //  Gamemanager.Instance.Countdown.enabled = false;
        Gamemanager.Instance.gun1.enabled = true;
        Gamemanager.Instance.gun2.enabled = true;
        ;
        start = true;
    }
    void roundtime()
    {
        timeLeft -= Time.deltaTime;
        int display = (int)timeLeft;
        Gamemanager.Instance.Countdown.text = display.ToString();
        if (timeLeft < 0)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }
}
