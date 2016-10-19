using UnityEngine;
using System.Collections;
using System;

public class Icon : MonoBehaviour, IInteractable {

    public string name;
	public float timeToAdvance;

	private Clock clock;

	public void Interact()
	{
		clock.AdvanceTime (timeToAdvance);
		Destroy (this.gameObject);
	}

	// Use this for initialization
	void Start () {
		clock = GameObject.FindObjectOfType<Clock> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
