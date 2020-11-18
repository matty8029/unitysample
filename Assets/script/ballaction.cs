using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballaction : MonoBehaviour {
    public float min = 3f;
    public float max = 25f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float action = Random.Range(min, max);
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
