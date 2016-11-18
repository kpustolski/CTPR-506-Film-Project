using UnityEngine;
using System.Collections;

public class OpenCloseElevatorDoors : MonoBehaviour {

	public GameObject elevatorDoor;
	public GameObject endPositionObj;
	public GameObject startPositionObj;
	public float moveTime;
	public float waitTimeForOpenDoor; 
	public float waitTimeForCloseDoor;

	public AudioClip sfx;
	public float volume = 0.9f;
	private AudioSource audioSrc;

	private bool doOnce=false;
	// Use this for initialization
	void Start () {
//		startPosition = this.transform.position;
		audioSrc = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){

		if (!doOnce) {
			StartCoroutine (OpenCloseDoor());
			doOnce = true;
		}
	}
	IEnumerator OpenCloseDoor(){
		yield return new WaitForSeconds(waitTimeForOpenDoor);
		iTween.MoveTo (elevatorDoor, endPositionObj.GetComponent<Transform>().position, moveTime);
		if (sfx != null) {
			audioSrc.PlayOneShot (sfx, volume);
		}
		yield return new WaitForSeconds(waitTimeForCloseDoor);
		iTween.MoveTo (elevatorDoor, startPositionObj.GetComponent<Transform>().position, moveTime);
		if (sfx != null) {
			audioSrc.PlayOneShot (sfx, volume);
		}
	}
}
