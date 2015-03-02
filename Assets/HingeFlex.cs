using UnityEngine;
using System.Collections;

public class HingeFlex : MonoBehaviour {
	HingeJoint joint;
	JointMotor jm;

	float targetVelocity;

	void Awake () {
		joint = GetComponent<HingeJoint>();
		jm = joint.motor;
		targetVelocity = 500f;

	}
	

	void Update () {
//		Debug.Log(joint.velocity + " " + tooMuchResistance());
		if(tooMuchResistance() || isFullyExtended()){
			contract();
		}else if(tooMuchResistance() || isFullyContracted()){
			extend();
		}
	}

	bool isFullyExtended(){ 
		return joint.angle <= joint.limits.min;
	}
	
	bool isFullyContracted(){
		return joint.angle >= joint.limits.max;
	}

	void contract(){
		jm.targetVelocity = targetVelocity;
		joint.motor = jm;
	}

	void extend(){
		jm.targetVelocity = -targetVelocity;
		joint.motor = jm;
	}

	bool tooMuchResistance(){
		return (joint.velocity < 1f && joint.velocity > -1f);
	}



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
