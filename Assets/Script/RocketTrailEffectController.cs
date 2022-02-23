using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketTrailEffectController : MonoBehaviour {

	public GameObject RocketTrailEffect;
	Vector3 screenToWorldPointPosition;
	ParticleSystem particle;
	Camera camerarc;
	float span = 3.0f;
	float delta = 0;
	bool isInterval = true;
	
	

	// Use this for initialization
	void Start () {
		particle = this.GetComponent<ParticleSystem>();
		particle.Stop();
		Debug.Log("wwwwwwwwwwww");
	}
	
	void Update(){
		if(Input.GetMouseButtonDown(0) && isInterval){
			Vector3 mousePosi = Input.mousePosition;
			mousePosi.z = 10.0f;
			screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(mousePosi);
			particle.transform.position = screenToWorldPointPosition;
			particle.Play();
			//Update();
			Debug.Log("qqqqqqqqqqqqq");
			isInterval = false;
			delta = 0;

		}
		this.delta += Time.deltaTime;
		if(this.delta > this.span){
			this.delta = 0;
			isInterval = true;
			
		}
		

	}
	// Update is called once per frame
	/*public void OnTriggerEnter(){
		
		Vector3 mousePosi = Input.mousePosition;
		mousePosi.z = 10.0f;
		screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(mousePosi);
		particle.transform.position = screenToWorldPointPosition;
		particle.Play();
		//Update();
		Debug.Log("qqqqqqqqqqqqq");

	}*/
	/*void Update(){
		this.delta += Time.deltaTime;
		if(this.delta > this.span){
			particle.Stop();
			Debug.Log("stoooooop");
			
		}
	}*/

}
