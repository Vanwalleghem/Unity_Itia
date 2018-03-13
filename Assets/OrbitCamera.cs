using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour {
	public Transform target; //the target object
	public float speedMod=20.0f; // speed modifier
	private Vector3 point; //coord point where camera looks

	// Use this for initialization
	void Start () {		
		point = target.transform.position;
		transform.LookAt(target);
		transform.RotateAround(point,Vector3.up,90);;
	}



	// Update is called once per frame
	void Update () {		
		//transform.Translate(Vector3.forward * Time.deltaTime * speedMod);
		transform.RotateAround(point,Vector3.right,speedMod * Time.deltaTime);
		if (speedMod * Time.deltaTime > 360) {
			UnityEditor.EditorApplication.ExecuteMenuItem ("Edit/Play");
		}
		//var go = GameObject.Find("Cerebellum");
		//go.renderer.material.color.a = .5;
	}


}
