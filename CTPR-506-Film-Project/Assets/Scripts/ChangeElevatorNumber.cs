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
	// Use this for initialization
	void Start () {
		obj.GetComponent<SpriteRenderer> ().sprite = one;
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
		yield return new WaitForSeconds(waitTime);
		obj.GetComponent<SpriteRenderer> ().sprite = three;
		yield return new WaitForSeconds(waitTime);
		obj.GetComponent<SpriteRenderer> ().sprite = four;

	}
}
