using UnityEngine;
using System.Collections;

public class TweenOnTrigger : MonoBehaviour {

	/// <summary>
	/// **** Make sure Tween Object is on object you want to tween. 
	/// Moves object from one position to another and also resets position.
	/// </summary>
	public GameObject[] objectsToTween;

	private bool _hasMoved = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (!_hasMoved) {
			foreach (GameObject obj in objectsToTween) {
				obj.GetComponent<TweenObject> ().MoveObject ();
			}
			_hasMoved = true;
		} else if (_hasMoved){
			foreach (GameObject obj in objectsToTween) {
				obj.GetComponent<TweenObject> ().ResetObjPos(); // Objects have already moved. Reset.
				_hasMoved = false;
			}
		}
	}
}
