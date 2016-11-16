using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

	//public string sceneToLoad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void GotoScene(string sceneToLoad){
		SceneManager.LoadScene(sceneToLoad);
	}
}
