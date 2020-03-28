using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killyourself : MonoBehaviour
{
    public float tijd;
    // Start is called before the first frame update
    void Start()
    {
      //  Debug.Log("i exist!");
        StartCoroutine(ExecuteAfterTime(tijd));

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("miniboom") == true || Input.GetButton("miniboom joy") == true)
        {
            Debug.Log("depressie");
            this.GetComponent<explosion>().kleineeboem();
        }
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        this.GetComponent<explosion>().dikkeboem();
        StartCoroutine(ExecuteAfterexplosion(2));
        // Code to execute after the delay
    }
    IEnumerator ExecuteAfterexplosion(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
