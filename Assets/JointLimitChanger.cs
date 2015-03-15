using UnityEngine;
using System.Collections;
using System; 
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
	}
	

	void Update () {
		foreach(ConfigurableJoint cj in joints){

		}

		foreach(ConfigurableJoint cj in joints){

		}
	}
}
