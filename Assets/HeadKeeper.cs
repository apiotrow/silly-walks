using UnityEngine;
using System.Collections;

public class HeadKeeper : MonoBehaviour {
	float ypos;

	void Start () {
		ypos = transform.position.y;
	}
	

	void Update () {
		Vector3 pos = transform.position;
		pos.y = ypos;
		transform.position = pos;
	}
}
