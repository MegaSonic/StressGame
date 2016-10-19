using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SavedTimes : MonoBehaviour {

    public int roomEXP;
    public int schoolEXP;
    public List<float> timeData;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
