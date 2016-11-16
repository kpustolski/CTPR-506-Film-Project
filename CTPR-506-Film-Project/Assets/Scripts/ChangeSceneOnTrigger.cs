using UnityEngine;
using System.Collections;

public class ChangeSceneOnTrigger : MonoBehaviour {

	public string changeToScene;
	private Manager _man;
	// Use this for initialization
	void Start () {
		_man = GameObject.FindObjectOfType<Manager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		_man.GotoScene (changeToScene);
	}
}
