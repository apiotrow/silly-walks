using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIthings : MonoBehaviour {
	public Button reset;
	public Slider camslid;



	void Start () {
		reset = GameObject.Find("ResetButton").GetComponent("Button") as Button;

		reset.onClick.AddListener (() => {
			resetApp ();});

//		camslid = GameObject.Find("CameraSlider").GetComponent("Slider") as Slider;
	}

	void Update () {
//		float camzoom = camslid.value * 2;
//		SmoothLookAtC sm =  Camera.main.GetComponent("SmoothLookAtC") as SmoothLookAtC;
//		sm.minDistance = 6f * camzoom;

	}

	void resetApp(){
//		GameObject guy = GameObject.Find("GuyOrig");
//		guy.transform.position = new Vector3(-3.3f, 1f, -4.9f);
		Application.LoadLevel(Application.loadedLevel);
	}
}
