using UnityEngine;
using System.Collections;

public class EventSpawn : MonoBehaviour {

    public Transform despawnPoint;
    public float timeBetweenSpawns;
    public float eventMovementTime;


    private GameObject eventPrefab;

    private float spawnTimer;

	// Use this for initialization
	void Start () {
        eventPrefab = Resources.Load("Event") as GameObject; 
	}
	
	// Update is called once per frame
	void Update () {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            spawnTimer = timeBetweenSpawns;
            GameObject eventObject = (GameObject) Instantiate(eventPrefab, transform.position, transform.rotation);
            LeanTween.move(eventObject, despawnPoint.position, eventMovementTime);
        }
	}
}
