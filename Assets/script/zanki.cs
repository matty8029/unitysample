using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class zanki : MonoBehaviour {
    int shield=0;
 
    // Use this for initialization
    void Start () {
        shield=PlayerPrefs.GetInt("shield", 0);
        GetComponent<Text>().text = ((int)shield).ToString();
    }
	
	// Update is called once per frame
	void Update () {
        shield = PlayerPrefs.GetInt("shield", 0);
        GetComponent<Text>().text = ((int)shield).ToString();
    }
}
