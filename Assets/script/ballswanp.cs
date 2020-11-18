using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballswanp : MonoBehaviour {
    public GameObject[] ball;
    int n = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        n++;
        if (n>15)
        {
            GameObject obj = ball[0];
            float x = Random.Range(-45,45);
            n = 0;
            Instantiate(obj, new Vector3(x, 20f, 0f), Quaternion.identity);
        }
	}
}
