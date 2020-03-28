using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if(collision.collider.tag == "bal" )
        {
            Debug.Log("er is gescoord");
            if(this.name == "goal1")
            { 
                Gamemanager.Instance.scoreplayer1.text = "1";
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
            }
            if (this.name == "goal")
            {
                Gamemanager.Instance.scoreplayer2.text = "1";
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
            }
        }
    }
}
