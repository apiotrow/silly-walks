using UnityEngine;
using System.Collections;

public class HingeFlex : MonoBehaviour {
	public HingeJoint joint;
	JointMotor jm;
	bool rightExtended = true;
	bool leftExtended = false;
	static HingeFlex leftOne;
	static HingeFlex rightOne;

	float targetVelocity;

	void Awake () {
		joint = GetComponent<HingeJoint>();
		jm = joint.motor;
		targetVelocity = Random.Range(50f, 300f);
//		targetVelocity = 100f;

		if(thisIsLeftLeg()) leftOne = this.gameObject.GetComponent("HingeFlex") as HingeFlex;
		else rightOne = this.gameObject.GetComponent("HingeFlex") as HingeFlex;
	}
	

	void Update () {
		if((tooMuchResistance() || isFullyExtended())){
//			if(thisIsRightLeg()){
//				rightExtended = true;
//				if(leftLegIsContracted()){
//					contract ();
//				}
//			}else if(thisIsLeftLeg()){
//				leftExtended = true;
//				if(rightLegIsContracted()){
//					contract ();
//				}
//			}
//			targetVelocity = Random.Range(50f, 300f);
			contract ();
		}else if(tooMuchResistance() || isFullyContracted()){
//			if(thisIsRightLeg()){
//				rightExtended = false;
//				if(leftLegIsExtended()){
//					extend ();
//				}
//			}else if(thisIsLeftLeg()){
//				rightExtended = true;
//				if(rightLegIsExtended()){
//					extend ();
//				}
//			}
//			targetVelocity = Random.Range(50f, 300f);
			extend ();
		}
	}

	bool rightLegIsExtended(){
		return rightOne.joint.angle <= joint.limits.min;
	}

	bool leftLegIsExtended(){
		return leftOne.joint.angle <= joint.limits.min;
	}

	bool rightLegIsContracted(){
		return rightOne.joint.angle >= joint.limits.max;
	}

	bool leftLegIsContracted(){
		return leftOne.joint.angle >= joint.limits.max;
	}

	bool thisIsRightLeg(){
		return this.transform.parent.name == "RightLeg";
	}

	bool thisIsLeftLeg(){
		return this.transform.parent.name == "LeftLeg";
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
