using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small3 : MonoBehaviour {

	GameObject UFO5;
	GameObject ec;
	ParticleSystem particle;
	float delta = 0;
	float deltapart = 0;
	float span = 1.0f;
	float spanpart = 3.0f;
	bool isPlay = false;
	bool isAlive = true;
	bool isInterval = true;
	
	

	// Use this for initialization
	void Start () {
		particle = this.GetComponent<ParticleSystem>();
		particle.Stop();
		this.ec = GameObject.Find("UFOEnemy(3)");		
		this.UFO5 = GameObject.Find("UFO5");
	}
	
	// Update is called once per frame
	void Update () {

		if(isAlive){
			if(Input.GetMouseButtonDown(0)&&isInterval){
			
				isInterval = false;
				deltapart = 0;      //this instantiate is important
				Vector2 ufo5posi = UFO5.transform.position;
				Vector2 ecposi = this.ec.transform.position;
				float dx = Mathf.Abs( ufo5posi.x - ecposi.x); 
			
				if( (dx < 0.5f) && (ufo5posi.y < ecposi.y) ){

					particle.transform.position = ecposi;
					particle.Play();
					this.delta = 0;         //this instantiate is important
					isPlay = false;
					isAlive = false;
				}
			
			}
			this.delta += Time.deltaTime;
			if( (this.delta > span) && isPlay){
				this.delta = 0;
				particle.Stop();
				isPlay = false;
				isAlive = false;
			}
			this.deltapart += Time.deltaTime;
			if(this.deltapart > this.spanpart){
				this.deltapart = 0;
				isInterval = true;
			}
		}
	}
	
}

