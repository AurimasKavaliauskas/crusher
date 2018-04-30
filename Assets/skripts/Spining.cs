using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spining : MonoBehaviour
{
    public GameObject Spike;
    public float Speed;
    Vector3 axisLeft = new Vector3(-6.70f, 0, 0);//asis sukimosi
    Vector3 axisRight = new Vector3(6.70f, 0, 0);//asis sukimosi
                                                 // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Orbit();//spining sukimasis 
    }
    void Orbit()
    {
        if (gameObject.transform.position.x > 0)
        {
            transform.RotateAround(axisRight, Vector3.forward, Speed*Time.deltaTime);
        }
        else
        {
            transform.RotateAround(axisLeft, Vector3.back, Speed*Time.deltaTime);
        }
    }
}