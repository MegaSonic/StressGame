using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IconSelect : MonoBehaviour {

    public int icon1;
    public int icon2;

    public bool choicesLockedIn = false;

    public SuperTextMesh text;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void MakeChoice(int id)
    {
        if (icon1 == -1)
        {
            icon1 = id;
            text.text = "Select <w><c=red>one</c></w> activity to focus on!";
            text.Rebuild();

        }
        else if (icon2 == -1)
        {
            icon2 = id;
            choicesLockedIn = true;
            SceneManager.LoadScene("MainGame");
        }
    }
}
