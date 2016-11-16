using UnityEngine;
using System.Collections;

public class StrobeLight : MonoBehaviour {

	//https://www.youtube.com/watch?v=DhoXfhHamxY
	public float time;
	public GameObject light;
	public Texture lightOn;
	public Texture lightOff;
	private bool isStrobe=true;
	// Use this for initialization
	void Start () {
		StartCoroutine("Flicker");
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
			yield return new WaitForSeconds(time);
		}

	}
}
