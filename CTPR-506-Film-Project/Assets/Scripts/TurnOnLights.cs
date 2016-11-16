using UnityEngine;
using System.Collections;

public class TurnOnLights : MonoBehaviour {

	public GameObject[] lightsArray;
	public float waitTime;
	private bool goOnce=false;
	// Use this for initialization
	void Start () {
		
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
		foreach (GameObject l in lightsArray) {
			l.GetComponent<Light>().enabled = true;
		}
	}
}
