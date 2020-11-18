using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itempop : MonoBehaviour {
    public GameObject[] ball;
    int n = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        n++;
        if (n > 120)
        {
            GameObject obj = ball[0];
            float x = Random.Range(-45, 45);
            float y = Random.Range(-10, 20);
            n = 0;
            Instantiate(obj, new Vector3(x, y, 0f), Quaternion.identity);
        }
    }
}
