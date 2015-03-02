using UnityEngine;
using System.Collections;

public class JointFlex : MonoBehaviour {










	ConfigurableJoint joint;
//	JointMotor jm;
	Vector3 pos;
	Quaternion startRotation;
	
	float target;
	
	void Awake () {
		joint = GetComponent<ConfigurableJoint>();

//		joint.angularXDrive.positionSpring = 1f;

		target = 30f;
		startRotation = transform.localRotation;
	}
	
	
	void Update () {
//		pos = transform.InverseTransformPoint(joint.connectedBody.transform.position);
//		joint.targetRotation = Quaternion.Euler(new Vector3(target,
//		                                                    1f,
//		                                                    1f));

		joint.SetTargetRotationLocal( Quaternion.Euler(90f,0f,0f), startRotation);
//		Debug.Log(joint.velocity + " " + tooMuchResistance());
//		if(tooMuchResistance() || isFullyExtended()){
//			contract();
//		}else if(tooMuchResistance() || isFullyContracted()){
//			extend();
//		}
	}
	
//	bool isFullyExtended(){ 
////		return joint.angle <= joint.limits.min;
////		joint.axi
//	}
//	
//	bool isFullyContracted(){
////		return joint.angle >= joint.limits.max;
//	}
//	
//	void contract(){
//		jm.targetVelocity = targetVelocity;
////		joint.motor = jm;
//	}
//	
//	void extend(){
//		jm.targetVelocity = -targetVelocity;
////		joint.motor = jm;
//	}
//	
//	bool tooMuchResistance(){
////		return (joint.velocity < 1f && joint.velocity > -1f);
//	}
	
	
	
	//	IEnumerator contract() {
	//		while(joint.angle >= joint.limits.min){
	//			jm.targetVelocity = -50f;
	//			yield return null; 
	//		}
	//	}
	//
	//	IEnumerator extend() {
	//		while(joint.angle <= joint.limits.max){
	//			jm.targetVelocity = 50f;
	//			yield return null; 
	//		}
	//	}
	
	
}
