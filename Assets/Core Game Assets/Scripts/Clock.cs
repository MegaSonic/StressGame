using UnityEngine;
using System.Collections;

public class Clock : MonoBehaviour {

    public float currentTime;
    public float maxTime;

    public Light light;

    public float startX;
    public float endX;

    public Player player;
    public ObjectSpawn spawner;


    public Animator animator;

    public Room home;
    public Room school;
    public SavedTimes save;

	// Use this for initialization
	void Start () {
        save = GameObject.FindObjectOfType<SavedTimes>();
	}
	
	// Update is called once per frame
	void Update () {
        float normalizedTime = currentTime / maxTime;
        float differenceX = endX - startX;
        this.transform.position = new Vector3(startX + differenceX * normalizedTime, this.transform.position.y, this.transform.position.z);

        if (currentTime >= maxTime)
        {
            currentTime = maxTime;
            animator.Play("endingAnimation");
            player.enabled = false;
            spawner.enabled = false;
            save.roomEXP = (int) home.currentEXP;
            save.schoolEXP = (int) school.currentEXP;
            home.enabled = false;
            school.enabled = false;
        }
	}


    public void AdvanceTime()
    {
        currentTime += Time.deltaTime;

        if (currentTime > maxTime) currentTime = maxTime;
    }

    public void AdvanceTime(float time)
    {
        currentTime += time;

        if (currentTime > maxTime) currentTime = maxTime;
    }
}
