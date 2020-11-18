using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balldestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 ball = this.transform.position;
        Camera camera = Camera.main;
        Vector3 pos = camera.WorldToViewportPoint(ball);
        if (pos.y < 0)
        {
            Destroy(this.gameObject);
        }
	}
}
