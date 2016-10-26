using UnityEngine;
using System.Collections;

public class TweenObject : MonoBehaviour {

	/// <summary>
	/// Place on object you would like to tween.
	/// Tween object to a position. Can move it to and from a position.
	/// </summary>
	//public GameObject movingObj;
	public GameObject endPosObj;
	public float tweenTime =1f;

	private Vector3 _endPos;
	private Vector3 _startPos;
	// Use this for initialization
	void Start () {
		_endPos = endPosObj.GetComponent<Transform> ().position;
		_startPos = this.transform.position;
	}

	public void MoveObject(){
		iTween.MoveTo (this.gameObject,_endPos,tweenTime);
	}

	public void ResetObjPos(){
		iTween.MoveTo (this.gameObject,_startPos,tweenTime);
	}

}
