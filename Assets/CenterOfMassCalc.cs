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
	public Transform e;
	public Transform f;
	public Transform g;
	public Transform h;
	public Transform aa;

	public GameObject rightFoot;
	public GameObject leftFoot;

	Vector3 centroid;

	void Start () {
		
	}
	

	void Update () {
		centroid = a.position + b.position + c.position + d.position + 
			e.position + f.position + g.position + h.position;
		centroid /= 8;

//		Debug.Log (centroid);
		transform.position = centroid;



//		Vector3 leftFootPos = leftFoot.transform.position;
////		Vector3 newleftFootPos = new Vector3 (centroid.x + leftFootPos.x, leftFootPos.y, centroid.z + leftFootPos.z);
////		Vector3 newleftFootPos = new Vector3 (centroid.x, leftFootPos.y, centroid.z);
//		Vector3 newleftFootPos = new Vector3 (h.transform.position.x, leftFootPos.y, h.transform.position.z);
//
//		leftFoot.transform.position = 
//			Vector3.MoveTowards(leftFootPos, 
//			                    newleftFootPos, 
//			                    5f * Time.deltaTime);


//		Vector3 rightFootPos = rightFoot.transform.position;
////		Vector3 newrightFootPos = new Vector3 (centroid.x + leftFootPos.x, leftFootPos.y, centroid.z + leftFootPos.z);
////		Vector3 newrightFootPos = new Vector3 (centroid.x, rightFootPos.y, centroid.z);
//		Vector3 newrightFootPos = new Vector3 (g.transform.position.x, rightFootPos.y, g.transform.position.z);
//		
//		rightFoot.transform.position = 
//			Vector3.MoveTowards(rightFootPos, 
//			                    newrightFootPos, 
//			                    5f * Time.deltaTime);


	}
}
