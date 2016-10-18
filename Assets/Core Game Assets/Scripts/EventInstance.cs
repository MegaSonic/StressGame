using UnityEngine;
using System.Collections;

public class EventInstance : MonoBehaviour, IInteractable {

    public Event pairedEvent;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.localScale = pairedEvent.transform.localScale;
	}

    public void Interact()
    {
        pairedEvent.Interact();
    }
}
