using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSpawn : MonoBehaviour {

    public float baseTimeBetweenSpawns;
    public float lowMultiplier;
    public float highMultiplier;

    private float spawnTimer;

    public List<GameObject> objectsToSpawn;

    public Vector3 topRight;
    public Vector3 topLeft;
    public Vector3 bottomRight;
    public Vector3 bottomLeft;

    
    // Use this for initialization
    void Start () {
        topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));

        spawnTimer = baseTimeBetweenSpawns;
        
    }
	
	// Update is called once per frame
	void Update () {
        spawnTimer -= Time.deltaTime;	    

        if (spawnTimer <= 0f)
        {
            int rand = (int) Random.Range(0f, objectsToSpawn.Count);
            GameObject go = Instantiate(Resources.Load(objectsToSpawn[rand].name)) as GameObject;

            spawnTimer = Random.Range(lowMultiplier, highMultiplier) * baseTimeBetweenSpawns;
            go.transform.position = new Vector3(Random.Range(topLeft.x, topRight.x), topLeft.y + 3, -1);
            go.transform.rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            go.GetComponent<Rigidbody>().AddTorque(30, 30, 30);
        }
	}


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
