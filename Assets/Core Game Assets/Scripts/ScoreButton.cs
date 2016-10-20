using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ReturnToTitle()
    {
        SavedTimes save = GameObject.FindObjectOfType<SavedTimes>();
        IconSelect icon = GameObject.FindObjectOfType<IconSelect>();
        Destroy(save.gameObject);
        Destroy(icon.gameObject);
        SceneManager.LoadScene("Opening");

    }
}
