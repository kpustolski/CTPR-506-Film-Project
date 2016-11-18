using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityStandardAssets.Characters.FirstPerson;

public class Fall : MonoBehaviour {

	[SerializeField] FirstPersonController controller;
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.F)) {
			transform.DOLocalRotate (new Vector3 (85f, 0, 0), 2f).SetRelative (true).SetEase(Ease.InSine);
			Camera.main.transform.DOShakeRotation (0.8f, 15f, 15);
			controller.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.U) ) {
			Sequence seq = DOTween.Sequence ();
			seq.Append (transform.DOLocalRotate (new Vector3 (-40f, 0, 0), 3f).SetRelative (true).SetEase (Ease.InOutQuad));
			seq.Append (transform.DOLocalRotate (new Vector3 (-45f, 0, 0), 3f).SetRelative (true).SetEase (Ease.InOutQuad)).OnComplete (delegate() {
				controller.enabled = true;
			});
		}
	}
}
