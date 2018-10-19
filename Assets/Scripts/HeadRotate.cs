using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion at = Input.gyro.attitude;
		at = Quaternion.Euler (90f, 0f, 0f) * new Quaternion (at.x, at.y, -at.z, -at.w);
		transform.rotation = at;
	}
}
