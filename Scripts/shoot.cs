using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public int force;
   private waitingscript shootwait;
    bool pressed;
  //  bool pressed2;
    // Start is called before the first frame update
    void Start()
    {
        shootwait = new waitingscript();
        pressed = true;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetButton("Jump") == true && this.name == "shoot location")
        {
          
           
            if (pressed == true)
            {          
                pressed = shootwait.waituntil(1, this);  
                    GameObject forcebullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
                    forcebullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
            }
            if (pressed == false)
            {
                pressed = shootwait.waited;
            } 
        }

        if (Input.GetButton("Fire controller") == true && this.name == "shoot location2")
        {
            if (pressed == true)
            {
                pressed = shootwait.waituntil(1, this);
                GameObject forcebullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
                forcebullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);
            }
            if (pressed == false)
            {
                pressed = shootwait.waited;
            }
        }
    }
}
