using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold3 : MonoBehaviour {

    public float trackSpeed;
  public  bool onTrack;
    // Use this for initialization
    void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {Debug.Log("colide");
        if (col.gameObject.tag == "floor")
        {
            Debug.Log("colide IF");
            onTrack = true;   
            //    Instantiate(damageTakenParticle, transform.position, transform.rotation);
        }
    }
    public void Movement()
    {
        if (onTrack)
        {
 transform.Translate(Vector2.right * Time.deltaTime * trackSpeed);
        }
       
    }
    // Update is called once per frame
    void Update () {
        Movement();
      

    }
}
