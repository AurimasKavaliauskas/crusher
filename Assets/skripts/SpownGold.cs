using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownGold : MonoBehaviour {

    public GameObject Gold1;
    static float spownSpeed;
    static Vector3 spownPoint;
    bool isSpawning;
    // Use this for initialization
    void Start () {
        spownSpeed = 1;
        isSpawning = false;
    }
    IEnumerator SpawnObject(float seconds)
    {
        //Debug.Log("Waiting for " + seconds + " seconds");

        yield return new WaitForSeconds(seconds);
        Vector3 V = new Vector3(Random.Range(-3.0f, 3.0f), gameObject.transform.position.y, 0);
        Instantiate(Gold1, V, Quaternion.identity);
        isSpawning = false;
    }
        // Update is called once per frame
        void Update () {
        if (!isSpawning)
        {
            isSpawning = true;
         //   Debug.Log("updaitinu");
            StartCoroutine(SpawnObject(spownSpeed));
        }

    }
}
