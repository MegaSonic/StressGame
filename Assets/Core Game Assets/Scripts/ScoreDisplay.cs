using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScoreDisplay : MonoBehaviour {

	public Text home;
	public Text school;
	public Text item0;
	public Text item1;
	public Text item2;
	public Text item3;
	public Text item4;
	public Text item5;
	public Text item6;
	public Text item7;
	public Text final;

	private float homeScore;
	private float schoolScore;
	private float score0;
	private float score1;
	private float score2;
	private float score3;
	private float score4;
	private float score5;
	private float score6;
	private float score7;
	private float finalScore;

	// Use this for initialization
	void Start () {
		SavedTimes go = GameObject.FindObjectOfType<SavedTimes> ();
		homeScore = go.roomEXP;
		schoolScore = go.schoolEXP;
		score0 = go.timeData [0] * 500;
		score1 = go.timeData [1] * 500;
		score2 = go.timeData [2] * 500;
		score3 = go.timeData [3] * 500;
		score4 = go.timeData [4] * 500;
		score5 = go.timeData [5] * 500;
		score6 = go.timeData [6] * 500;
		score7 = go.timeData [7] * 500;
		finalScore = homeScore + schoolScore + score0 + score1 + score2 + score3 + score4 + score5 + score6 + score7;
		if (finalScore < 0)
			finalScore = 0;

		home.text = "" + homeScore;
		school.text = "" + schoolScore;
		item0.text = "" + score0;
		item1.text = "" + score1;
		item2.text = "" + score2;
		item3.text = "" + score3;
		item4.text = "" + score4;
		item5.text = "" + score5;
		item6.text = "" + score6;
		item7.text = "" + score7;
		final.text = "" + finalScore;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
