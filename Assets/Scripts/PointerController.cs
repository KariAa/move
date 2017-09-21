using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PointerController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	//class PointerController extends MonoBehaviour implements IPointerDownHandler, IPointerUpHandler

	bool pressed = false;


	public void OnPointerDown (PointerEventData eventData) {
		//Debug.Log ("Down - " + eventData);
		pressed = true;
	}

	public void OnPointerUp (PointerEventData eventData) {
		//Debug.Log ("Up " + eventData);
		pressed = false;
	}

	public bool getPressed() {
		return this.pressed;
	}

}
