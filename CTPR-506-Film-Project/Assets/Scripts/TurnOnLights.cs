using UnityEngine;
using System.Collections;

public class TurnOnLights : MonoBehaviour {

	public GameObject[] lightsArray;
	public float waitTime;
	private bool goOnce=false;

	public AudioClip sfx;
	public float volume = 0.9f;
	private AudioSource audioSrc;
	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){

		if (!goOnce) {
			StartCoroutine("LetThereBeLight");
			goOnce = true;
		}
	}
	IEnumerator LetThereBeLight()
	{
		yield return new WaitForSeconds(waitTime);
		if (sfx != null) {
			audioSrc.PlayOneShot (sfx, volume);
		}
		foreach (GameObject l in lightsArray) {
			l.GetComponent<Light>().enabled = true;
		}
	}
}
