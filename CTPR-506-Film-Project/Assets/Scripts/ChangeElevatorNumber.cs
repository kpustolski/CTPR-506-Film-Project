using UnityEngine;
using System.Collections;

public class ChangeElevatorNumber : MonoBehaviour {

	public GameObject obj;
	public Sprite one;
	public Sprite two;
	public Sprite three;
	public Sprite four;
	public float waitTime;
	private bool doOnce= false;

	public AudioClip sfx;
	public float volume = 0.9f;
	private AudioSource audioSrc;
	// Use this for initialization
	void Start () {
		obj.GetComponent<SpriteRenderer> ().sprite = one;
		audioSrc = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){

		if (!doOnce) {
			StartCoroutine (ChangeSprite());
			doOnce = true;
		}
	}
	IEnumerator ChangeSprite(){
		yield return new WaitForSeconds(waitTime);
		obj.GetComponent<SpriteRenderer> ().sprite = two;
		if (sfx != null) {
			audioSrc.PlayOneShot (sfx, volume);
		}
		yield return new WaitForSeconds(waitTime);
		obj.GetComponent<SpriteRenderer> ().sprite = three;
		if (sfx != null) {
			audioSrc.PlayOneShot (sfx, volume);
		}
		yield return new WaitForSeconds(waitTime);
		obj.GetComponent<SpriteRenderer> ().sprite = four;
		if (sfx != null) {
			audioSrc.PlayOneShot (sfx, volume);
		}

	}
}
