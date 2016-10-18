using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SavedTimes : MonoBehaviour {

    public List<TimeData> timeData;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

[System.Serializable]
public struct TimeData
{
    public string name;
    public float time;
}