using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestingState : MonoBehaviour
{
    
    //[Serializable] public class classloader
    //{
    //    //zet de naam in editor
    //    #if UNITY_EDITOR   
    //            public string Name;
    //    #endif
    //    //description voor variables
    //}
    //[SerializeField] public classloader[] Classloader;

        //-------------------------------------------------------------------------------------------------------------------
        public Statemachine Statemachine => GetComponent<Statemachine>(); //aanmaken van een instantie van statemachine
   private void Awake()
    {
        initializeStatemachine();
    }

    private void initializeStatemachine() //aanroepen van de state machine en het vullen van de _avalible dictornary
    {
       
        var states = new Dictionary<Type, Basestate>() //type is de key, basestate is de value
        {
            
        { typeof(hellostate), new hellostate(this)},
            {typeof(InRound), new InRound(this)}

        };
       GetComponent<Statemachine>().setstates(states);
    }
}
