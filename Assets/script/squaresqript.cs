using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squaresqript : MonoBehaviour {
    int n = 0;
    int a = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        n++;
        if (n % 50 == 0) a = -a;
        GetComponent<Rigidbody2D>().velocity = new Vector2(a, 0);
    }
}
