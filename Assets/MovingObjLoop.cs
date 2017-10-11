using UnityEngine;
using System.Collections;

public class MovingObjLoop: MonoBehaviour
{
	
	[SerializeField]
	string MoveAxis = "y";
	
	[SerializeField]
	float MoveTime = 1.0f;
	
	[SerializeField]
	float MoveRange = 1.0f;

	void Start ()
	{
		iTween.MoveBy (gameObject, iTween.Hash (MoveAxis, MoveRange, "time", MoveTime, "easeType", "easeInOutSine", "loopType", "pingPong"));
	}
}