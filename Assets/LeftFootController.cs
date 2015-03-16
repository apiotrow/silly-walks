using UnityEngine;
using System.Collections;

public class LeftFootController : MonoBehaviour {

	public Transform leftArm;
	
	void Start () {
//		leftArm = GameObject.Find("UpperLeftArm").GetComponent("Transform") as Transform;
	}
	
	
	void Update () {
		
		
		
		Vector3 rightFootPos = transform.position;
		Vector3 newrightFootPos = new Vector3 (leftArm.transform.position.x, rightFootPos.y, leftArm.transform.position.z);
		
		transform.position = 
			Vector3.MoveTowards(rightFootPos, 
			                    newrightFootPos, 
			                    5f * Time.deltaTime);
	}
}
