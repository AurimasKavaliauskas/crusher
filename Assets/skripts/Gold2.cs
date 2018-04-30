using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold2 : MonoBehaviour {
    public GameObject Gold3;
   
     int currentGoldNugetHP=5;
    // Use this for initialization
    void Start () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
      //  Debug.Log("colide IF");

        if (col.gameObject.tag == "Spike")
        {
     //       Debug.Log("colide IF"+currentGoldNugetHP);
            currentGoldNugetHP -= 1;
        //    Destroy();
            //    Instantiate(damageTakenParticle, transform.position, transform.rotation);
        }
        if (col.gameObject.tag == "Lubos" || col.gameObject.tag == "floor" || col.gameObject.tag == "SellP")
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
        Destroy();
    }
    void Destroy() {
        if (currentGoldNugetHP <= 0)
        {
                Instantiate(Gold3,gameObject.transform.position,Quaternion.identity);
              Instantiate(Gold3, gameObject.transform.position, Quaternion.identity);
            Instantiate(Gold3, gameObject.transform.position, Quaternion.identity);
           // Debug.Log("colide IF"+transform);
            //    Instantiate(Gold3, transform);
            Destroy(gameObject);
        }
    }
}
