using UnityEngine;
using System.Collections;

public class CenterOfMassCalc : MonoBehaviour {
//	public Rigidbody a;
//	public Rigidbody b;
//	public Rigidbody c;
//	public Rigidbody d;

	public Transform a;
	public Transform b;
	public Transform c;
	public Transform d;

	public GameObject rightFoot;
	public GameObject leftFoot;

	Vector3 centroid;

	void Start () {
		
	}
	

	void Update () {
//		centroid = a.centerOfMass + b.centerOfMass + c.centerOfMass + d.centerOfMass;
		centroid = a.position + b.position + c.position + d.position;
		centroid /= 4;
//		Debug.Log (centroid);
		transform.position = centroid;

		Vector3 rightFootPos = rightFoot.transform.position;
		Vector3 newRightFootPos = new Vector3 (centroid.x - rightFootPos.x, rightFootPos.y, centroid.z - rightFootPos.z);
		rightFoot.transform.position = 
			Vector3.MoveTowards(rightFootPos, 
			                    newRightFootPos, 
			                    1f * Time.deltaTime);

		Vector3 leftFootPos = leftFoot.transform.position;
		Vector3 newleftFootPos = new Vector3 (centroid.x + leftFootPos.x, leftFootPos.y, centroid.z + leftFootPos.z);
		leftFoot.transform.position = 
			Vector3.MoveTowards(leftFootPos, 
			                    newleftFootPos, 
			                    1f * Time.deltaTime);
	}
}
