using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CameraSequence : MonoBehaviour {

	[SerializeField] CameraPosition[] positionList;
	[SerializeField] Camera m_camera;
	[SerializeField] int index = 0;

	void Awake()
	{
		if (m_camera == null)
			m_camera = GetComponentInChildren<Camera> ();
	}

	void Update()
	{
		if ( Input.GetKeyDown(KeyCode.G) )
		{
			if (index < positionList.Length) {
				CameraPosition next = positionList [index];

				DealPosition (next);

				index++;
			}
		}
	}

	void DealPosition( CameraPosition pos )
	{
		if (pos.fromTransform == TransformType.Direct) {
			m_camera.enabled = true;
			m_camera.transform.position = pos.transform.position;
			m_camera.transform.rotation = pos.transform.rotation;
		} else if (pos.fromTransform == TransformType.MoveFromMain) {
			m_camera.enabled = false;
			m_camera.transform.position = Camera.main.transform.position;
			m_camera.transform.rotation = Camera.main.transform.rotation;

			m_camera.enabled = true;

			m_camera.transform.DOMove (pos.transform.position, pos.transformTime);
			m_camera.transform.DORotate (pos.transform.rotation.eulerAngles, pos.transformTime);
			
		} else if (pos.fromTransform == TransformType.Unable) {

			m_camera.transform.DOMove (Camera.main.transform.position, pos.transformTime);
			m_camera.transform.DORotate (Camera.main.transform.rotation.eulerAngles, pos.transformTime).OnComplete(delegate() {
				m_camera.enabled = false;	
			});
		} else if (pos.fromTransform == TransformType.Move) {
			m_camera.enabled = true;

			m_camera.transform.DOMove (pos.transform.position, pos.transformTime);
			m_camera.transform.DORotate (pos.transform.rotation.eulerAngles, pos.transformTime);
		}
	}
}

[System.Serializable]
public class CameraPosition
{
	public Transform transform;
	public TransformType fromTransform;
	public float transformTime;
}

public enum TransformType
{
	Direct,
	Move,
	MoveFromMain,
	Unable,
}