using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timecount : MonoBehaviour {
    public float maxtime =180f;
	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = ((int)maxtime).ToString();
	}

    // Update is called once per frame
    void Update() {
        maxtime -= Time.deltaTime; 
        GetComponent<Text>().text = ((int)maxtime).ToString();
        if (maxtime < 0) { 
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("clear");
        }
    }
}
