using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class herosqript : MonoBehaviour {
    Rigidbody2D rb;
    int jump=0;
    public int shield = 0;
    // Use this for initialization
   public void Start() {
        PlayerPrefs.SetInt("shield", shield);
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    public void Update() {
        idou();
        check();
    }
    public void check()
    {
        Vector3 Player = this.transform.position;
        Camera camera = Camera.main;
        Vector3 pos = camera.WorldToViewportPoint(Player);
        if (pos.y < 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("result");
        }
    }
    public void idou()
    {
        if (jump < 3)
            if (Input.GetKeyDown(KeyCode.Space))
                 {
                    rb.AddForce(new Vector2(0, 250f), ForceMode2D.Force);
                    jump++;
                }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-15, 0), ForceMode2D.Force);
            if (jump < 3)
                if (Input.GetKeyDown(KeyCode.Space))
                    {
                        rb.AddForce(new Vector2(0, 250f), ForceMode2D.Force);
                        jump++;
                     }
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(15, 0), ForceMode2D.Force);
            if (jump < 3)
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb.AddForce(new Vector2(0, 250f), ForceMode2D.Force);
                    jump++;
                }
        }
    }
    public void OnCollisionEnter2D(Collision2D col)       
    {
        if (col.gameObject.tag == "Square")
        {
            jump = 0;
        }
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ball")
        {
            if (shield == 0)
                UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("result");
            else
                shield = shield - 1;
        }
        if (col.gameObject.tag == "item")
        {
            shield++;
        }
        PlayerPrefs.SetInt("shield", shield);
    }
    public int zanki()
    {
        return shield;
    }
}
