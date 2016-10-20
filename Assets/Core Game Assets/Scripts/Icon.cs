using UnityEngine;
using System.Collections;
using System;

public class Icon : MonoBehaviour, IInteractable {


    public int id;
    public float timeToAdvance;

    public SavedTimes save;
    private Clock clock;
    private IconSelect iconSelect;


    public void Interact()
    {
        if (clock != null) clock.AdvanceTime(timeToAdvance);
        if (iconSelect != null && iconSelect.choicesLockedIn == false) iconSelect.MakeChoice(id);
        if (save != null)
        {
            if (id == iconSelect.icon1 || id == iconSelect.icon2)
            {
                save.timeData[id]++;
            }
            else
            {
                save.timeData[id]--;
            }
        }
        Destroy(this.gameObject);
    }

    // Use this for initialization
    void Start () {
        clock = GameObject.FindObjectOfType<Clock>();
        save = GameObject.FindObjectOfType<SavedTimes>();
        iconSelect = GameObject.FindObjectOfType<IconSelect>();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
