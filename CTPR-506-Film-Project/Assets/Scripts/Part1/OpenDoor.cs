using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {

	[SerializeField] AudioSource openSound;
	[SerializeField] KeyCode key;
	void Update()
	{
		if (Input.GetKeyDown (key)) {
			
		}
	}
}
