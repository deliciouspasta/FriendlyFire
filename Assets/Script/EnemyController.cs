using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour {

	// Use this for initialization
	GameObject UFO5;
	
	ParticleSystem particle;
	float dx;
	float delta = 0;
	float span = 1.0f;
	bool isPlay = true;
	

	void Start(){
		this.UFO5 = GameObject.Find("UFO5");
		
	}

	
	// Update is called once per frame
	void Update () {
		Vector2 p1 = transform.position;
		Vector2 p2 = this.UFO5.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		transform.Translate(0,-0.01f,0);
		
		if(transform.position.y < 0){
			
			
			if(p1.x < p2.x){
				transform.Translate(0.01f,0,0);
			}else if(p1.x > p2.x){
				transform.Translate(-0.01f,0,0);
			}
			
		}
		if(p1.y < p2.y){
			transform.Translate(0,0.02f,0);
		}
		
		if(Input.GetMouseButtonDown(0)){
			
		    this.dx = Mathf.Abs(p1.x - p2.x); 
			
			if( this.dx < 0.5f && p2.y < p1.y){
				
				isPlay = true;
  				Debug.Log("enemy456");	
			}
			
		}
		this.delta += Time.deltaTime;
		if(this.delta > span && isPlay){
			this.delta = 0;
			
			Debug.Log("enemynnnnnnn");
			isPlay = false;
					
			
			
		}
		
		
		
		

		
	}


	
}
