using UnityEngine;
using System.Collections;
using System;

public class Room : MonoBehaviour, IInteractable {

    public string roomName;
    public int currentEXP;
    public int currentRank;

    public int maxEXP;
    public int maxRank;
    public int expGainRate;

    public Transform backgroundBox;

    public void Interact()
    {
        if (currentRank == maxRank) return;

        if (currentEXP < maxEXP)
        {
            currentEXP += (int) (expGainRate * Time.deltaTime);
            
        }
        else
        {
            currentEXP = 0;
            currentRank++;

        }
    }

    // Use this for initialization
    void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
        backgroundBox.localScale = new Vector3(backgroundBox.localScale.x, (float) currentEXP / (float) maxEXP * 1.25f, backgroundBox.localScale.z);
    }
}
