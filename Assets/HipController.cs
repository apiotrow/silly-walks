using UnityEngine;
using System.Collections;

public class HipController : MonoBehaviour {
	public Transform target;

	void Start () {
		
	}
	

	void Update () {
		Vector3 targetPos = target.position;
		Vector3 newPos = new Vector3 (targetPos.x, transform.position.y, targetPos.z);
		
		transform.position = 
			Vector3.MoveTowards(transform.position, 
			                    newPos, 
			                    4f * Time.deltaTime);
	}
}
