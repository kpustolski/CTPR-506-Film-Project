using UnityEngine;
using System.Collections;

public class SwingDoorOnTrigger : MonoBehaviour {

	public GameObject door;
	public Transform from;
	public Transform to;
	public float speed = 4F;
	private bool doOnce=false;

	public AudioClip sfx;
	public float volume = 0.9f;
	private AudioSource audioSrc;
	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		//if we haven't reached the desired rotation, swing

		//if(Mathf.Abs(totalRotation) < Mathf.Abs(rotationDegreesAmount))
			//SwingOpen();
		}

//	void SwingOpen()
//	{   
//		///door.GetComponent<Transform>(). = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed);
//	}
	void OnTriggerEnter(Collider other){

		if (!doOnce) {
			if (sfx != null) {
				audioSrc.PlayOneShot (sfx, volume);
			}
			door.GetComponent<Transform>().localRotation = Quaternion.Slerp(from.rotation, to.rotation, Time.time * speed);
			doOnce = true;
		}
	}

}
