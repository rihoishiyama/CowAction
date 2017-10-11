using UnityEngine;
using System.Collections;

public class ScaleObj : MonoBehaviour
{

	[SerializeField]
	GameObject TargetObj;

	[SerializeField]
	int plusScale = 1;

	[SerializeField]
	int moveTime = 1;

	Vector3 scale;

	private void OtherAudioPlay ()
	{
		// 自オブジェクトのオーディオ再生
		gameObject.GetComponent<AudioSource> ().enabled = true;
	}

	private void HideThisTrigger ()
	{
		//トリガーの非表示処理
		gameObject.SetActive (false);
	}

	private void Start ()
	{
		
		GetComponent<Collider> ().isTrigger = true;
	}

	private void OnTriggerEnter (Collider other)
	{
		//指定オブジェクトをDirectionの軸方向に、Angle値の分だけ、timeの時間かけて回転
		iTween.ScaleTo (TargetObj, iTween.Hash ("x", plusScale, "y", plusScale, "z", plusScale, "time", moveTime, "easeType", "easeInOutCirc"));
		scale = TargetObj.transform.localScale;

		//指定秒数後に、他オブジェクトのオーディオを再生
		Invoke ("OtherAudioPlay", 0.1f);
		//指定秒数後に、トリガーを非表示
		Invoke ("HideThisTrigger", 2.0f);
	}
}