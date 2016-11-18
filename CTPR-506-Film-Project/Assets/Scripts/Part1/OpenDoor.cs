using UnityEngine;
using System.Collections;
using DG.Tweening;

public class OpenDoor : MonoBehaviour {

	[SerializeField] AudioSource openSound;
	[SerializeField] KeyCode key;
	void Update()
	{
		if (Input.GetKeyDown (key)) {
			transform.DORotate (new Vector3 (0, 90f, 0), 2f);
			openSound.Play ();
		}
	}
}
