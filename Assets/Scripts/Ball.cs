using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {
		print ("hit "+ col.gameObject.name);

	}
}
