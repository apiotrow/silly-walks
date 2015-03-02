using UnityEngine;
using System.Collections;

public class RightFootController : MonoBehaviour {

	public Transform rightArm;

	void Start () {
	
	}
	

	void Update () {

		
		
		Vector3 rightFootPos = transform.position;
		Vector3 newrightFootPos = new Vector3 (rightArm.transform.position.x, rightFootPos.y, rightArm.transform.position.z);
		
		transform.position = 
			Vector3.MoveTowards(rightFootPos, 
			                    newrightFootPos, 
			                    5f * Time.deltaTime);
	}
}
