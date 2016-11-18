using UnityEngine;
using System.Collections;

public class TweenOnTrigger : MonoBehaviour {

	/// <summary>
	/// **** Make sure Tween Object is on object you want to tween. 
	/// Moves object from one position to another and also resets position.
	/// </summary>
	public GameObject[] objectsToTween;

	public AudioClip sfx;
	public float volume = 0.9f;
	private AudioSource audioSrc;

	private bool _hasMoved = false;
	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (!_hasMoved) {
			foreach (GameObject obj in objectsToTween) {
				obj.GetComponent<TweenObject> ().MoveObject ();

			}
			if (sfx != null) {
				audioSrc.PlayOneShot (sfx, volume);
			}
			_hasMoved = true;
		} else if (_hasMoved){
			foreach (GameObject obj in objectsToTween) {
				obj.GetComponent<TweenObject> ().ResetObjPos(); // Objects have already moved. Reset.
				_hasMoved = false;
			}
			if (sfx != null) {
				audioSrc.PlayOneShot (sfx, volume);
			}
		}
	}
}
