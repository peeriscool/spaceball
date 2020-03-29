using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buff : MonoBehaviour
{
    int player;
    // Update is called once per frame
    private void Start()
    {
    }
    void Update()
    {
        Debug.Log("u got the buff");
         if (this.name == "Main Camera")
         {
            Debug.Log("player1");
            Gamemanager.Instance.buffactive1.enabled = true;
            player = 1;
           // Destroy(this);
        }
        if (this.name == "Second Camera")
        {
            Debug.Log("player2");
            Gamemanager.Instance.buffactive2.enabled = true;
            // Destroy(this);
            player = 0;
        }

        if (Input.GetButton("Fire2") == true && player == 1)
        {
            Debug.Log("uhm hallo?");
            Gamemanager.Instance.gun2.enabled = false;
            retardtimer(3f);
        }
        if (Input.GetButton("Fire controllerbuff") == true && player == 0)
        {
            Debug.Log("uhm hallo?2");
            Gamemanager.Instance.gun1.enabled = false;
            retardtimer(3f);
        }

    }

    public void retardtimer(float timeLeft)
    {
        Debug.Log("werk gewoon");
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("gewoon");
            Gamemanager.Instance.gun1.enabled = true;
            Gamemanager.Instance.gun2.enabled = true;
            Gamemanager.Instance.gun2.GetComponent<shoot>().enabled = true;
            Gamemanager.Instance.gun1.GetComponent<shoot>().enabled = true;
        }
    }
}
