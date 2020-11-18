using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("zemi");
        }
        if (Input.GetKey(KeyCode.T))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("title");
        }
    }
}
