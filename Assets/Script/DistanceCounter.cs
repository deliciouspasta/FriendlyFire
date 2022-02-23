using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCounter : MonoBehaviour {

	GameObject UFO5;
	GameObject distance;
	Vector2 pp;
	float timer;
	double susumi;
	double nokori;
	bool isArrive = false;
	
	// Use this for initialization
	void Start () {
		this.UFO5 = GameObject.Find("UFO5");
		this.distance = GameObject.Find("Distance");
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!isArrive){
			pp = this.UFO5.transform.position;
			timer = Time.time;
			susumi += timer*pp.y*(-0.1);
			nokori = 384400 - susumi;
		
			this.distance.GetComponent<Text>().text = "地球まで"+ nokori.ToString("F2") +"km";
			if(nokori <= 0){
				isArrive = true;
				this.distance.GetComponent<Text>().text = "地球まで"+ "0.00" +"km";
			}
		}
	}
}
