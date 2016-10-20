using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndingAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadScoreScreen()
    {
        SceneManager.LoadScene("Score");
    }
}
