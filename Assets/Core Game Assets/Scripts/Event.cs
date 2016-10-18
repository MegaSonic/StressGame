using UnityEngine;
using System.Collections;
using System;

public class Event : MonoBehaviour, IInteractable {

    public string eventName;
    public int currentEXP;
    public int currentRank;

    public int maxEXP;
    public int maxRank;
    public int expGainRate;

    public Transform backgroundBox;

    public float speed;

    public float timeSpent;

    public float maxScale;
    public float minScale;
    public float scaleRate;
    public float shrinkRate;

    public float timeBeforeShrink;

    private float shrinkTimer = 0f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        backgroundBox.localScale = new Vector3(backgroundBox.localScale.x, (float)currentEXP / (float)maxEXP * 1.25f, backgroundBox.localScale.z);

        shrinkTimer += Time.deltaTime;
        if (shrinkTimer >= timeBeforeShrink)
        {
            if (transform.localScale.x > minScale)
            {
                transform.localScale = new Vector3(transform.localScale.x - shrinkRate * Time.deltaTime, transform.localScale.y - shrinkRate * Time.deltaTime, transform.localScale.z - shrinkRate * Time.deltaTime);
            }
            else
            {
                transform.localScale = new Vector3(minScale, minScale, minScale);
            }
        }
    }

    public void Interact()
    {
        if (transform.localScale.x < maxScale)
        {
            transform.localScale = new Vector3(transform.localScale.x + scaleRate * Time.deltaTime, transform.localScale.y + scaleRate * Time.deltaTime, transform.localScale.z + scaleRate * Time.deltaTime);
        }


        if (currentRank == maxRank)
        {

        }
        else if (currentEXP < maxEXP)
        {
            currentEXP += (int)(expGainRate * Time.deltaTime);

        }
        else
        {
            currentEXP = 0;
            currentRank++;
        }

        timeSpent += Time.deltaTime;
    }
}
