using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spownSp : MonoBehaviour
{
    public GameObject diskas;
   
    public int numObjects;
    public GameObject Spike;
    void Start()
    {
       
       
        for (int i = 0; i < numObjects; i++)
        {
            int a = 360 / numObjects * i;
            Vector3 pos = RandomCircle(diskas.transform.position, 6.67f, a);
            if (a <= 180)
            {
                float rotationDeg = -1 * a;
             //   Debug.Log(rotationDeg+"+");
                Vector3 just = new Vector3(0, 0, rotationDeg);
                Quaternion rotation =Quaternion.Euler( just);
                Instantiate(Spike, pos, rotation);
            }
            else {
                float rotationDeg = 180-(a-180);
                Vector3 just = new Vector3(0, 0, rotationDeg);
                Quaternion rotation = Quaternion.Euler(just);
             //   Debug.Log(rotationDeg + "+");
               
                Instantiate(Spike, pos, rotation);
            }
        }
    }
    void Update() {

       
    }
    Vector3 RandomCircle(Vector3 center, float radius, int a)
    {
    //    Debug.Log(a);
        float ang = a;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}