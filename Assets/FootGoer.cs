using UnityEngine;
using System.Collections;

public class FootGoer : MonoBehaviour {
	float ypos;
	float highy;

	void Start () {
		ypos = transform.position.y;
		highy = ypos + 1f;
	}
	
	
	void Update () {
		Vector3 pos = transform.position;

		ypos = Mathf.MoveTowards(ypos, highy, Time.deltaTime); 
		pos.y = ypos;

		transform.position = pos;
	}
}
