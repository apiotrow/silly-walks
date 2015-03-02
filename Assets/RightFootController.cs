using UnityEngine;
using System.Collections;

public class RightFootController : MonoBehaviour {
	public GameObject rightFoot;
	public Transform rightArm;

	void Start () {
	
	}
	

	void Update () {

		
		
		Vector3 rightFootPos = rightFoot.transform.position;
		//		Vector3 newrightFootPos = new Vector3 (centroid.x + leftFootPos.x, leftFootPos.y, centroid.z + leftFootPos.z);
		//		Vector3 newrightFootPos = new Vector3 (centroid.x, rightFootPos.y, centroid.z);
		Vector3 newrightFootPos = new Vector3 (rightArm.transform.position.x, rightFootPos.y, rightArm.transform.position.z);
		
		rightFoot.transform.position = 
			Vector3.MoveTowards(rightFootPos, 
			                    newrightFootPos, 
			                    5f * Time.deltaTime);
	}
}
