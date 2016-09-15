using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class gameMaster : MonoBehaviour {

	public int points;
	public Text pointstext;
	
	// Update is called once per frame
	void Update () {
		pointstext.text = "Points: " + points.ToString();
	}
}
