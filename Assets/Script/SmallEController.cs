using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEController : MonoBehaviour {

	GameObject UFO5;
	
	GameObject ec;
	ParticleSystem particle;
	float delta = 0;
	float span = 1.0f;
	bool isPlay = false;
	bool isAlive = true;
	
	

	// Use this for initialization
	void Start () {
		particle = this.GetComponent<ParticleSystem>();
		particle.Stop();
		this.ec = GameObject.Find("UFOEnemy()");
		
		
		this.UFO5 = GameObject.Find("UFO5");
	}
	
	// Update is called once per frame
	void Update () {

		if(isAlive){
			if(Input.GetMouseButtonDown(0)){
			
				Vector2 ufo5posi = UFO5.transform.position;
				Vector2 ecposi = this.ec.transform.position;
				float dx = Mathf.Abs( ufo5posi.x - ecposi.x); 
			
				if( dx < 0.5f && ufo5posi.y < ecposi.y){

					particle.transform.position = ecposi;
					//particle.Play();
					isPlay = false;
  					Debug.Log("123");	
					isAlive = false;
				}
			
			}
			this.delta += Time.deltaTime;
			if(this.delta > span && isPlay){
				this.delta = 0;
				particle.Stop();
				Debug.Log("nnnnnnn");
				isPlay = false;
				isAlive = false;
			
			
			
			}
		}
	}
	
}
