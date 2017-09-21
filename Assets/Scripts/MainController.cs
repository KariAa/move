using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {

	PointerController up;
	PointerController down;
	PointerController left;
	PointerController right;
	//	RawImage box;
	Ball ball;

	// Use this for initialization, GetComponent<PointerController>
	void Start () {
		up = GameObject.Find ("Up").GetComponent<PointerController> ();
		down = GameObject.Find ("Down").GetComponent<PointerController> ();
		left = GameObject.Find ("Left").GetComponent<PointerController> ();
		right = GameObject.Find ("Right").GetComponent<PointerController> ();
		ball = GameObject.Find ("Ball").GetComponent<Ball>();



	}

	// Update is called once per frame
	void Update () {

		if (up.getPressed()) {
			ball.transform.Translate (0,0.1f,0);	
			//Debug.Log ("YLÖS painettu");
		}
		if (down.getPressed()) {
			ball.transform.Translate (0,-0.1f,0);	
			//Debug.Log ("ALAS painettu");
		}
		if (left.getPressed()) {
			ball.transform.Translate (-0.1f,0,0);	
			//Debug.Log ("LEFT painettu");
		}
		if (right.getPressed()) {
			ball.transform.Translate (0.1f,0,0);
			//Debug.Log ("RIGHT painettu");
		}
	}


}
