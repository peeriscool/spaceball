using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hellostate : Basestate
{
    private TestingState _testingstate; //cache
    Text CountdownDisplay;                                    // Start is called before the first frame update                             
    float currCountdownValue;
    float timeLeft = 3f;
    Renderer changematerial;
    public hellostate(TestingState testingstate): base(testingstate.gameObject) //?
    {
        CountdownDisplay = Gamemanager.Instance.Countdown;
        Gamemanager.Instance.player1control.enabled = false;
        Gamemanager.Instance.player2control.enabled = false;
        Gamemanager.Instance.gun1.enabled = false;
        Gamemanager.Instance.gun2.enabled = false;
        changematerial = gameObject.GetComponent<Renderer>();
        tick();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public override Type tick()
    {
        
        if ( time() == true)
        {
          
            
        return typeof(InRound);
        }

        return null;
    }
   bool time()
    {
        timeLeft -= Time.deltaTime;
        int display = (int)timeLeft;
        CountdownDisplay.text = display.ToString();
        //Debug.Log(timeLeft);
        if (timeLeft < 1)
        {
            CountdownDisplay.text = "go!";
           
            changematerial.material.color = Color.green;
        }
        if (timeLeft < 0)
        {
            return true;
        }
            return false;
        //timeLeft -= Time.deltaTime;
        //if (timeLeft < 0)
        //{
        //    return true;
        //}
        //return false;
       
    }



}
