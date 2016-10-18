using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SamplePieChart : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Slice s1 = gameObject.AddComponent<Slice> () as Slice;
		s1.setName ("Home");
		s1.setPercentage(100f);
		s1.setColor (new Color (0.0f, 1.0f, 0.0f, 1.0f));
		List<Slice> tab = new List<Slice> ();
		tab.Add (s1);
		//tab.Add (new Slice ("Home", 40f, new Color (0.0f, 1.0f, 0.0f, 1.0f)));
		//tab.Add (new Slice ("School", 30f, new Color (1.0f, 0.0f, 0.0f, 1.0f)));
		//tab.Add (new Slice ("Relax", 30f, new Color (0.3f, 0.5f, 1.0f, 1.0f)));
		PieGraph g = gameObject.AddComponent<PieGraph>() as PieGraph;
		g.SetRes (360);
		g.SetGameObject (gameObject);
		g.SetSlice (tab);
		//PieGraph graph = new PieGraph (tab, gameObject, 180);

	}

}
