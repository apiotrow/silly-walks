using UnityEngine;
using System.Collections;

public class RotateLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 erot = transform.rotation.eulerAngles;
		erot.y += 0.8f;
		transform.rotation = Quaternion.Euler(erot);
	}
}
