using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemachine : MonoBehaviour
{

    private Dictionary<Type, Basestate> _availiblestates;

    public Basestate Currrentstate { get; private set; }
    public event Action<Basestate> OnstateChanged;
  
    // Start is called before the first frame update
    public void setstates(Dictionary<Type, Basestate> states)
    {
        _availiblestates = states; //makes the states availible for choice
    }

    // Update is called once per frame
    void Update()
    {
        if (Currrentstate == null)
        {
            //  Currrentstate = _availiblestates.Values.first() ; //pakt de eerste state in de dictonary van states, maar je kunt geen First() gebruiken
            foreach (Basestate value in _availiblestates.Values) //gaat door elk mogelijke state om te zoeken naar de eerste
            {
               
                if (value == _availiblestates[typeof(hellostate)])
                {
                    //Debug.Log("make active state:"+ value);
                    Currrentstate = value; //zet de eerste state naar de hellostate
                    Debug.Log("state is" + value);
                }

            }
        }
            var nextstate = Currrentstate?.tick();

            if (nextstate != null && nextstate != Currrentstate?.GetType())  //als er gevraagt word om een nieuwe state switch hiernaar (aanspreekbaar met return typeof(hellostate);)
            {
                Debug.Log("switching state");
                SwitchToNewState(nextstate);
            }
        } 
            void SwitchToNewState(Type nextstate)  // in voorbeeld is deze klasse private 
        {
            Currrentstate = _availiblestates[nextstate];
            OnstateChanged?.Invoke(Currrentstate);
        }
       // Debug.Log("statemachine is running");
    }
    //a question mark in a method is indicating that this code will not throw a NullReferenceException exception if handler is null: example : OnstateChanged?.Invoke(Currrentstate);
    //? means nullable