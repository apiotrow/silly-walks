using UnityEngine;
using System.Collections;

public class HeadGetterUpper : MonoBehaviour {
	public Transform stayAboveThis;
	float abovey;
	float mid;

	void Start () {
		mid = ((transform.position.y + abovey) / 2f);
	}
	

	void Update () {
		Vector3 abovePos = stayAboveThis.transform.position;
		abovey = abovePos.y;

		if(transform.position.y - abovey < .5f){
			Vector3 moveToVec = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
			transform.position = Vector3.MoveTowards(transform.position, moveToVec, 10f * Time.deltaTime);
		}

	}
}
