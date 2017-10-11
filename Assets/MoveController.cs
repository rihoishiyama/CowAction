using UnityEngine;
using System.Collections;

public class MoveController: MonoBehaviour
{
	
	public float MoveSpeed = 0.1f;
	public float RotationSpeed = 1.0f;

	void Update	()
	{
		if (Input.GetKey (KeyCode.W)) {
			transform.localPosition += transform.forward * 　MoveSpeed;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.localPosition -= transform.forward * 　MoveSpeed;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up, -RotationSpeed);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up, +RotationSpeed);
		}
	}
}