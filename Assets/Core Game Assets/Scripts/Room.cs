using UnityEngine;
using System.Collections;
using System;

public class Room : MonoBehaviour, IInteractable {

    public string roomName;
    public float currentEXP;
    public int currentRank;

    public float maxEXP;
    public int maxRank;
    public float expGainRate;

    public float timeBeforeDecay;
    public float decayRate;
    private float decayTimer;

    public Transform backgroundBox;

    public float timeSpent;

    private Clock clock;

    public void Interact()
    {
        decayTimer = timeBeforeDecay;

        if (currentEXP < maxEXP)
        {
            currentEXP += expGainRate * Time.deltaTime;
        }
        else
        {
            currentEXP = maxEXP;
        }

        clock.AdvanceTime();
        timeSpent += Time.deltaTime;
    }

    // Use this for initialization
    void Start () {
        decayTimer = timeBeforeDecay;
        clock = GameObject.FindObjectOfType<Clock>();
}
	
	// Update is called once per frame
	void Update () {

        decayTimer -= Time.deltaTime;

        if (decayTimer < 0)
        {
            currentEXP -= decayRate * Time.deltaTime;
        }

        if (currentEXP < 0) currentEXP = 0;
        backgroundBox.localScale = new Vector3(backgroundBox.localScale.x, (float) currentEXP / (float) maxEXP * 1.25f, backgroundBox.localScale.z);
    }
}
