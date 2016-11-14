using UnityEngine;
using System.Collections;

public class ChangeSpriteOnTrigger : MonoBehaviour {

	public GameObject obj;
	public Sprite defaultSprite;
	public Sprite spriteToSwitchTo;
	public float waitTime;
	private bool doOnce= false;
	// Use this for initialization
	void Start () {
		obj.GetComponent<SpriteRenderer> ().sprite = defaultSprite;
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
		obj.GetComponent<SpriteRenderer> ().sprite = spriteToSwitchTo;
	}
}
