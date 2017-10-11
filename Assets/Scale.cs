using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {
	[SerializeField]
	GameObject obj;

	[SerializeField]
	int plusScale = 1;

	[SerializeField]
	int defaultScale = 1;


	[SerializeField]
	int moveTime = 1;
	Vector3 scale;

	// Use this for initialization
	void Start () {
		scale = obj.transform.localScale;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			ScaleB ();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			ScaleS ();
		}
	}

	public void ScaleB(){
		iTween.ScaleTo (obj, iTween.Hash ("x", plusScale, "y", plusScale, "z", plusScale, "time", moveTime, "easeType", "easeInOutCirc"));
		scale = obj.transform.localScale;
	}

	public void ScaleS(){
		iTween.ScaleTo (obj, iTween.Hash ("x", defaultScale, "y", defaultScale, "z", defaultScale, "time", moveTime, "easeType", "easeInOutCirc"));
		scale = obj.transform.localScale;
	}


}
//キーを押したらでかくなる