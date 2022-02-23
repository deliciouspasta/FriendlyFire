using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour {

	GameObject UFO5;
	
	float dx;
	float delta = 0;
	float deltapart = 0;
	float span = 1.0f;
	float spanpart = 3.0f;
	bool isPlay = true;
	bool isInterval = true;
	int px;
	Vector2 p1;
	Vector2 p2;
	Vector2 dir;
	float d;
	
	

	// Use this for initialization
	void Start () {
	this.UFO5 = GameObject.Find("UFO5");
	px = Random.Range(-6,7);
	p1 = transform.position;
	p2 = this.UFO5.transform.position;
	dir = p1 - p2;
    d = dir.magnitude;
	p1.x = px;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(gameObject == null){       //This is amazinguuuuuu!!!!!!!!!!
			return;
		}
		

		if(Time.time > 15){
			p1 = transform.position;
			p2 = this.UFO5.transform.position;
			dir = p1 - p2;
			d = dir.magnitude;
		
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
		
			
			if(Input.GetMouseButtonDown(0)&&isInterval){
				

			    this.dx = Mathf.Abs(p1.x - p2.x); 
				isInterval = false;
				this.deltapart = 0;
			
				if( (this.dx < 0.5f) && (p2.y < p1.y) ){
						
					isPlay = true;
					Destroy(gameObject, 1.0f);
						
						
				}
			
			}
			this.delta += Time.deltaTime;
			if(this.delta > span && isPlay){
				this.delta = 0;
			
				
				isPlay = false;
					
			
			
			}
			this.deltapart += Time.deltaTime;
			if(this.deltapart > this.spanpart){
			this.deltapart = 0;
			isInterval = true;
			
			}
		}
			
	}

	
}
