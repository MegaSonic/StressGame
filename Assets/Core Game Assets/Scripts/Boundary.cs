using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour {

	public Camera camera;
	public Collider coll;
	public float DelayTime;

	private float xPos;
	private float yPos;
	private float reactTimer;
	private GameObject go;


	// Use this for initialization
	void Start () {
		go = GameObject.FindGameObjectWithTag ("startPlayer");

		//Debug.Log (go.name);

		reactTimer = DelayTime;
	}
	
	// Update is called once per frame
	void Update () {
		xPos = go.transform.position.x;
		yPos = go.transform.position.y;
		/*
		if (Input.GetButtonDown ("Fire1")) {
			RaycastHit hit;
			Ray ray = camera.ScreenPointToRay (Input.mousePosition);
			if (coll.Raycast (ray, out hit, 100.0f)) {
				float coordx = hit.point.x;
				float coordy = hit.point.y;
				float coordz = hit.point.z;
				//Debug.Log ("Coordinate: (" + coordx + ", " + coordy + ", " + coordz + ")");
			}
		}
		*/

		Debug.Log ("Position: (" + xPos + ", " + yPos + ")");

		//Debug.Log ("Time: " + reactTimer);
		// position for QUIT
		if (xPos > -5.8f && xPos < -2.25f && yPos > -1.6f && yPos < 1.1f) {
			reactTimer -= Time.deltaTime;
			if (reactTimer <= 0.0f)
				Application.Quit ();
		}

		// position for BEGIN
		if (xPos > 2.2f && xPos < 5.7f && yPos > -1.6f && yPos < 1.1f) {
			reactTimer -= Time.deltaTime;
			if (reactTimer <= 0.0f)
				SceneManager.LoadScene ("IconSelect");
		}

	}
}
