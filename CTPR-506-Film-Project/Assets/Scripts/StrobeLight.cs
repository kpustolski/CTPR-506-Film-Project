using UnityEngine;
using System.Collections;

public class StrobeLight : MonoBehaviour {

	//https://www.youtube.com/watch?v=DhoXfhHamxY
	public float time;
	public GameObject light;
	public Texture lightOn;
	public Texture lightOff;
	private bool isStrobe=true;

	public AudioClip sfx;
	public float volume = 0.9f;
	private AudioSource audioSrc;
	// Use this for initialization
	void Start () {
		StartCoroutine("Flicker");
		audioSrc = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}
	IEnumerator Flicker()
	{
		while (isStrobe)
		{
			light.GetComponent<Light>().enabled = false;
			GetComponent<Renderer> ().material.mainTexture = lightOff;
			yield return new WaitForSeconds(time);
			light.GetComponent<Light>().enabled = true;
			GetComponent<Renderer> ().material.mainTexture = lightOn;
			if (sfx != null) {
				audioSrc.PlayOneShot (sfx, volume);
			}
			yield return new WaitForSeconds(time);
		}

	}
}
