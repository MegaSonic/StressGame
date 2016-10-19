using UnityEngine;
using System.Collections;
using System;

public class Icon : MonoBehaviour, IInteractable {


    public int id;
    public float timeToAdvance;

    public SavedTimes save;
    private Clock clock;

    public void Interact()
    {
        clock.AdvanceTime(timeToAdvance);
        save.timeData[id]++;
        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        clock = GameObject.FindObjectOfType<Clock>();
        save = GameObject.FindObjectOfType<SavedTimes>();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
