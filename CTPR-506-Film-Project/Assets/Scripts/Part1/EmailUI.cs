using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EmailUI : MonoBehaviour {


	[SerializeField] Image[] emailContent;
	[SerializeField] GameObject email;
	[SerializeField] GameObject desktop;

	void Awake()
	{
	}

	void Update()
	{
		if ( Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown (KeyCode.E)) {
			desktop.SetActive (true);
			Cursor.visible = true;
		}
		if ( Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown (KeyCode.F)) {
			desktop.SetActive (false);
			email.SetActive (false);
			Cursor.visible = false;
		}
	}
	public void OnShowEmail()
	{
		Debug.Log ("On Show Email");
		email.SetActive (true);
	}
	public void OnEmailItem( int i )
	{
		Debug.Log ("On Email Item");
		foreach (Image content in emailContent)
			content.gameObject.SetActive (false);
		emailContent [i].gameObject.SetActive (true);
	}

	public void Close()
	{

		email.SetActive (false);
	}
}
