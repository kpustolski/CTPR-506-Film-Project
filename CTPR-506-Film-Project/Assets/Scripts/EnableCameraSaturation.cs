using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
public class EnableCameraSaturation : MonoBehaviour {

	/// <summary>
	/// Changes camera saturation;
	/// </summary>
	public Camera mainCamera;
	public float increaseSatBy=0.01f;

	public float camSatEnd = 1f;
	float sat;

	public AudioClip sfx;
	public float volume = 0.9f;
	private AudioSource audioSrc;
	public GameObject epicMusicObj;

	void Start(){
		audioSrc = GetComponent<AudioSource> ();
	
	}
	public float saturation
	{
		get
		{
			return sat;
		}
	}

	// Use this for initialization
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){

		StartCoroutine (changeCameraSaturation (camSatEnd));
	}
	IEnumerator changeCameraSaturation(float camSat){
		if (sfx != null) {
			audioSrc.PlayOneShot (sfx, volume);
		}
		if (epicMusicObj != null) {
			epicMusicObj.GetComponent<AudioSource> ().enabled = false;
		}
		while (sat < 1f) {
			sat = mainCamera.GetComponent<ColorCorrectionCurves> ().saturation;
			sat += increaseSatBy;
			mainCamera.GetComponent<ColorCorrectionCurves> ().saturation = sat;
			yield return null;
		}
	}
}
