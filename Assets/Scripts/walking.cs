using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float speed;
    public float localspeed;
    public int controllerNumber; 
    public float Duration;
    private float buffduration;
    private float cooldownduration;
    private float buffcooldown;
    int buffactive = 0;
    bool cooldownbuff = false;  
    // Start is called before the first frame update
    void Start()
    {
        localspeed = speed;
      
    }

    // Update is called once per frame
    void Update()
    {
      

        if (buffactive == 0 && Input.GetButton("Fire3") == true)
        {
            Debug.Log("run");
            buffactive = 1;
            StartCoroutine(runbuff(Duration));
           
        }
        if (cooldownbuff == true)
        {
            StartCoroutine(cooldown(Duration * Duration));
        //    StartCoroutine(longasscorrotine(Duration*20));
        }
        
        //-------------------------------------------------------------------------------
        if (controllerNumber == 0)
        {
            float translation = Input.GetAxis("Vertical") * localspeed;
            float translationy = Input.GetAxis("Horizontal") * localspeed;

            translation *= Time.deltaTime;
            translationy *= Time.deltaTime;

            transform.Translate(translationy, 0, translation);
        }
        if (controllerNumber == 1)
        {
            float translation = Input.GetAxis("Vertical controller") * localspeed;
            float translationy = Input.GetAxis("Horizontal controller") * localspeed;

            translation *= Time.deltaTime;
            translationy *= Time.deltaTime;

            transform.Translate(translationy, 0, translation);
        }
        //-------------------------------------------------------------------------------
    }
    public IEnumerator runbuff(float duration)
    {
        buffduration = duration;
        Debug.Log(localspeed);
        if (buffactive == 1)
        {
            localspeed = localspeed * 2;
        }
        while (buffduration > 0)
            {
            yield return new WaitForSeconds(1.0f);
                buffduration--;
            }
        Debug.Log("start cooldown");
        cooldownbuff = true;
        yield break;
    }
    public IEnumerator cooldown(float duration)
    {
        cooldownduration = duration;
        localspeed = speed * 0.4f;
      
        while (cooldownduration > 0)
        {  
            yield return new WaitForSeconds(1.0f);
            cooldownduration--;
        }
        localspeed = speed;
         buffactive = 0;
        cooldownbuff = false;

    }
}
