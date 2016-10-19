using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {

    public float currentTime;
    public float maxTime;

    public Light light;

    public float startX;
    public float endX;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float normalizedTime = currentTime / maxTime;
        float differenceX = endX - startX;
        this.transform.position = new Vector3(startX + differenceX * normalizedTime, this.transform.position.y, this.transform.position.z);

        if (currentTime >= maxTime)
        {
            Debug.Log("End");
        }
	}


    public void AdvanceTime()
    {
        currentTime += Time.deltaTime;
    }

    public void AdvanceTime(float time)
    {
        currentTime += time;
    }
}
