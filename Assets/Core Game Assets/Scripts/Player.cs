using UnityEngine;
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

    public Location location;

    public Transform nw;
    public Transform n;
    public Transform ne;
    public Transform w;
    public Transform e;
    public Transform sw;
    public Transform s;
    public Transform se;
    public Transform center;

    public float travelTime;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // West
        if (Input.GetAxis("Horizontal") < -0.01)
        {
            // South
            if (Input.GetAxis("Vertical") < -0.01)
            {
                if (location != Location.SW)
                {
                    location = Location.SW;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, sw.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                }
            }
            // Center
            else if (Input.GetAxis("Vertical") < 0.01 && Input.GetAxis("Vertical") > -0.01)
            {
                if (location != Location.W)
                {
                    location = Location.W;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, w.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                    
                }
            }
            // North
            else if (Input.GetAxis("Vertical") > 0.01)
            {
                if (location != Location.NW)
                {
                    location = Location.NW;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, nw.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                }
            }
        }
        else if (Input.GetAxis("Horizontal") < 0.01 && Input.GetAxis("Horizontal") > -0.01)
        {
            if (Input.GetAxis("Vertical") < -0.01)
            {
                if (location != Location.S)
                {
                    location = Location.S;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, s.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                }
            }
            else if (Input.GetAxis("Vertical") < 0.01 && Input.GetAxis("Vertical") > -0.01)
            {
                if (location != Location.C)
                {
                    location = Location.C;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, center.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                }
            }
            else if (Input.GetAxis("Vertical") > 0.01)
            {
                if (location != Location.N)
                {
                    location = Location.N;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, n.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                }
            }
        }
        else if (Input.GetAxis("Horizontal") > 0.01)
        {
            // North
            if (Input.GetAxis("Vertical") < -0.01)
            {
                if (location != Location.SE)
                {
                    location = Location.SE;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, se.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                }
            }
            else if (Input.GetAxis("Vertical") < 0.01 && Input.GetAxis("Vertical") > -0.01)
            {
                if (location != Location.E)
                {
                    location = Location.E;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, e.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                }
            }
            else if (Input.GetAxis("Vertical") > 0.01)
            {
                if (location != Location.NE)
                {
                    location = Location.NE;
                    LeanTween.cancel(this.gameObject);
                    LeanTween.move(this.gameObject, ne.position, travelTime).setEase(LeanTweenType.easeInOutQuad);
                }
            }
        }
    }
}
