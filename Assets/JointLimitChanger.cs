using UnityEngine;
using System; 
using System.Collections;
using System.Collections.Generic;

public class JointLimitChanger : MonoBehaviour {

	public GameObject a;
	public GameObject b;
	public GameObject c;
	public GameObject d;
	public GameObject e;
	public GameObject f;
	public GameObject g;
	public GameObject h;

	public ConfigurableJoint jointa;
	public ConfigurableJoint jointb;
	public ConfigurableJoint jointc;
	public ConfigurableJoint jointd;
	public ConfigurableJoint jointe;
	public ConfigurableJoint jointf;
	public ConfigurableJoint jointg;
	public ConfigurableJoint jointh;

	public List<ConfigurableJoint> joints;

	public float lowxlim;
	public float highxlim;
	public float ylim;
	public float zlim;

	SoftJointLimit lowxlim_s = new SoftJointLimit();
	SoftJointLimit highxlim_s = new SoftJointLimit();
	SoftJointLimit ylim_s = new SoftJointLimit();
	SoftJointLimit zlim_s = new SoftJointLimit();

	void Start () {


		jointa = a.GetComponent<ConfigurableJoint>();
		jointb = b.GetComponent<ConfigurableJoint>();
		jointc = c.GetComponent<ConfigurableJoint>();
		jointd = d.GetComponent<ConfigurableJoint>();
		jointe = e.GetComponent<ConfigurableJoint>();
		jointf = f.GetComponent<ConfigurableJoint>();
		jointg = g.GetComponent<ConfigurableJoint>();
		jointh = h.GetComponent<ConfigurableJoint>();

		joints.Add(jointa);
		joints.Add(jointb);
		joints.Add(jointc);
		joints.Add(jointd);
		joints.Add(jointe);
		joints.Add(jointf);
		joints.Add(jointg);
		joints.Add(jointh);

		lowxlim = UnityEngine.Random.Range(-179,0);
		highxlim = UnityEngine.Random.Range(0,179);
		ylim = UnityEngine.Random.Range(0,90);
		zlim = UnityEngine.Random.Range(0,90);





	}
	

	void Update () {
		foreach(ConfigurableJoint cj in joints){
			lowxlim_s.limit = lowxlim;
			highxlim_s.limit = highxlim;
			ylim_s.limit = ylim;
			zlim_s.limit = zlim;


			cj.lowAngularXLimit = lowxlim_s;
			cj.highAngularXLimit = highxlim_s;
			cj.angularYLimit = ylim_s;
			cj.angularZLimit = zlim_s;
		}

	}
}
