using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitingscript
{
    //public float duration;
   // private float localDuration;
    float valuechanger;
   public bool waited = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator timer(float duration)
    {
        while (duration > 0)
        {
            yield return new WaitForSeconds(0.2f);
            duration--;
        } 
        waited = true;
        yield break;
    }

    public float time2value (float duration,float valuetochange, MonoBehaviour mono)
    {
        valuechanger = valuetochange;
        mono.StartCoroutine(timer(duration, valuechanger));
        return valuechanger;
    }
    public IEnumerator timer(float duration,float localchangevalue)
    {
      float  localDuration = duration;
        localchangevalue=localchangevalue/2;
        while (localDuration > 0)
        {
            yield return new WaitForSeconds(1.0f);
            localDuration--;
        }
        valuechanger = localchangevalue;
    }
    public bool waituntil(float duration, MonoBehaviour mono)
    {
        mono.StartCoroutine(timer(duration));
       // Debug.Log("waited" + waited);
        bool returner = waited;
        waited = false;
        return returner;
    }
}
