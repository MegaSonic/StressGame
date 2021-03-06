﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public enum Location
    {
        NW = 0,
        N = 1,
        NE = 2,
        W = 3,
        C = 4,
        E = 5,
        SW = 6,
        S = 7,
        SE = 8
    }

    public Vector3 topRight;
    public Vector3 topLeft;
    public Vector3 bottomRight;
    public Vector3 bottomLeft;

    public float speed;

    // Use this for initialization
    void Start () {
        topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {
        Movement();


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Entered");
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("Touching!");

        IInteractable interactable = col.gameObject.GetInterface<IInteractable>();

        if (interactable != null)
        {
            interactable.Interact();
        }
    }


    private void Movement()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                this.transform.position = new Vector3(this.transform.position.x + (speed * Mathf.Sqrt(2f) / 2) * Time.deltaTime, this.transform.position.y + (speed * Mathf.Sqrt(2f) / 2) * Time.deltaTime, this.transform.position.z);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                this.transform.position = new Vector3(this.transform.position.x + (speed * Mathf.Sqrt(2f) / 2) * Time.deltaTime, this.transform.position.y - (speed * Mathf.Sqrt(2f) / 2) * Time.deltaTime, this.transform.position.z);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x + speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
            }
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                this.transform.position = new Vector3(this.transform.position.x - (speed * Mathf.Sqrt(2f) / 2) * Time.deltaTime, this.transform.position.y + (speed * Mathf.Sqrt(2f) / 2) * Time.deltaTime, this.transform.position.z);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                this.transform.position = new Vector3(this.transform.position.x - (speed * Mathf.Sqrt(2f) / 2) * Time.deltaTime, this.transform.position.y - (speed * Mathf.Sqrt(2f) / 2) * Time.deltaTime, this.transform.position.z);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x - speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
            }
        }
        else
        {
            if (Input.GetAxis("Vertical") > 0)
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + speed * Time.deltaTime, this.transform.position.z);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - speed * Time.deltaTime, this.transform.position.z);
            }
            else
            {
                
            }
        }

        if (this.transform.position.x < topLeft.x)
        {
            this.transform.position = new Vector3(topLeft.x, transform.position.y, transform.position.z);
        }
        else if (this.transform.position.x > topRight.x)
        {
            this.transform.position = new Vector3(topRight.x, transform.position.y, transform.position.z);
        }
        if (this.transform.position.y > topLeft.y)
        {
            this.transform.position = new Vector3(transform.position.x, topLeft.y, transform.position.z);
        }
        else if (this.transform.position.y < bottomRight.y)
        {
            this.transform.position = new Vector3(transform.position.x, bottomRight.y, transform.position.z);
        }

    }
}
