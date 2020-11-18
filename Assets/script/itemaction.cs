using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemaction : MonoBehaviour {
    public float mini = 3f;
    public float maxi = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float action = Random.Range(mini, maxi);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -action);
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
